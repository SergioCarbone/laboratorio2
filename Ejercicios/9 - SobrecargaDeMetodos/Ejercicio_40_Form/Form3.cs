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
    public partial class Form3 : Form
    {
        public Llamada.TipoLlamada dato;
        private Centralita aux;

        public Form3(Centralita c)
        {            
            InitializeComponent();
            aux = c;
        }

        public Llamada.TipoLlamada CalcularGanancia
        {
            set
            {
                switch (value)
                {
                    case Llamada.TipoLlamada.Local:
                        this.richTextBox1.Text = "Total Ganancias locales: " + aux.GananciasPorLocal.ToString();
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        this.richTextBox1.Text = "Total Ganancias provinciales: " + aux.GananciasPorProvincial.ToString();
                        break;
                    case Llamada.TipoLlamada.Todas:
                        this.richTextBox1.Text = "Total Ganancias Llamadas: " + aux.GananciasPorTotal.ToString();
                        break;
                }
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
