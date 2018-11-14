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
    public partial class Form1 : Form
    {
        PersonaDAO dao;
        Persona p1;
        public Form1()
        {
            InitializeComponent();
            dao = new PersonaDAO();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            dao.Leer();
            foreach (Persona p in dao.lista)
            {
                listBox1.Items.Add(p);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {            
            p1 = (Persona)listBox1.SelectedItem;
            Form2 modificar = new Form2(p1);
            modificar.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            p1 = new Persona(txtNombre.Text, txtApellido.Text);
            dao.Guardar(p1);            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {            
            p1 = (Persona)listBox1.SelectedItem;
            dao.Borrar(p1.Id);
        }
    }
}
