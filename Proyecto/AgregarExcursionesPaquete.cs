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
    public partial class AgregarExcursionesPaquete : Form
    {
        private SQL sql;
        public AgregarExcursionesPaquete()
        {
            InitializeComponent();
            sql = new SQL();
        }

        private void AgregarExcursionesPaquete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paqueteDataSet.excursion' table. You can move, or remove it, as needed.
            this.excursionTableAdapter.Fill(this.paqueteDataSet.excursion);

        }

        private void btnAgregarExc_Click(object sender, EventArgs e)
        {
            if (txtExc.Text != "")
            {
                sql.agregarExc(Convert.ToInt32(txtExc.Text));
            }
            else
            {
                MessageBox.Show("No puso nada en el campo ID Excursion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarExc_Click(object sender, EventArgs e)
        {
            if (txtExc.Text != "")
            {
                sql.borrarExc(Convert.ToInt32(txtExc.Text));
            }
            else
            {
                MessageBox.Show("No puso nada en el campo ID Excursion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
