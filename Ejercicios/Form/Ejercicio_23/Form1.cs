using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ejercicio_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            int aux;
            if(int.TryParse(textEuro.Text, out aux))
            {
                Euro euro = new Euro(aux, 0.809f);
                textEuroAEuro.Text()
            }
        }
    }
}
