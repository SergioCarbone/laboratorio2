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
        Queue<Patente> cola;
        List<Thread> listaThread;
        Thread hilo;

        public FrmPpal()
        {
            InitializeComponent();
            this.listaThread = new List<Thread>();
            this.cola = new Queue<Patente>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.FinExposicion += ProximaPatente;
            vistaPatente2.FinExposicion += ProximaPatente;
        }

        private void ProximaPatente(Patentes.VistaPatente vp)
        {
            hilo = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
            hilo.Start(this.cola.Dequeue());
            listaThread.Add(hilo);
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                List<Patente> lista;
                Xml<List<Patente>> xml = new Xml<List<Patente>>();
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "patentes.xml";
                xml.Leer(ruta, out lista);
                this.cola = new Queue<Patente>(lista.AsEnumerable().Reverse());
            }
            catch(Exception w)
            {
                MessageBox.Show(w.Message);
            }
            IniciarSimulacion();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Texto texto = new Texto();
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "patentes.txt";
                texto.Leer(ruta, out cola);
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
            IniciarSimulacion();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            sql.Leer("Patentes", out cola);
            IniciarSimulacion();            
        }


        private void FinalizarSimulacion()
        {
            foreach (Thread t in this.listaThread)
            {
                if (t.IsAlive)
                {
                    t.Abort();
                }
            }
        }

        private void IniciarSimulacion()
        {
            FinalizarSimulacion();
            ProximaPatente(vistaPatente1);
            ProximaPatente(vistaPatente2);
        }
    }
}
