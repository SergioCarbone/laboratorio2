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
    public partial class FrmMenu : Form
    {
        Centralita centralita;        

        public FrmMenu()
        {
            InitializeComponent();
            centralita = new Centralita();
        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

      

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            Form2 llamador = new Form2(centralita);            
            llamador.ShowDialog();
            //this.Hide();

        }

        private void btnFactTotal_Click(object sender, EventArgs e)
        {
            Form3 facturacionTotal = new Form3(centralita);
            facturacionTotal.CalcularGanancia = Llamada.TipoLlamada.Todas;
            facturacionTotal.ShowDialog();
            //this.Hide();
        }

        private void FrmMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void btnFactLocal_Click(object sender, EventArgs e)
        {
            Form3 facturacionTotal = new Form3(centralita);
            facturacionTotal.CalcularGanancia = Llamada.TipoLlamada.Local;
            facturacionTotal.ShowDialog();
            //this.Hide();
        }

        private void btnFacProvincial_Click(object sender, EventArgs e)
        {
            Form3 facturacionTotal = new Form3(centralita);
            facturacionTotal.CalcularGanancia = Llamada.TipoLlamada.Provincial;
            facturacionTotal.ShowDialog();
            //this.Hide();
        }
    }
}
