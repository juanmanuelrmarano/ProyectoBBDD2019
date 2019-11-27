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
    public partial class Presupuestos : Form
    {
        public Presupuestos()
        {
            InitializeComponent();
        }

        private void Presupuestos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paqueteDataSet.presupuesto' table. You can move, or remove it, as needed.
            this.presupuestoTableAdapter.Fill(this.paqueteDataSet.presupuesto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Hide();
        }
    }
}
