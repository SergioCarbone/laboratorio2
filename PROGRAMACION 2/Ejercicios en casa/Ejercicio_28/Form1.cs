using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<string> Palabra = new List<string>();
            int contador = 1;
            Class1.diccionario = new Dictionary<string, int>();

            if (Class1.diccionario.ContainsKey(textBox1.Text))
            {

            }
            else
            {
                Class1.diccionario.Add(textBox1.Text, contador);
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
