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

        public static float GetCotizacion()
        {
            return Euro.cotizRespectoDolar;            
        }

        //public static explicit operator Dolar(Euro e)
        //{
        //    Dolar retorno = (Dolar)(e.cantidad * Dolar.GetCotizacion());
        //    return retorno;
        //}

        
    }
}
