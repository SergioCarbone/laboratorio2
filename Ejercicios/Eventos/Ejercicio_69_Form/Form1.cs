using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_69_Form
{
    public partial class Form1 : Form
    {
        FrmTestDelegados forma;
        frmDatos datos;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma = new FrmTestDelegados();
            forma.Owner = this;
            forma.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datos = new frmDatos();
            datos.Owner = this;
            datos.Show();
        }
    }
}
