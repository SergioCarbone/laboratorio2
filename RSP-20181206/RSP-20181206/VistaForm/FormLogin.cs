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


namespace VistaForm
{
    public partial class FormLogin : Form
    {
        Usuario usuario;
        public FormLogin()
        {
            InitializeComponent();
            txtClave.UseSystemPasswordChar = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //ALUMNO
            UsuarioDao dao = new UsuarioDao();

            try
            {
                if (dao.Leer(txtUsuario.Text, txtClave.Text) == null)
                {
                    MessageBox.Show("Usuario o clave incorrectos");
                }
                else
                {
                    FormAgencia a = new FormAgencia();
                    a.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar recuperar el usuario");
            }


            if (usuario != null)
            {
                this.Hide();
                FormAgencia f2 = new FormAgencia();
                f2.ShowDialog();
            }

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            //ALUMNO
            UsuarioDao dao = new UsuarioDao();
            try
            {
                Usuario aux = new Usuario(txtUsuario.Text, txtClave.Text);
                dao.Guardar(aux);
                if(aux != null)
                {
                    MessageBox.Show("Usuario registrado");
                }
            }
            catch(ClaveInvalidaException w)
            {
                MessageBox.Show(w.Message);
            }
            catch(Exception)
            {
                MessageBox.Show("Error al registrar el usuario");
            }


            //limpio los controles después del registro
            this.txtUsuario.Clear();
            this.txtClave.Clear();
            usuario = null;

        }
    }
}
