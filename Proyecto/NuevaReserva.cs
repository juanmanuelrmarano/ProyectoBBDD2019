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
    public partial class NuevaReserva : Form
    {
        private SQL sql;
        public NuevaReserva()
        {
            InitializeComponent();
            sql = new SQL();
        }

        private void NuevaReserva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paqueteDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.paqueteDataSet.cliente);
            // TODO: This line of code loads data into the 'paqueteDataSet.destino' table. You can move, or remove it, as needed.
            this.destinoTableAdapter.Fill(this.paqueteDataSet.destino);
            // TODO: This line of code loads data into the 'paqueteDataSet.verTodosLosPaquetes' table. You can move, or remove it, as needed.
            this.verTodosLosPaquetesTableAdapter.Fill(this.paqueteDataSet.verTodosLosPaquetes);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Hide();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Boolean correcto = true;

            grpSena.Enabled = false;

            if (txtDes.Text != "" && txtCliente.Text != "" && txtPres.Text != "")
            {
                //verificacion nro de presupuesto
                if (!sql.verificarPres(Convert.ToInt32(txtPres.Text)))
                {
                    lblValidacionNroPres.ForeColor = Color.Red;
                    lblValidacionNroPres.Text = "Nro de presupuesto Incorrecto";
                    correcto = false;
                }
                else
                {
                    lblValidacionNroPres.ForeColor = Color.ForestGreen;
                    lblValidacionNroPres.Text = "Nro Correcto";
                }

                //verificacion nro de destino
                if (!sql.verificarCliente(Convert.ToInt32(txtCliente.Text)))
                {
                    lblValidacionNroCliente.ForeColor = Color.Red;
                    lblValidacionNroCliente.Text = "Nro de Cliente incorrecto";
                    correcto = false;
                }
                else
                {
                    lblValidacionNroCliente.ForeColor = Color.ForestGreen;
                    lblValidacionNroCliente.Text = "Nro Correcto";
                }

                //verificacion de plazas
                if (sql.verificarDestino(Convert.ToInt32(txtDes.Text)))
                {
                    lblValidacionIDDest.ForeColor = Color.Red;
                    lblValidacionIDDest.Text = "No hay plazas";
                    correcto = false;
                }
                else
                {
                    lblValidacionIDDest.ForeColor = Color.ForestGreen;
                    lblValidacionIDDest.Text = "Hay plazas";
                }

                //verificacion de todo correcto
                if (correcto)
                {
                    grpSena.Enabled = true;
                    grpDatos.Enabled = false;
                }
                else
                {
                    grpSena.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Alguno de los campos esta vacio, todos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            if (txtSena.Text != "")
            {
                sql.crearReserva_Comprobante(Convert.ToInt32(txtPres.Text), Convert.ToInt32(txtSena.Text), Convert.ToInt32(txtCliente.Text));
                sql.actualizarPlazas(Convert.ToInt32(txtDes.Text));
            }
            else
            {
                MessageBox.Show("El campo Seña es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
