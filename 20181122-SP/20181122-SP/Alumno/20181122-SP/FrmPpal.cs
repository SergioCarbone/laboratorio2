using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        List<Thread> listaHilos;
        Queue<Patente> cola;
        Thread hilo; 
        public FrmPpal()
        {
            InitializeComponent();
            this.listaHilos = new List<Thread>();
            this.cola = new Queue<Patente>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.finExposicion += ProximaPatente;
            vistaPatente2.finExposicion += ProximaPatente;
        }


        private void ProximaPatente(Patentes.VistaPatente vp)
        {
            hilo = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
            hilo.Start();
            listaHilos.Add(hilo);
        }


        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarSimulacion();
        }
        

        private void btnXml_Click(object sender, EventArgs e)
        {
            Xml<string> xml = new Xml<string>();
            //xml.Leer();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto<string> texto = new Texto<string>();            
            //texto.Leer(int.TryParse("patentes", out cola));
            
            
        }

        private void btnSql_Click(object sender, EventArgs e)
        {

        }

        private void FinalizarSimulacion()
        {
            foreach (Thread aux in listaHilos)
            {
                if(aux.IsAlive == true)
                {
                    aux.Abort();
                }
            }
        }
    }
}
