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
                Euro euro = new Euro(aux);
                Peso peso = new Peso(aux);
                Dolar dolar = new Dolar(aux);
                textEuroAEuro.Text = aux.ToString();

                Dolar auxD = (Dolar)euro;
                textEuroADolar.Text = string.Format("{0:n2}", Math.Truncate(auxD.GetCantidad() * 100) / 100);

                Peso auxP = (Peso)euro;
                textEuroAPeso.Text = string.Format("{0:n2}", Math.Truncate(auxP.GetCantidad() * 100) / 100);
                
            }
        }

       
        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            int aux;
            if (int.TryParse(textDolar.Text, out aux))
            {
                Dolar dolar = new Dolar(aux);
                Peso peso = new Peso(aux);
                Euro euro= new Euro(aux);
                textDolarADolar.Text = aux.ToString();

                Peso auxP = (Peso)dolar;
                textDolarAPeso.Text = string.Format("{0:n2}", Math.Truncate(auxP.GetCantidad() * 100) / 100);

                Euro auxE = (Euro)dolar;
                textDolarAEuro.Text = string.Format("{0:n2}", Math.Truncate(auxE.GetCantidad() * 100) / 100);
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            int aux;
            if (int.TryParse(textPeso.Text, out aux))
            {
                Peso peso = new Peso(aux);
                Dolar dolar = new Dolar(aux);
                Euro euro = new Euro(aux);
                textPesoAPeso.Text = aux.ToString();

                Dolar auxD = (Dolar)peso;
                textPesoADolar.Text = string.Format("{0:n2}", Math.Truncate(auxD.GetCantidad() * 100) / 100);

                Euro auxE = (Euro)peso;
                textPesoAEuro.Text = string.Format("{0:n2}", Math.Truncate(auxE.GetCantidad() * 100) / 100);
            }
        }
    }
}
