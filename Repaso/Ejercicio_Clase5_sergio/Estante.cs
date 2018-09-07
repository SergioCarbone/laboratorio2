using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase5_sergio
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        /// <summary>
        /// retornará el valor asociado del atributo productos
        /// </summary>
        /// <returns></returns>
        public Producto[] GetProducto()
        {
            return this.productos;
        }

        /// <summary>
        /// retornará una cadena con toda la información del estante, incluyendo el detalle de cada uno de sus productos
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string MostrarEstante(Estante e)
        {
            StringBuilder datosEstante = new StringBuilder();

            datosEstante.AppendFormat("Ubicacion: {0}", e.ubicacionEstante);
            datosEstante.AppendLine();
            datosEstante.AppendLine();
            foreach (Producto prod in e.productos) 
            {
                datosEstante.AppendLine();
                datosEstante.Append(Producto.MostrarProducto(prod));
            }
            return datosEstante.ToString();
        }


        /// <summary>
        /// retornará true, si es que el producto ya se encuentra en el estante, false, caso contrario.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            if (!(e is null) && !(p is null))
            {
                foreach (Producto prod in e.productos) 
                {
                    if(prod == p)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// retornará false, si es que el producto ya se encuentra en el estante, true, caso contrario.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Estante e, Producto p)
        {
            return (!(e == p));
        }

        /// <summary>
        /// retornará true y agregará el producto si el estante posee capacidad 
        /// de almacenar al menos un producto más y dicho producto no se encuentra en él; false, caso contrario.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            if(!(e is null) && !(p is null))
            {
                if(!(e == p))
                {
                    for(int i = 0; i < e.productos.Length; i++)
                    {
                        if(e.productos[i] is null)
                        {
                            e.productos[i] = p;
                            retorno = true;
                            break;
                        }
                    }
                }
            }
            return retorno;
        }


        /// <summary>
        /// retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator -(Estante e, Producto p)
        {
            bool retorno = false;
            if (!(e is null) && !(p is null))
            {
                if(e == p)
                {
                    for (int i = 0; i < e.productos.Length; i++)
                    {
                        if (e.productos[i] == p)
                        {
                            e.productos[i] = null;
                            retorno = true;
                            break;
                        }
                    }
                }
            }
            return retorno;
        }
    }
}
