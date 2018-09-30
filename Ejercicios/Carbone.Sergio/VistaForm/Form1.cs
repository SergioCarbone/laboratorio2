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
        Curso curso;
        public Form1()
        {
            InitializeComponent();
        }

        private void BntCrear_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisonCurso.SelectedValue.ToString(), out division);

            Profesor profe = new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDniProfe.Text,dtpFechaIngreso.Value);
            curso = new Curso((short)nudAnioCurso.Value, division, profe);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisonCurso.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out division);
            short anio = (short)nudAnio.Value;
            Alumno alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtLegajo.Text, anio, division);

            curso += alumno;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (string)curso;
        }
    }
}
