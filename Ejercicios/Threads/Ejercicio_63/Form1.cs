using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio_63
{
    public partial class Form1 : Form
    {
        Thread t1;
        public Form1()
        {
            InitializeComponent();
            t1 = new Thread(MostrarHora);
            t1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void MostrarHora()
        {
            rtbox.Text = DateTime.Now.ToString();
        }
    }
}
