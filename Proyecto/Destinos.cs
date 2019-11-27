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
    public partial class Destinos : Form
    {
        SQL sql = new SQL();
        public Destinos()
        {
            InitializeComponent();
        }

        private void Destinos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paqueteDataSet.destino' table. You can move, or remove it, as needed.
            this.destinoTableAdapter.Fill(this.paqueteDataSet.destino);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                sql.crearDestino(textBox2.Text);
                MessageBox.Show("Agregado con exito!");
                this.destinoTableAdapter.Fill(this.paqueteDataSet.destino);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                sql.borrarTupla("destino", "Dest", Convert.ToInt32(textBox3.Text));
                MessageBox.Show("Borrado con exito!");
                this.destinoTableAdapter.Fill(this.paqueteDataSet.destino);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                sql.modificarDestino(Convert.ToInt32(textBox4.Text),textBox5.Text);
                MessageBox.Show("Modificado con exito!");
                this.destinoTableAdapter.Fill(this.paqueteDataSet.destino);
            }
        }
    }
}
