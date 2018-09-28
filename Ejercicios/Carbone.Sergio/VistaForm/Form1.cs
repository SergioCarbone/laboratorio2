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
        Curso c;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivCurso.SelectedValue.ToString(), out division);

            Profesor profesor = new Profesor(txtNombreCurso.Text, txtApCurso.Text,
                txtDniCurso.Text,dateTimeCurso.Value);

             c = new Curso((short)numAñoAlumno.Value,division,profesor);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionAlumno.SelectedValue.ToString(), out division);

            Alumno a = new Alumno(txtNombreAlumbo.Text, txtApAlumno.Text,
                txtLegajo.Text, (short)numAñoAlumno.Value, division);

            this.c += a;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = (string)c;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionAlumno.DataSource = Enum.GetValues(typeof(Divisiones));
        }
    }
}
