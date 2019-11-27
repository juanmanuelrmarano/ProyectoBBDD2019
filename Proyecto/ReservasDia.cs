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
    public partial class ReservasDia : Form
    {
        public ReservasDia()
        {
            InitializeComponent();
        }

        private void ReservasDia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paqueteDataSet.verReservaDiaria' table. You can move, or remove it, as needed.
            this.verReservaDiariaTableAdapter.Fill(this.paqueteDataSet.verReservaDiaria);

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Hide();
        }
    }
}
