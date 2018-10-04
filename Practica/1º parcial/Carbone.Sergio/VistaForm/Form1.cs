using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        private DirectorTecnico dt;

        public Form1()
        {
            InitializeComponent();            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, (int)numericUpDownEdad.Value, (int)numericUpDownDni.Value, (int)numericUpDownExperiencia.Value);
            MessageBox.Show("Se ha creado el DT!");
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(dt == null)
            {
                MessageBox.Show("Aún no se ha creado el DT del formulario");
            }
            else if(dt.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto");
            }
            else if(!(dt.ValidarAptitud()))
            {
                MessageBox.Show("El DT no es apto");
            }

        }
    }
}
