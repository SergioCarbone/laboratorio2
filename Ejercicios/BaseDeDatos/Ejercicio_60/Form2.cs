using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_60_Libreria;

namespace Ejercicio_60
{
    public partial class Form2 : Form
    {
        SqlPrueba c;
        Producto p;
        public Form2(Producto p1)
        {
            InitializeComponent();
            c = new SqlPrueba();
            p = p1;
            lblId.Text = p.Id.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            p.Name = txtNombre.Text;
            p.ProductNumber = txtNombreProducto.Text;
            c.Modificar(p);
        }
    }
}
