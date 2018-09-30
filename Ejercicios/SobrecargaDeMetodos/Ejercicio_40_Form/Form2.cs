using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_40_libreria;

namespace Ejercicio_40_Form
{
    public partial class Form2 : Form
    {
        public Form2(Centralita c)
        {
            InitializeComponent();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmMenu a = new FrmMenu();
            a.Show();
            this.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNumOrigen.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNumOrigen.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNumOrigen.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNumOrigen.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNumOrigen.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNumOrigen.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNumOrigen.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNumOrigen.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {            
            txtNumOrigen.Text += 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNumOrigen.Text += 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumOrigen.Text = "";
            txtNumDestino.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNumDestino_TextChanged(object sender, EventArgs e)
        {                
        }
    }
}
