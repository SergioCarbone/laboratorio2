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
    public partial class Form3 : Form
    {
        SqlPrueba c;
        
        public Form3()
        {
            InitializeComponent();
            c = new SqlPrueba();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.Name = txtNombre.Text;
            p.ProductNumber = txtNombreProducto.Text;
            c.Insertar(p);
        }
    }
}
