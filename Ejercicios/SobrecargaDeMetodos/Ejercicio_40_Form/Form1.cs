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
        Centralita centralita = new Centralita();        

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            Form2 llamador = new Form2(centralita);            
            llamador.ShowDialog();
            this.Hide();

        }
    }
}
