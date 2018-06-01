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
    public partial class Form1 : Form
    {
        Centralita central;

        public Centralita cent
        {
            set
            {
                central = new Centralita("hola");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GananciaTotal gananciaTotal = new GananciaTotal();
            gananciaTotal.tipoLlamada = Llamada.TipoLlamada.Todas;
            
            gananciaTotal.ShowDialog();
            
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {

        }
    }
}
