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
    public delegate void actualizarNombre(string nombre);
    public partial class FrmTestDelegados : Form
    {
        public event actualizarNombre EventoNombre;
        frmDatos d;
        public FrmTestDelegados()
        {
            InitializeComponent();
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
            d = new frmDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {            
            d.ActualizarNombre(txtDelegados.Text);
            //d.Show();
        }
    }
}
