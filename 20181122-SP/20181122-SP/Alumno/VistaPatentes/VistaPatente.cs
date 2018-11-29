using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Entidades;

namespace Patentes
{
    public delegate void MostrarPatente(object patente);
    public delegate void FinExposisionPatente(VistaPatente vp);

    public partial class VistaPatente : UserControl
    {
        public event FinExposisionPatente finExposicion;
        public VistaPatente()
        {
            InitializeComponent();

            picPatente.Image = fondosPatente.Images[(int)Patente.Tipo.Mercosur];
        }

        public void MostrarPatente(object patente)
        {
            if (lblPatenteNro.InvokeRequired)
            {
                try
                {
                    Random r = new Random();

                    // Llamar al hilo principal
                    // ALUMNO
                    MostrarPatente m = new MostrarPatente(MostrarPatente);
                    this.Invoke(m);                    
                    Thread.Sleep(r.Next(2000, 5000));


                    // Agregar evento de que finalizó la exposición de la patente
                    // ALUMNO
                    //finExposicion.Invoke(patente);
                }
                catch (Exception) { }
            }
            else
            {
                picPatente.Image = fondosPatente.Images[(int)((Patente)patente).TipoCodigo];
                lblPatenteNro.Text = patente.ToString();
            }
        }

        private void picPatente_Click(object sender, EventArgs e)
        {

        }
    }
}
