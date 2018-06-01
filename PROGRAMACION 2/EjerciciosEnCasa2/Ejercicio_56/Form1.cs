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

namespace Ejercicio_56
{
    public partial class Form1 : Form
    {
        private string pad = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = richTextBox1.Text.Length.ToString() + " caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            openFileDialog1.ShowDialog();
            this.pad = openFileDialog1.FileName;

            try
            {
                //Genero el stream
                FileStream Fs = new FileStream(this.pad, FileMode.Open, FileAccess.ReadWrite);
                StreamReader Sr = new StreamReader(Fs);
                //Leo todo el archivo
                string Arch = Sr.ReadToEnd();
                //Cierro el archivo
                Sr.Close();
                Fs.Close();

                richTextBox1.Text = Arch;
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message, "Error en la ruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException fex)
            {
                MessageBox.Show(fex.Message, "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            this.pad = saveFileDialog1.FileName + ".txt";

            FileStream Fs = new FileStream(this.pad, FileMode.Create, FileAccess.Write);

            using (StreamWriter sw = new StreamWriter(Fs))
            {
                sw.Write(richTextBox1.Text);
                sw.Close();
                Fs.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            FileStream Fs = new FileStream(this.pad, FileMode.Create, FileAccess.Write);
                
                using (StreamWriter sw = new StreamWriter(Fs))
                {
                    sw.Write(richTextBox1.Text);
                    sw.Close();
                    Fs.Close();
                }
           
        }
    }
}
