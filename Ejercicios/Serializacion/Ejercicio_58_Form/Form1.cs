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
using Ejercicio_58_Libreria;

namespace Ejercicio_58_Form
{
    public partial class Form1 : Form
    {
        SaveFileDialog archivoGuardar;
        OpenFileDialog archivoAbrir;
        PuntaDat auxDat;
        PuntoTxt auxTxt;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoAbrir = new OpenFileDialog();
            StreamReader informacion = null;
            
            if (archivoAbrir.ShowDialog() == DialogResult.OK)
            {                
                string ruta = archivoAbrir.FileName;
                informacion = new StreamReader(ruta);
                archivoAbrir.Filter = "txt files(*.txt)|*.txt|dat files(*.dat)|*.dat";
                richTextBox1.Text = informacion.ReadToEnd();                
                informacion.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoGuardar = new SaveFileDialog();            
            if (archivoGuardar.ShowDialog() == DialogResult.OK)
            {                
                string ruta = archivoGuardar.FileName;
                archivoGuardar.Filter = "txt files(*.txt)|*.txt|dat files(*.dat)|*.dat";
                
            }
        }

        private void archivoTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            auxTxt = new PuntoTxt();
            archivoGuardar = new SaveFileDialog();
            archivoGuardar.Filter = "txt files(*.txt)|*.txt|dat files(*.dat)|*.dat";
            if (archivoGuardar.ShowDialog() == DialogResult.OK)
            {
                string a = archivoGuardar.Filter;
                auxTxt.Guardar(archivoGuardar.FileName, richTextBox1.Text);
            }
        }
    }
}
