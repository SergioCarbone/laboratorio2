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
    public partial class GananciaTotal : Form
    {

        Llamada.TipoLlamada llamada;
        

        public Llamada.TipoLlamada tipoLlamada
        {
            set
            {                
               llamada = value;   
            }        
        }
            
        public GananciaTotal()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Centralita central = new Centralita("Personal");                        
            richTextBox1.Text = central.GananciasPorProvincial.ToString();
        }        
    }
}
