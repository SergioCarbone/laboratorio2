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
    public partial class Form2 : Form
    {
        SaveFileDialog archivoGuardar;
        OpenFileDialog archivoAbrir;
        PuntaDat dat;
        PuntoTxt txt;
        public Form2()
        {
            InitializeComponent();
        }

        private void archivoTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoAbrir = new OpenFileDialog();
            archivoAbrir.Filter = "dat files(*.dat)|*.dat";
            
            if (archivoAbrir.ShowDialog() == DialogResult.OK)
            {
                string ruta = archivoAbrir.FileName;
                
                dat = new PuntaDat();
                dat.Leer(ruta);
                richTextBox1.Text = dato.ReadToEnd()    ;
                dato.Close();
            }
        }

        private void archivoTxtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            archivoAbrir = new OpenFileDialog();
            archivoAbrir.Filter = "txt files(*.txt)|*.txt|dat files(*.dat)|*.dat";
            StreamWriter dato = null;
            if (archivoGuardar.ShowDialog() == DialogResult.OK)
            {
                string ruta = archivoAbrir.FileName;
                dato = new StreamWriter(ruta);

                dato.WriteLine(richTextBox1.Text);
                dato.Close();
            }
        }

        private void archivoDatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            archivoGuardar = new SaveFileDialog();
            archivoGuardar.Filter = "txt files(*.txt)|*.txt|dat files(*.dat)|*.dat";
            StreamWriter dato = null;
            if (archivoGuardar.ShowDialog() == DialogResult.OK)
            {
                string ruta = archivoGuardar.FileName;
                dato = new StreamWriter(ruta);

                dato.WriteLine(richTextBox1.Text);
                dato.Close();
            }
        }

        private void archivoDatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoGuardar = new SaveFileDialog();
            archivoGuardar.Filter = "txt files(*.txt)|*.txt|dat files(*.dat)|*.dat";
            StreamWriter dato = null;
            if (archivoGuardar.ShowDialog() == DialogResult.OK)
            {
                string ruta = archivoGuardar.FileName;
                dato = new StreamWriter(ruta);

                dato.WriteLine(richTextBox1.Text);
                dato.Close();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivoGuardar = new SaveFileDialog();
            archivoGuardar.Filter = "txt files(*.txt)|*.txt|dat files(*.dat)|*.dat";            
           
            if (archivoGuardar.ShowDialog() == DialogResult.OK)
            {
                string ruta = archivoGuardar.FileName;
                if(Path.GetExtension(ruta) == "txt")
                {
                    txt = new PuntoTxt();
                    txt.Contenido = richTextBox1.Text;
                    txt.Guardar(ruta);
                }
                else
                {
                    dat = new PuntaDat();
                    dat.Contenido = richTextBox1.Text;
                    dat.Guardar(ruta);
                }
            }
        }
    }
}
