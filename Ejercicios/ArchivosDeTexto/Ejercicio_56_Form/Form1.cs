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
        SaveFileDialog archivoGuardar;
        OpenFileDialog archivoAbrir;
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = "";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            archivoAbrir = new OpenFileDialog();
            StreamReader informacion = null;

            if(archivoAbrir.ShowDialog() == DialogResult.OK)
            {
                string ruta = archivoAbrir.FileName;
                informacion = new StreamReader(ruta);
                archivoAbrir.Filter = "txt files(*.txt)|*.txt";
                richTextBox1.Text = informacion.ReadToEnd();
                toolStripStatusLabel2.Text = richTextBox1.TextLength + " caracteres";
                informacion.Close();
                
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ruta = archivoAbrir.FileName;
            StreamWriter dato = new StreamWriter(ruta + ".txt");
            dato.WriteLine(richTextBox1.Text);
            toolStripStatusLabel2.Text = richTextBox1.TextLength.ToString() + " caracteres";
            dato.Close();            
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardarComo_Click(object sender, EventArgs e)
        {
            archivoGuardar = new SaveFileDialog();
            StreamWriter informacion = null;
            if (archivoGuardar.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(archivoGuardar.FileName);
                // archivoGuardar.Filter
                string ruta = archivoGuardar.FileName;
                informacion = new StreamWriter(ruta + ".txt");
                informacion.WriteLine(richTextBox1.Text);
                informacion.Close();
            }
        }
    }
}
