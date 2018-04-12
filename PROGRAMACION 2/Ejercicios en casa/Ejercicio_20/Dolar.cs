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
            return Dolar.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static explicit operator Euro (Dolar dolar)
        {
            Euro retorno;
            retorno = dolar.cantidad * Euro.GetCotizacion();
            return retorno; 
        }


        public static explicit operator Pesos (Dolar dolar)
        {
            Pesos retorno;
            retorno = dolar.cantidad * Pesos.GetCotizacion();
            return retorno;
        }


        public static implicit operator Dolar(double cantidad)
        {
            Dolar cambioMoneda = new Dolar(cantidad);
            return cambioMoneda;
        }

        public static bool operator !=(Dolar dolar, Euro euro)
        {
            bool retorno = false;
            if (dolar != euro)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            bool retorno = false;
            if (dolar == euro)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(Dolar dolar, Pesos peso)
        {
            bool retorno = false;
            if (dolar != peso)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator ==(Dolar dolar, Pesos peso)
        {
            bool retorno = false;
            if (dolar == peso)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            bool retorno = false;
            if (dolar1 != dolar2)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            bool retorno = false;
            if (dolar1 == dolar2)
            {
                retorno = true;
            }
            return retorno;
        }

        public static Dolar operator - (Dolar dolar, Euro euro)
        {
            Dolar aux = ((Dolar)euro).GetCantidad();
            Dolar retorno = dolar.cantidad - aux.cantidad;            
            return retorno;
        }

        public static Dolar operator + (Dolar dolar, Euro euro)
        {
            Dolar aux = ((Dolar)euro).GetCantidad();
            Dolar retorno = dolar.cantidad + aux.cantidad;
            return retorno;
        }


        public static Dolar operator - (Dolar dolar, Pesos peso)
        {
            Dolar aux = ((Dolar)peso).GetCantidad();
            Dolar retorno = dolar.cantidad - aux.cantidad;
            return retorno;
        }

        public static Dolar operator + (Dolar dolar, Pesos peso)
        {
            Dolar aux = ((Dolar)peso).GetCantidad();
            Dolar retorno = dolar.cantidad + aux.cantidad;
            return retorno;
        }

    }
}
