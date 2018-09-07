using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro()
        {

        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static float GetCotizacion()
        {
            return Euro.cotizRespectoDolar;            
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Dolar(Euro e)
        {           
            Dolar retorno = new Dolar(e.cantidad * Euro.GetCotizacion());
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Peso(Euro e)
        {
            Peso retorno = new Peso(e.cantidad * Euro.GetCotizacion());
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Euro(double d)
        {
            return (d * Euro.GetCotizacion());
        }
    }
}
