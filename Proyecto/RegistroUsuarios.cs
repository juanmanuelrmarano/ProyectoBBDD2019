using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmRegistroUsuarios : Form
    {
        private SQL sql;
        public frmRegistroUsuarios()
        {
            InitializeComponent();
            sql = new SQL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.Show();
            this.Hide();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtCon.Text == "" && txtCon2.Text == "")
            {
                MessageBox.Show("Alguno de los campos esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtCon.Text != txtCon2.Text)
                {
                    MessageBox.Show("Las contraseñas en ambos campos deben coincidir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sql.crearUsuario(txtNombre.Text, txtCon.Text);
                    MessageBox.Show("Usuario Creado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmUsuarios frm = new frmUsuarios();
                    frm.Show();
                    this.Hide();
                }
            }
        }
    }
}
