using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billete
{
    public class Pesos
    {
        private double cantidad;
        private float cotizRespectoDolar;

        private Pesos()
        {
           
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
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


        public static explicit operator Dolar (Pesos pesos)
        {
            Dolar retorno = new Dolar(0);
            retorno = pesos.cantidad * retorno.GetCotizacion();
            return retorno;
        }

        public static explicit operator Euro(Pesos pesos)
        {
            Euro retorno = new Euro(0);
            retorno = pesos.cantidad * retorno.GetCotizacion();
            return retorno;
        }

        public static implicit operator Pesos (double cantidad)
        {
            Pesos cambioMoneda = new Pesos(cantidad);
            return cambioMoneda;
        }


        public static bool operator != (Pesos peso, Dolar dolar)
        {
            bool retorno = false;
            if(peso != dolar)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator == (Pesos peso, Dolar dolar)
        {
            bool retorno = false;
            if(peso == dolar)
            {
                retorno = true;
            }
            return retorno;
        }

        
        public static bool operator != (Pesos peso, Euro euro)
        {
            bool retorno = false;
            if(peso != euro)
            {
                retorno = true;
            }
            return retorno;
        }
        
        public static bool operator == (Pesos peso, Euro euro)
        {
            bool retorno = false;
            if(peso == euro)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator != (Pesos peso1, Pesos peso2)
        {
            bool retorno = false;
            if(peso1 != peso2)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator == (Pesos peso1, Pesos peso2)
        {
            bool retorno = false;
            if(peso1 == peso2)
            {
                retorno = true;
            }
            return retorno;
        }



        public static Pesos operator - (Pesos peso, Dolar dolar)
        {
            Pesos aux = (Pesos)dolar.GetCantidad();
            Pesos retorno = peso.cantidad - aux.cantidad;
            return retorno;
        }



        public static Pesos operator + (Pesos peso, Dolar dolar)
        {
            Pesos aux = (Pesos)dolar.GetCantidad();
            Pesos retorno = peso.cantidad + aux.cantidad;
            return retorno;
        }



        public static Pesos operator - (Pesos peso, Euro euro)
        {
            Pesos aux = (Pesos)euro.GetCantidad();
            Pesos retorno = peso.cantidad - aux.cantidad;
            return retorno;
        }



        public static Pesos operator + (Pesos peso, Euro euro)
        {
            Pesos aux = (Pesos)euro.GetCantidad();
            Pesos retorno = peso.cantidad + aux.cantidad;
            return retorno;
        }
    }
}

