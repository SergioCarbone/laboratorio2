using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_68_Libreria;

namespace Ejercicio_68_Form
{
    public partial class Form1 : Form
    {
        private Persona persona;
        private event DelegadoString Evento;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Evento += NotificarCambio;
        }

        private void NotificarCambio(string msg)
        {
            MessageBox.Show(msg);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(persona == null)
            {
                persona = new Persona(txtNombre.Text, txtApellido.Text);
                btnCrear.Text = "Actualizar";
                NotificarCambio("Se ha creado una persona");
            }
            else
            {
                if(persona.Nombre != txtNombre.Text)
                {
                    persona.Nombre = txtNombre.Text;
                    NotificarCambio("Se cambio el nombre de la persona");
                }
                if (persona.Apellido != txtApellido.Text)
                {
                    persona.Apellido = txtApellido.Text;
                    NotificarCambio("Se cambio el apellido de la persona");
                }
                MessageBox.Show( persona.Mostrar());
            }
        }
    }
}
