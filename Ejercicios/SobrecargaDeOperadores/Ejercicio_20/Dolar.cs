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

        public static float GetCotizacion()
        {
            float retorno = Dolar.cotizRespectoDolar;
            return retorno;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }


        //public static explicit operator Euro(Dolar d)
        //{            
        //    Euro retorno = (Euro)(d.cantidad * Euro.GetCotizacion();
        //    return retorno;
        //}

       
    }
}
