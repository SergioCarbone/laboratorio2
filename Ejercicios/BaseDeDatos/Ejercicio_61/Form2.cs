using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_61_Libreria;

namespace Ejercicio_61
{
    public partial class Form2 : Form
    {
        Persona p1;
        PersonaDAO dao;
        public Form2(Persona p)
        {
            InitializeComponent();
            p1 = p;
            lblId.Text = p.Id.ToString();
            txtNombre.Text = p.Nombre;
            txtApellido.Text = p.Apellido;
            dao = new PersonaDAO();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            p1.Nombre = txtNombre.Text;
            p1.Apellido = txtApellido.Text;
            dao.ModificarPorId(p1);
        }
    }
}
