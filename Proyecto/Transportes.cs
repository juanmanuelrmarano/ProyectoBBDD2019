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
    public partial class Transportes : Form
    {
        SQL sql = new SQL();
        public Transportes()
        {
            InitializeComponent();
        }

        private void Transportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paqueteDataSet.transporte' table. You can move, or remove it, as needed.
            this.transporteTableAdapter.Fill(this.paqueteDataSet.transporte);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                sql.crearTransporte(textBox2.Text, Convert.ToInt32(textBox6.Text), textBox7.Text, textBox10.Text, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text));
                MessageBox.Show("Agregado con exito!");
                this.transporteTableAdapter.Fill(this.paqueteDataSet.transporte);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                sql.borrarTupla("transporte","Trans",Convert.ToInt32(textBox3.Text));
                MessageBox.Show("Borrado con exito!");
                this.transporteTableAdapter.Fill(this.paqueteDataSet.transporte);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sql.modificarTransporte(Convert.ToInt32(textBox1.Text), textBox23.Text, Convert.ToInt32(textBox20.Text), textBox21.Text, textBox19.Text, Convert.ToInt32(textBox16.Text), Convert.ToInt32(textBox18.Text));
                MessageBox.Show("Modificado con exito!");
                this.transporteTableAdapter.Fill(this.paqueteDataSet.transporte);
            }
        }
    }
}
