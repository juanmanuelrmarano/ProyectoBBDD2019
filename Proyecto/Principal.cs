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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Globales.modoDueno == true)
            {
                this.Text = this.Text + " - (Modo Dueño)";
                btnReservasDia.Visible = true;
            }
            lblUsuario.Text += " " + Globales.nUsuario;
        }

        private void btnNuevoPaquete_Click(object sender, EventArgs e)
        {
            txtIDCliente frm = new txtIDCliente();
            frm.Show();
            this.Hide();
        }

        private void btnPaquetes_Click(object sender, EventArgs e)
        {
            Hoteles frm = new Hoteles();
            frm.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.Show();
            this.Hide();
        }

        private void btnPresupuestos_Click(object sender, EventArgs e)
        {
            Presupuestos frm = new Presupuestos();
            frm.Show();
            this.Hide();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            Reservas frm = new Reservas();
            frm.Show();
            this.Hide();
        }

        private void btnComprobantes_Click(object sender, EventArgs e)
        {
            Comprobantes frm = new Comprobantes();
            frm.Show();
            this.Hide();
        }

        private void btnExcursiones_Click(object sender, EventArgs e)
        {
            Excursiones frm = new Excursiones();
            frm.Show();
            this.Hide();
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            Transportes frm = new Transportes();
            frm.Show();
            this.Hide();
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            Destinos frm = new Destinos();
            frm.Show();
            this.Hide();
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            NuevaReserva frm = new NuevaReserva();
            frm.Show();
            this.Hide();
        }

        private void btnReservasDia_Click(object sender, EventArgs e)
        {
            ReservasDia frm = new ReservasDia();
            frm.Show();
            this.Hide();
        }
    }
}
