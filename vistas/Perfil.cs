using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeroXLauncher.modelos;

namespace ZeroXLauncher.vistas
{
    public partial class Perfil : Form
    {
        public PerfilLauncher PerfilEditado { get; private set; }

        public Perfil()
        {
            InitializeComponent();
        }

        public Perfil(PerfilLauncher perfil)
        {
            InitializeComponent();
            PerfilEditado = perfil;

            // Asignar los valores al formulario
            wForm.Text = perfil.NombrePerfil;
            txtUser.Text = perfil.NombrePerfil;
            /* txtUUID.Text = perfil.UUID;
             cbVersion.Text = perfil.VersionMinecraft;
             nudRAM.Value = perfil.RamMB;*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
