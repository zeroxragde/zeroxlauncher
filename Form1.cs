using System.Diagnostics;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using ZeroXLauncher.controladores;
using ZeroXLauncher.modelos;

namespace ZeroXLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarVersionesMinecraft();
            LlenarOpcionesRam();

        }

        private void CargarComboPerfiles()
        {
            cbPerfiles.Items.Clear();
            var nombres = ControladorPerfiles.ObtenerNombresParaComboBox();

            foreach (var nombre in nombres)
                cbPerfiles.Items.Add(nombre);

            if (cbPerfiles.Items.Count > 0)
                cbPerfiles.SelectedIndex = 0;
        }
        private async void CargarVersionesMinecraft()
        {
            using HttpClient client = new HttpClient();
            try
            {
                string manifestUrl = "https://launchermeta.mojang.com/mc/game/version_manifest.json";
                string json = await client.GetStringAsync(manifestUrl);

                var manifest = JsonSerializer.Deserialize<VersionManifest>(json);

                cbVersion.Items.Clear();

                foreach (var version in manifest.versions)
                {
                    cbVersion.Items.Add(version.id);
                }

                // Selecciona la versión release más reciente
                cbVersion.SelectedItem = manifest.latest.release;
            }
            catch (Exception ex)
            {
                EscribirConsola($"Error al obtener versiones: {ex.Message}");
            }
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            buttonLaunch(sender, e);
        }

        private async void buttonLaunch(object sender, EventArgs e)
        {
            string version = cbVersion.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(version))
            {
                EscribirConsola("Selecciona una versión.");
                return;
            }

            string username = txtUser.Text.Trim();
            if (string.IsNullOrEmpty(username)) username = "Player";
            string uuid = GenerarUUIDOffline(username);

            string mcDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin");
            string versionDir = Path.Combine(mcDir, version); // <--- sin "versions"

            await DescargarYPrepararVersion(version, mcDir);

            string classpathFile = Path.Combine(versionDir, "classpath.txt");
            if (!File.Exists(classpathFile))
            {
                EscribirConsola("No se generó el classpath.txt");
                return;
            }

            string classpath = File.ReadAllText(classpathFile);
            string mainClass = await ObtenerMainClass(version);


            string javaPath = await PrepararJavaAsync();
            if (string.IsNullOrEmpty(javaPath)) return;
            // Validar si Java es de 64 bits
            if (!EsJava64Bits(javaPath))
            {
                EscribirConsola("Advertencia: estás usando Java de 32 bits. No podrás asignar más de ~1.5 GB de RAM.\n\nInstala Java de 64 bits para mejor rendimiento.\r\n Java 32-bit detectado");
            }

            string argumentos = $"-Xmx6G -Xms2G -cp \"{classpath}\" {mainClass} " +
                                $"--username \"{username}\" " +
                                $"--version \"{version}\" " +
                                $"--gameDir \"{Path.Combine(mcDir, version)}\" " +
                                $"--assetsDir \"{Path.Combine(mcDir, "assets")}\" " +
                                $"--accessToken \"0\" " +
                                $"--uuid \"{uuid}\" " +
                                $"--userType \"legacy\" " +
                                $"--versionType \"release\"";
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = javaPath,
                Arguments = argumentos,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var proceso = Process.Start(psi);

            _ = Task.Run(async () =>
            {
                while (!proceso.StandardOutput.EndOfStream)
                    EscribirConsola(await proceso.StandardOutput.ReadLineAsync());

                while (!proceso.StandardError.EndOfStream)
                    EscribirConsola(await proceso.StandardError.ReadLineAsync());
            });

            try
            {
                var proc = Process.Start(psi);
                string salida = await proc.StandardOutput.ReadToEndAsync();
                string error = await proc.StandardError.ReadToEndAsync();
                await proc.WaitForExitAsync();

                File.WriteAllText("log_mc.txt", salida + "\n\n" + error);

                if (!string.IsNullOrWhiteSpace(error))
                {
                    EscribirConsola("Minecraft lanzó un error. Revisa log_mc.txt");
                }
            }
            catch (Exception ex)
            {
                EscribirConsola("Error al iniciar el juego: " + ex.Message);
            }
        }
        private static bool EsJava64Bits(string javaPath)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = javaPath,
                    Arguments = "-version",
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using var process = Process.Start(psi);
                string salida = process.StandardError.ReadToEnd();
                process.WaitForExit();

                return salida.Contains("64-Bit") || salida.Contains("64-bit");
            }
            catch
            {
                return false; // Si no se pumimos que no
            }
        }
        public static string GenerarUUIDOffline(string username)
        {
            string baseName = username;
            byte[] input = Encoding.UTF8.GetBytes(baseName);

            using var md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(input);

            // Se aplican bits específicos para que sea UUID tipo 3 como Mojang lo espera
            hash[6] &= 0x0f;
            hash[6] |= 0x30;
            hash[8] &= 0x3f;
            hash[8] |= 0x80;

            return new Guid(hash).ToString();
        }

        private async Task DescargarYPrepararVersion(string version, string basePath)
        {
            string versionDir = Path.Combine(basePath, version);
            string librariesDir = Path.Combine(basePath, "libraries");
            Directory.CreateDirectory(versionDir);
            Directory.CreateDirectory(librariesDir);

            using HttpClient client = new HttpClient();

            // Descargar manifest general
            string manifestUrl = "https://launchermeta.mojang.com/mc/game/version_manifest.json";
            var manifestJson = await client.GetStringAsync(manifestUrl);
            var manifestDoc = JsonDocument.Parse(manifestJson);
            var versionData = manifestDoc.RootElement.GetProperty("versions")
                .EnumerateArray().FirstOrDefault(v => v.GetProperty("id").GetString() == version);

            if (versionData.ValueKind == JsonValueKind.Undefined)
                throw new Exception("Versión no encontrada.");

            string versionJsonUrl = versionData.GetProperty("url").GetString();
            var versionJson = await client.GetStringAsync(versionJsonUrl);
            var meta = JsonSerializer.Deserialize<VersionMeta>(versionJson);

            // Descargar client.jar
            string jarUrl = meta.downloads.client.url;
            string jarPath = Path.Combine(versionDir, version + ".jar");
            if (!File.Exists(jarPath))
            {
                byte[] jarBytes = await client.GetByteArrayAsync(jarUrl);
                await File.WriteAllBytesAsync(jarPath, jarBytes);
            }

            // Descargar librerías
            List<string> classpath = new() { jarPath };
            foreach (var lib in meta.libraries)
            {
                var artifact = lib.downloads?.artifact;
                if (artifact?.url == null || artifact.path == null) continue;

                string libPath = Path.Combine(librariesDir, artifact.path.Replace("/", "\\"));
                Directory.CreateDirectory(Path.GetDirectoryName(libPath)!);

                if (!File.Exists(libPath))
                {
                    byte[] libBytes = await client.GetByteArrayAsync(artifact.url);
                    await File.WriteAllBytesAsync(libPath, libBytes);
                }

                classpath.Add(libPath);
            }

            // Guardar el classpath para uso posterior
            await File.WriteAllTextAsync(Path.Combine(versionDir, "classpath.txt"), string.Join(";", classpath));

            EscribirConsola($"Versión {version} descargada correctamente en:\n{versionDir}");
        }

        private async Task<string> ObtenerMainClass(string version)
        {
            using HttpClient client = new HttpClient();
            string manifestUrl = "https://launchermeta.mojang.com/mc/game/version_manifest.json";
            var manifestJson = await client.GetStringAsync(manifestUrl);
            var manifestDoc = JsonDocument.Parse(manifestJson);
            var versionData = manifestDoc.RootElement.GetProperty("versions")
                .EnumerateArray().FirstOrDefault(v => v.GetProperty("id").GetString() == version);
            string versionJsonUrl = versionData.GetProperty("url").GetString();
            var versionJson = await client.GetStringAsync(versionJsonUrl);
            var versionMeta = JsonDocument.Parse(versionJson);
            return versionMeta.RootElement.GetProperty("mainClass").GetString();
        }

        private void EscribirConsola(string mensaje)
        {
            if (txtConsola.InvokeRequired)
            {
                txtConsola.Invoke(new Action(() => EscribirConsola(mensaje)));
            }
            else
            {
                txtConsola.Text += $"[{DateTime.Now:HH:mm:ss}] {mensaje}\r\n";
                txtConsola.SelectionStart = txtConsola.Text.Length;
                txtConsola.ScrollToCaret();
            }
        }

        private static int ObtenerRamTotalMB()
        {
            return (int)(GC.GetGCMemoryInfo().TotalAvailableMemoryBytes / 1024 / 1024);

        }
        private void LlenarOpcionesRam()
        {
            int totalMB = ObtenerRamTotalMB();
            int maxMB = Math.Min(totalMB, 32768); // límite razonable por seguridad
            int maxUsable = (int)(maxMB * 0.75);  // no usar más del 75%

            cbRam.Items.Clear();

            // Agrega desde 1 GB hasta el máximo usable
            for (int mb = 1024; mb <= maxUsable; mb += 512)
            {
                cbRam.Items.Add($"{mb / 1024} GB");
            }

            // Selecciona automáticamente un valor recomendado (ej. 4GB)
            string recomendado = $"{Math.Min(4 * 1024, maxUsable) / 1024} GB";
            if (cbRam.Items.Contains(recomendado))
                cbRam.SelectedItem = recomendado;
            else
                cbRam.SelectedIndex = cbRam.Items.Count - 1;
        }

        private async Task<string> PrepararJavaAsync(bool forzarActualizacion = false)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string javaDir = Path.Combine(basePath, "runtime", "java-21");
            string javaExe = Directory.GetFiles(javaDir, "java.exe", SearchOption.AllDirectories)
                .FirstOrDefault() ?? "";
            if (string.IsNullOrEmpty(javaExe) || !File.Exists(javaExe))
            {
                EscribirConsola("No se encontró java.exe en la ruta.");
                return null!;
            }
            string versionTxt = Path.Combine(basePath, "runtime", "version.txt");
            string zipLocal = Path.Combine(basePath, "javaSDK.zip");

            string versionActual = File.Exists(versionTxt) ? File.ReadAllText(versionTxt).Trim() : "";
            string ultimaVersion = await ObtenerUltimaVersionJava() ?? versionActual;

            // Si no hay java o se forza actualización
            if (forzarActualizacion || !File.Exists(javaExe) || versionActual != ultimaVersion)
            {
                bool exito = false;

                // 1. Si hay jdk.zip local, usarlo
                if (File.Exists(zipLocal))
                {
                    try
                    {
                        ZipFile.ExtractToDirectory(zipLocal, javaDir, true);
                        exito = true;
                    }
                    catch (Exception ex)
                    {
                        EscribirConsola("Error al extraer jdk.zip local: " + ex.Message);
                    }
                }

                // 2. Si falla, intentar Temurin
                if (!exito)
                {
                    string temurinUrl = $"https://api.adoptium.net/v3/binary/latest/21/ga/windows/x64/jdk/hotspot/normal/eclipse?project=jdk";
                    exito = await DescargarYExtraerJavaDesdeUrl(temurinUrl, javaDir);
                }

                // 3. Si también falla, usar Google Drive
                if (!exito)
                {
                    string googleDrive = "https://drive.google.com/uc?export=download&id=1iDZi7pNeCsUGARFboVMhh9t7H0w6VUqB";
                    exito = await DescargarYExtraerJavaDesdeUrl(googleDrive, javaDir);
                }

                if (!exito)
                {
                    EscribirConsola("No se pudo preparar Java desde ninguna fuente.");
                    return null!;
                }

                File.WriteAllText(versionTxt, ultimaVersion);
            }

            return javaExe;
        }

        private async Task<string?> ObtenerUltimaVersionJava()
        {
            try
            {
                using HttpClient client = new HttpClient();
                string url = "https://api.adoptium.net/v3/info/release_versions?version=21&release_type=ga&os=windows&architecture=x64&image_type=jdk";
                var json = await client.GetStringAsync(url);
                var doc = JsonDocument.Parse(json);
                return doc.RootElement.GetProperty("most_recent").GetString();
            }
            catch
            {
                return null;
            }
        }

        private async Task<bool> DescargarYExtraerJavaDesdeUrl(string url, string destino)
        {
            try
            {
                string tempZip = Path.Combine(Path.GetTempPath(), "java_tmp.zip");
                using HttpClient client = new HttpClient();
                byte[] bytes = await client.GetByteArrayAsync(url);
                await File.WriteAllBytesAsync(tempZip, bytes);
                ZipFile.ExtractToDirectory(tempZip, destino, true);
                File.Delete(tempZip);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnUpdateJava_Click(object sender, EventArgs e)
        {
            updateJava();
        }

        private async void updateJava()
        {
            var ok = await PrepararJavaAsync(forzarActualizacion: true);
            if (!string.IsNullOrEmpty(ok))
                EscribirConsola("Java actualizado correctamente.");
        }

        ///////////////////////////////////////////////////////////////////
    }
}
