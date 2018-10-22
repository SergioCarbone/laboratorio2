using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {            
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            List<KeyValuePair<string, int>> lista = diccionario.ToList();
            int contador = 1, inicio = 0, flag, fin;
            string palabra = "";
            
            for(int i = 0; i < richTextBox1.Text.Length; i++)
            {
                if(richTextBox1.Text[i] == ' ' || richTextBox1.Text[i] == '\n' || i == richTextBox1.Text.Length-1)
                {
                    fin = i;
                    flag = 0;
                    palabra = richTextBox1.Text.Substring(inicio, fin + 1 - inicio);
                    palabra = palabra.Trim();

                    if (diccionario.ContainsKey(palabra))
                    {
                        diccionario[palabra]++;
                        flag = 1;
                    }
                    if (flag == 0)
                    {
                        diccionario.Add(palabra, contador);
                    }
                    inicio = i + 1;
                }                
            }

            foreach (KeyValuePair<string,int> palab in diccionario)
            {                
                lista.Add(palab);
            }
            lista.Sort(Class1.OrdenarDes);

            int j = 0;
            foreach (KeyValuePair<string,int> palab in lista)
            {
                if (j < 3)
                {
                    MessageBox.Show(palab.Key,palab.Value.ToString());
                }
                j++;
            }
        }
    }
}
