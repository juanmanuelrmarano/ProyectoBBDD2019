using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//LOS PAQUETES LOS ARMA EL CLIENTE!!!!!!

namespace Proyecto
{
    public partial class frmUsuarios : Form
    {
        SQL sql = new SQL();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!sql.buscarUsuario(txtUsuario.Text,txtContra.Text))
            {
                MessageBox.Show("Hubo un error en el login. Revise los campos.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                //Logeo exitoso
                if (sql.obtenerPermiso(txtUsuario.Text) == "Dueño")
                {
                    Globales.modoDueno = true;
                }
                Globales.nUsuario = txtUsuario.Text;
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                this.Hide();
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistroUsuarios registro = new frmRegistroUsuarios();
            registro.Show();
            this.Hide();
        }
    }

    public static class Globales
    {
        public static Boolean modoDueno = false;
        public static String nUsuario = "";
        public static int precioPaquete = 0, IDpaquete = 0;
    }
}
