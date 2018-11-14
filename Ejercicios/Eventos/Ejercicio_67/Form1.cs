using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_67_Libreria;

namespace Ejercicio_67
{
    public partial class Form1 : Form
    {
        Temporizador t = new Temporizador();
        public Form1()
        {
            InitializeComponent();            
        }

        private void T_EventoTiempo()
        {
            if(this.label3.InvokeRequired)
            {
                encargadoTiempo en = new encargadoTiempo(T_EventoTiempo);
                this.Invoke(en);
            }
            else
            {
                label3.Text = DateTime.Now.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Intervalo = 1000;
            t.EventoTiempo += T_EventoTiempo;            
            t.Activo = true;
            label3.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Activo = false;
        }
    }
}
