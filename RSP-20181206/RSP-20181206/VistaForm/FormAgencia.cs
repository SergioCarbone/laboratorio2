using System.Windows.Forms;
using Entidades;
using System;
using Archivos;

namespace VistaForm
{
    public partial class FormAgencia : Form
    {
        private Agencia agencia;

        public FormAgencia()
        {
            InitializeComponent();
            agencia = new Agencia("Agencia UTN");
            string[] items = new string[] { "Micro", "Avión" };
            this.cmbTipoPasaje.DataSource = items;
            this.cmbTipoPasaje.SelectedIndex = 0;
            this.nudEscalas.Enabled = false;


            this.txtNombre.Text = "Nombre";
            this.txtApellido.Text = "Apellido";
            this.txtDni.Text = "33444555";
            this.txtOrigen.Text = "Buenos Aires";
            this.txtDestino.Text = "Cordoba";
            cmbTipoServicio.DataSource = Servicio.GetValues(typeof(Servicio));
        }

        private void btnEmitirPasaje_Click(object sender, System.EventArgs e)
        {
            Pasajero pasajero = new Pasajero(txtNombre.Text, txtApellido.Text, txtDni.Text);
            if (cmbTipoPasaje.Text == "Micro")
            {
                Servicio servicio;
                switch(cmbTipoServicio.Text)
                {
                    case "Comun":
                        servicio = Servicio.Comun;
                        break;
                    case "SemiCama":
                        servicio = Servicio.SemiCama;
                        break;
                    case "Ejecutivo":
                        servicio = Servicio.Ejecutivo;
                        break;
                    default:
                        servicio = Servicio.Ejecutivo;
                        break;
                }

                PasajeMicro p = new PasajeMicro(txtOrigen.Text, txtDestino.Text, pasajero, float.Parse(txtPrecio.Text),
                    dtpFechaPartida.Value, servicio);
                agencia.PasajesVendidos.Add(p);
            }
           else
            {                
                PasajeAvion p = new PasajeAvion(txtOrigen.Text, txtDestino.Text, pasajero, float.Parse(txtPrecio.Text),
                    dtpFechaPartida.Value, int.Parse(nudEscalas.ToString()));
                agencia.PasajesVendidos.Add(p);
            }
            
        }

        private void btnMostrar_Click(object sender, System.EventArgs e)
        {
            Xml<Agencia> xml = new Xml<Agencia>();
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "Agencia.xml";
            rtbMostrar.Text = xml.Leer(ruta).ToString();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Xml<Agencia> xml = new Xml<Agencia>();
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "Agencia.xml";
                xml.Guardar(ruta, agencia);
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }

        }

        private void cmbTipoPasaje_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.cmbTipoPasaje.SelectedIndex == 0)
            {
                this.nudEscalas.Enabled = false;
                this.nudEscalas.Value = 0;
                this.cmbTipoServicio.Enabled = true;
            }
            else
            {
                this.nudEscalas.Enabled = true;
                this.cmbTipoServicio.Enabled = false;
            }
        }

        private void FormAgencia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormAgencia_Load(object sender, EventArgs e)
        {
            agencia.Informar += MostrarMensaje;
        }

        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
