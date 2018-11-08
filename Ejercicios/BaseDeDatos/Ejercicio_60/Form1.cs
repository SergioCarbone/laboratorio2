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
        SqlPrueba c;
        public Form1()
        {
            InitializeComponent();
            c = new SqlPrueba();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {            
            try
            {
                listBox1.Items.Clear();
                c.Mostrar();                
                foreach (Producto p in c.lista)
                {
                    listBox1.Items.Add(p);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form3 agregar = new Form3();
            agregar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Producto p1;
            p1 = (Producto)listBox1.SelectedItem;
            Form2 modificar = new Form2(p1);
            modificar.ShowDialog();            
        }
    }
}
