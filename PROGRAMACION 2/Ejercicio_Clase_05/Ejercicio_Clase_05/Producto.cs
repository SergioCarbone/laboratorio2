using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }


        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        #region Constructores

        public string MostrarProducto (Producto p)
        {
            StringBuilder datosProducto = new StringBuilder();

            datosProducto.AppendFormat("Marca: {0} - ", p.marca);
            datosProducto.AppendFormat("Codigo de barra: {0} - ", p.codigoDeBarra);
            datosProducto.AppendFormat("Precio: {0}", p.precio);
            datosProducto.AppendLine();

            return datosProducto.ToString();
        }
        #endregion

        public static explicit operator string(Producto codBarra)
        {
            return codBarra.codigoDeBarra;
        }

        /*
        public static bool operator == (Producto producto1, Producto producto2)
        {
            bool retorno = false;
            if (producto1.marca == producto2.marca && producto1.codigoDeBarra == producto2.codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }
        

        public static bool operator !=(Producto producto1, Producto producto2)
        {
            bool retorno = false;
            if (producto1.marca != producto2.marca || producto1.codigoDeBarra == producto2.codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }
        */
        public static bool operator ==(Producto producto1, string producto)
        {
            bool retorno = false;
            if (producto1.marca == producto)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto producto1, string producto)
        {
            bool retorno = false;
            if (producto1.marca != producto)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
