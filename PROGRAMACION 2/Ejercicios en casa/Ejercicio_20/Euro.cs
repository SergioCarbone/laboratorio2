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
        private float cotizRespectoDolar;

        private Euro()
        {
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }

        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }


        public static explicit operator Dolar (Euro euro)
        {
            Dolar retorno = new Dolar(0);
            retorno = euro.cantidad * retorno.GetCotizacion();
            return retorno;
        }

        public static explicit operator Pesos(Euro euro)
        {
            Pesos retorno = new Pesos(0);
            retorno = euro.cantidad * retorno.GetCotizacion();
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
            Euro aux = (Euro)dolar.GetCantidad();
            Euro retorno = euro.cantidad - aux.cantidad;
            return retorno;
        }


        public static Euro operator +(Euro euro, Dolar dolar)
        {
            Euro aux = (Euro)dolar.GetCantidad();
            Euro retorno = euro.cantidad + aux.cantidad;
            return retorno;
        }


        public static Euro operator - (Euro euro, Pesos peso)
        {
            Euro aux = (Euro)peso.GetCantidad();
            Euro retorno = euro.cantidad - aux.cantidad;
            return retorno;
        }


        public static Euro operator + (Euro euro, Pesos peso)
        {
            Euro aux = (Euro)peso.GetCantidad();
            Euro retorno = euro.cantidad + aux.cantidad;
            return retorno;
        }
    }
}
