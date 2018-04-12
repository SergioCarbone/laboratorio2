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

        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static explicit operator Dolar (Euro euro)
        {
            Dolar retorno;
            retorno = euro.cantidad / Dolar.GetCotizacion();
            return retorno;
        }

        public static explicit operator Pesos(Euro euro)
        {
            Pesos retorno;
            retorno = euro.cantidad * Pesos.GetCotizacion();
            return retorno;
        }


        public static implicit operator Euro (double cantidad)
        {
            Euro cambioMoneda = new Euro (cantidad);
            return cambioMoneda;
        }


        public static bool operator != (Euro euro, Pesos peso)
        {
            bool retorno = false;
            if (euro != peso)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator ==(Euro euro, Pesos peso)
        {
            bool retorno = false;
            if (euro == peso)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(Euro euro, Dolar dolar)
        {
            bool retorno = false;
            if (euro != dolar)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator ==(Euro euro, Dolar dolar)
        {
            bool retorno = false;
            if (euro == dolar)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(Euro euro1, Euro euro2)
        {
            bool retorno = false;
            if (euro1 != euro2)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator ==(Euro euro1, Euro euro2)
        {
            bool retorno = false;
            if (euro1 != euro2)
            {
                retorno = true;
            }
            return retorno;
        }


        public static Euro operator - (Euro euro, Dolar dolar)
        {
            Euro aux = ((Euro)dolar).GetCantidad();
            Euro retorno = euro.cantidad - aux.cantidad;
            return retorno;
        }


        public static Euro operator +(Euro euro, Dolar dolar)
        {
            Euro aux = ((Euro)dolar).GetCantidad();
            Euro retorno = euro.cantidad + aux.cantidad;
            return retorno;
        }


        public static Euro operator - (Euro euro, Pesos peso)
        {
            Euro aux = ((Euro)peso).GetCantidad();
            Euro retorno = euro.cantidad - aux.cantidad;
            return retorno;
        }


        public static Euro operator + (Euro euro, Pesos peso)
        {
            Euro aux = ((Euro)peso).GetCantidad();
            Euro retorno = euro.cantidad + aux.cantidad;
            return retorno;
        }
    }
}
