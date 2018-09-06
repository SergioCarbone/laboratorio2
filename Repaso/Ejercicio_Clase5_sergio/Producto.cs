using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase5_sergio
{
    public class Producto
    {
        protected string codigoDeBarra, marca;
        protected float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        /// <summary>
        /// retornará el valor correspondiente del atributo marca
        /// </summary>
        /// <returns></returns>
        public string GetMarca()
        {
            return this.marca;
        }

        /// <summary>
        /// retornará el valor correspondiente del atributo precio
        /// </summary>
        /// <returns></returns>
        public float GetPrecio()
        {
            return this.precio;
        }


        /// <summary>
        /// retornará una cadena detallando los atributos de la clase
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string MostrarProducto(Producto p)
        {
            StringBuilder datosProducto = new StringBuilder();

            datosProducto.AppendFormat("Marca: {0}", p.marca);
            datosProducto.AppendLine();
            datosProducto.AppendFormat("Precio: {0}", p.precio);
            datosProducto.AppendLine();
            datosProducto.AppendFormat("Codigo: {0}", p.codigoDeBarra);
            datosProducto.AppendLine();
            return datosProducto.ToString();
        }

        /// <summary>
        /// Conversion explicita del codigo de barras a string
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Producto p)
        {
            return Convert.ToString(p.codigoDeBarra);
        }

        /// <summary>
        /// Retornará true, si las marcas y códigos de barras son iguales, false, caso contrario
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if(!(p1 is null) && !(p2 is null))
            {
                if((p1.marca == p2.marca) && (p1.codigoDeBarra == p2.codigoDeBarra))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Retornará false, si las marcas y códigos de barras son iguales, true, caso contrario
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return (!(p1 == p2));
        }


        /// <summary>
        /// Retornará true, si la marca del producto coincide con la cadena pasada por parámetro, false, caso contrario.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;
            if(!(p is null))
            {
                if(p.marca == marca)
                {
                    retorno = true;
                }
            }
            return retorno;
        }


        /// <summary>
        /// Retornará false, si la marca del producto coincide con la cadena pasada por parámetro, true, caso contrario.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p, string marca)
        {
            return (!(p == marca));
        }


    }
}
