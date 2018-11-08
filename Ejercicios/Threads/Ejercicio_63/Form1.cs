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
            t1 = new Thread(new ParameterizedThreadStart(MostrarHora));
            t1.IsBackground = true;
            t1.Start(DateTime.Now.ToLocalTime());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }        


        private void MostrarHora(object o)
        {
            while(true)
            {
                o = DateTime.Now.ToLocalTime();
                if (this.label1.InvokeRequired)
                {
                    this.label1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.label1.Text = o.ToString();
                    }
                    );
                }
                else
                {
                    this.label1.Text = o.ToString();
                }
                Thread.Sleep(1000);
            }
        }

    }
}
