using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Ejercicio_58_Libreria;

namespace Ejercicio_58_Form
{
    public partial class Form1 : Form
    {
        OpenFileDialog abrirArchivo;
        SaveFileDialog guardarArchivo;
        PuntoDat dat;
        PuntoTxt txt;
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirArchivo = new OpenFileDialog();
            abrirArchivo.Filter = "txt files(*.txt)|*.txt|dat files(*.dat)|*.dat";
            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                string ruta = abrirArchivo.FileName;
                if (Path.GetExtension(ruta) == ".txt")
                {
                    txt = new PuntoTxt();
                    richTextBox1.Text = txt.Leer(ruta);
                }
                else
                {
                    dat = new PuntoDat();
                    dat = dat.Leer(ruta);
                    richTextBox1.Text = dat.Contenido;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                guardarArchivo = new SaveFileDialog();
                guardarArchivo.Filter = "txt files(*.txt)|*.txt|dat files(*.dat)|*.dat";
                if (guardarArchivo.ShowDialog() == DialogResult.OK)
                {
                    string ruta = guardarArchivo.FileName;
                    if (Path.GetExtension(ruta) == ".txt")
                    {
                        txt = new PuntoTxt();
                        txt.Guardar(ruta, richTextBox1.Text);
                    }
                    else
                    {
                        dat = new PuntoDat();
                        dat.Contenido = richTextBox1.Text;
                        dat.GuardarComo(ruta, dat);
                    }
                }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "txt files(*.txt)|*.txt|dat files(*.dat)|*.dat";
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                string ruta = guardarArchivo.FileName;
                if (Path.GetExtension(ruta) == ".txt")
                {
                    txt = new PuntoTxt();
                    txt.GuardarComo(ruta, richTextBox1.Text);
                }
                else
                {
                    dat = new PuntoDat();
                    dat.Contenido = richTextBox1.Text;
                    dat.GuardarComo(ruta, dat);
                }
            }
        }
    }
}
