using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ZeroXLauncher.modelos;

namespace ZeroXLauncher.controladores
{
    public static class ControladorPerfiles
    {
        private static readonly string rutaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles.json");

        private static List<PerfilLauncher> perfiles = new();

        public static List<PerfilLauncher> ObtenerPerfiles()
        {
            if (!File.Exists(rutaJson))
            {
                Guardar(); // crea archivo inicial
                return perfiles;
            }

            var json = File.ReadAllText(rutaJson);
            perfiles = JsonSerializer.Deserialize<List<PerfilLauncher>>(json) ?? new List<PerfilLauncher>();
            return perfiles;
        }

        public static void Guardar()
        {
            var json = JsonSerializer.Serialize(perfiles, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(rutaJson, json);
        }

        public static void AgregarPerfil(PerfilLauncher nuevo)
        {
            perfiles.Add(nuevo);
            Guardar();
        }

        public static void EliminarPerfil(string nombre)
        {
            perfiles = perfiles.Where(p => p.NombrePerfil != nombre).ToList();
            Guardar();
        }

        public static PerfilLauncher? ObtenerPerfilPorNombre(string nombre)
        {
            return perfiles.FirstOrDefault(p => p.NombrePerfil == nombre);
        }

        public static List<string> ObtenerNombresParaComboBox()
        {
            return ObtenerPerfiles().Select(p => p.NombrePerfil).ToList();
        }
    }
}
