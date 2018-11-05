using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_60_Libreria;

namespace Ejercicio_60
{
    public partial class Form1 : Form
    {
        Class1 c;        
        public Form1()
        {
            InitializeComponent();
            c = new Class1();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {            
            try
            {
                c.Mostrar();                
                foreach (Producto p in c.lista)
                {
                    richTextBox1.Text += string.Format("\n Id: {0} Name: {1} ProductNumber: {0}",p.Id , p.Name, p.ProductNumber);
                }
                
            }
            catch(Exception w)
            {
                MessageBox.Show("Error, no se conecto",w.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                        
        }
    }
}
