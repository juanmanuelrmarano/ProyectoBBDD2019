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
    public partial class txtIDCliente : Form
    {
        private SQL sql;

        public txtIDCliente()
        {
            InitializeComponent();
            sql = new SQL();
        }

        private void frmNuevoPaquete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paqueteDataSet.paq_exc' table. You can move, or remove it, as needed.
            this.paq_excTableAdapter.Fill(this.paqueteDataSet.paq_exc);
            // TODO: This line of code loads data into the 'paqueteDataSet.excursion' table. You can move, or remove it, as needed.
            this.excursionTableAdapter.Fill(this.paqueteDataSet.excursion);
            // TODO: This line of code loads data into the 'paqueteDataSet1.transporte' table. You can move, or remove it, as needed.
            this.transporteTableAdapter.Fill(this.paqueteDataSet1.transporte);
            // TODO: This line of code loads data into the 'paqueteDataSet1.destino' table. You can move, or remove it, as needed.
            this.destinoTableAdapter.Fill(this.paqueteDataSet1.destino);
            // TODO: This line of code loads data into the 'paqueteDataSet1.hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.paqueteDataSet1.hotel);
            // TODO: This line of code loads data into the 'paqueteDataSet.verExcursionesPaquete' table. You can move, or remove it, as needed.
            this.verExcursionesPaqueteTableAdapter.Fill(this.paqueteDataSet.verExcursionesPaquete);
            // TODO: This line of code loads data into the 'paqueteDataSet.verTodosLosPaquetes' table. You can move, or remove it, as needed.
            this.verTodosLosPaquetesTableAdapter.Fill(this.paqueteDataSet.verTodosLosPaquetes);

            lblPrecio.Text = Globales.precioPaquete.ToString();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Hide();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtEmailusuario.Text == "" || txtEmaildominio.Text == "")
            {
                MessageBox.Show("Alguno de los campos esta vacio, todos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String EmailFinal = txtEmailusuario.Text + "@" + txtEmaildominio.Text;
                sql.agregarCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, EmailFinal);
                lblNroCliente.Text = (sql.obtenerUltimoClienteID()).ToString();
            }
        }

        private void btnCrearPaquete_Click(object sender, EventArgs e)
        {
            int IDPaquete = 0;
            if (txtDestino.Text == "" || txtHotel.Text == "" || txtTransporte.Text == "")
            {
                MessageBox.Show("Alguno de los campos esta vacio, todos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IDPaquete = sql.crearPaquete(Convert.ToInt32(txtDestino.Text), Convert.ToInt32(txtHotel.Text), Convert.ToInt32(txtTransporte.Text), fchSalida.Value, fchLlegada.Value);
                if (txtNroCliente.Text != "")
                {
                    sql.crearPresupuesto(Convert.ToInt32(txtNroCliente.Text), IDPaquete);
                }
                else
                {
                    if (lblNroCliente.Text == "")
                    {
                        MessageBox.Show("No hay cliente nuevo creado, ni cliente existente seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sql.crearPresupuesto(Convert.ToInt32(lblNroCliente.Text), IDPaquete);
                    }
                }
                this.verTodosLosPaquetesTableAdapter.Fill(this.paqueteDataSet.verTodosLosPaquetes);
                MessageBox.Show("Paquete y presupuesto creados.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnExcursiones.Enabled = true;
            }
        }

        private void txtHotel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTransporte_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDefDatos_Click(object sender, EventArgs e)
        {
            Globales.precioPaquete = 0;
            if (sql.devolverPrecioHotel(Convert.ToInt32(txtHotel.Text)) == 0 || sql.devolverPrecioTrans(Convert.ToInt32(txtTransporte.Text)) == 0)
            {
                MessageBox.Show("Alguno de los campos esta incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Globales.precioPaquete += (sql.devolverPrecioHotel(Convert.ToInt32(txtHotel.Text)) * (fchLlegada.Value - fchSalida.Value).Days) + sql.devolverPrecioTrans(Convert.ToInt32(txtTransporte.Text));
                lblPrecio.Text = Globales.precioPaquete.ToString();
            }
        }

        private void btnExcursiones_Click(object sender, EventArgs e)
        {
            AgregarExcursionesPaquete frm = new AgregarExcursionesPaquete();
            frm.Show();
        }
    }
}
