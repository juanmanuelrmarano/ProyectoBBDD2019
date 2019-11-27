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
    public partial class Excursiones : Form
    {
        SQL sql = new SQL();
        public Excursiones()
        {
            InitializeComponent();
        }

        private void Excursiones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paqueteDataSet.excursion' table. You can move, or remove it, as needed.
            this.excursionTableAdapter.Fill(this.paqueteDataSet.excursion);

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
                sql.crearExcursion(Convert.ToInt32(textBox2.Text), textBox6.Text, textBox7.Text, Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox8.Text), dateTimePicker1.Value);
                MessageBox.Show("Agregado con exito!");
                this.excursionTableAdapter.Fill(this.paqueteDataSet.excursion);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                sql.borrarTupla("excursion", "Excur", Convert.ToInt32(textBox3.Text));
                MessageBox.Show("Borrado con exito!");
                this.excursionTableAdapter.Fill(this.paqueteDataSet.excursion);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                sql.modificarExcursion(Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox15.Text), textBox12.Text, textBox13.Text, Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox4.Text), dateTimePicker2.Value);
                MessageBox.Show("Modificado con exito!");
                this.excursionTableAdapter.Fill(this.paqueteDataSet.excursion);
            }
        }
    }
}
