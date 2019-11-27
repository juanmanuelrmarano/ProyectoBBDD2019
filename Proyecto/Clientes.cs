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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paqueteDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.paqueteDataSet.cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Hide();
        }
    }
}
