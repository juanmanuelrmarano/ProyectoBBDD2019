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
    public partial class Hoteles : Form
    {
        SQL sql = new SQL();
        public Hoteles()
        {
            InitializeComponent();
        }

        private void Hoteles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paqueteDataSet.hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.paqueteDataSet.hotel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.hotelTableAdapter.Insert(10, "JK", "wa", 2, 231, 234, 4, "ads");
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                sql.crearHotel(textBox2.Text, textBox6.Text, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), textBox16.Text);
                MessageBox.Show("Agregado con exito!");
                this.hotelTableAdapter.Fill(this.paqueteDataSet.hotel);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                sql.borrarTupla("hotel", "Hotel", Convert.ToInt32(textBox3.Text));
                MessageBox.Show("Borrado con exito!");
                this.hotelTableAdapter.Fill(this.paqueteDataSet.hotel);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sql.modificarHotel(Convert.ToInt32(textBox1.Text), textBox17.Text, textBox13.Text, Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox11.Text), textBox4.Text);
                MessageBox.Show("Modificado con exito!");
                this.hotelTableAdapter.Fill(this.paqueteDataSet.hotel);
            }
        }
    }
}
