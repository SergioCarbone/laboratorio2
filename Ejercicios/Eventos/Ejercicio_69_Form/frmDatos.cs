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
    public partial class frmDatos : Form
    {
        FrmTestDelegados d;
        public frmDatos()
        {
            InitializeComponent();
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            d = new FrmTestDelegados();
            d.EventoNombre += ActualizarNombre;                      
        }

        public void ActualizarNombre(string nombre)
        {
            if (this.lblTexto.InvokeRequired)
            {
                actualizarNombre en = new actualizarNombre(ActualizarNombre);
                this.Invoke(en);
            }
            else
            {
                lblTexto.Text = nombre;
            }            
        }
    }
}
