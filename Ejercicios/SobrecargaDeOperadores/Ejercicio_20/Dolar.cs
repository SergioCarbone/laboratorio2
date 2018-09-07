using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar()
        {
            
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static float GetCotizacion()
        {
            float retorno = Dolar.cotizRespectoDolar;
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static explicit operator Euro(Dolar d)
        {
            Euro retorno = new Euro(d.cantidad * Dolar.GetCotizacion());
            return retorno;
        }


        public static explicit operator Peso(Dolar d)
        {
            Peso retorno = new Peso(d.cantidad * Dolar.GetCotizacion());
            return retorno;
        }


    }
}
