using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_56_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivoAbrir = new OpenFileDialog();
            StreamReader informacion = null;

            if(archivoAbrir.ShowDialog() == DialogResult.OK)
            {
                string ruta = archivoAbrir.FileName;
                informacion = new StreamReader(ruta);
                richTextBox1.Text = informacion.ReadToEnd();
                informacion.Close();
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog archivoGuardar = new SaveFileDialog();
            StreamWriter informacion = null;
            if(archivoGuardar.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(archivoGuardar.FileName);
                // archivoGuardar.Filter

                string ruta = archivoGuardar.FileName;
                informacion = new StreamWriter(ruta);
                informacion.WriteLine(richTextBox1.Text);
                informacion.Close();
            }

        }
    }
}
