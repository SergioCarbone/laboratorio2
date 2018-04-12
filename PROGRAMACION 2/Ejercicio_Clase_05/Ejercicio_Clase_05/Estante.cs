using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProducto()
        {
            return this.productos;
        }

        public string MostrarEstante(Estante estante)
        {
            StringBuilder datosEstante = new StringBuilder();
            datosEstante.AppendFormat("Marca {0} \n", this.ubicacionEstante);

            for (int i = 0; i < estante.productos.Length; i++)
            {
                datosEstante.AppendFormat
                    (estante.productos[i].MostrarProducto(estante.productos[i]));
            }
            return datosEstante.ToString();
        }

        public static bool operator == (Estante p1, Producto p2)
        {
            bool retorno = false;
            for (int i = 0; i < p1.productos.Length; i++)
            {
                if (p1.productos[i] == p2)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Estante p1, Producto p2)
        {
            bool retorno = false;
            for (int i = 0; i < p1.productos.Length; i++)
            {
                if (p1.productos[i] != p2)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator +(Estante estante, Producto producto)
        {
            bool retorno = false;
            if (!(estante == producto))
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (object.ReferenceEquals(estante.productos[i] , null))
                    {
                        estante.productos[i] = producto;
                        retorno = true;
                        break;                        
                    }
                }
            }
            return retorno;
        }

        public static Estante operator - (Estante estante, Producto producto)
        {
            Estante retorno = null;
            if (estante == producto)
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (object.ReferenceEquals(estante.productos[i], producto))
                    {
                        estante.productos[i] = null;
                        retorno = estante;
                        break;
                    }
                }
            }
            return retorno;
        }
    }
}
