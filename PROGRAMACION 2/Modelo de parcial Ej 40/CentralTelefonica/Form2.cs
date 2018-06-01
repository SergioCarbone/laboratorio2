using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefonica
{
    public partial class Form2 : Form
    {
        Provincial.Franja Franjas = new Provincial.Franja();

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Carga
            
            comboBox1.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            // Lectura
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(comboBox1.SelectedValue.ToString(), out franjas);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "Franja";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "1";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "2";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Text = "3";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Text = "4";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Text = "5";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Text = "6";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Text = "7";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.Text = "8";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.Text = "9";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1.Text = "0";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "*";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button1.Text = "#";
            string nro = button1.Text;
            textBox1.Text += nro;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text[0] == '#')
            {
                textBox1.Text = "provincial";             
            }
            else
            {
                textBox1.Text = "local";
            }           
        }
    }
}
