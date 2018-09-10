using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Peso
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Peso()
        {
            Peso.cotizRespectoDolar = (float)17.55;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, float cotizacion) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Peso.cotizRespectoDolar;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator Dolar(Peso p)
        {
            Dolar retorno = new Dolar(p.cantidad * Peso.cotizRespectoDolar);
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator Euro(Peso p)
        {
            Euro retorno = new Euro(p.cantidad * Peso.cotizRespectoDolar);
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static implicit operator Peso(double p)
        {
            return (p * Peso.cotizRespectoDolar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator ==(Peso p, Dolar d)
        {
            bool retorno = false;
            Dolar dolar = (Dolar)p;
            if (dolar.GetCantidad() == d.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator !=(Peso p, Dolar d)
        {
            return (!(p == d));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator ==(Peso p, Euro e)
        {
            bool retorno = false;
            Dolar pesoDolar = (Dolar)p;
            Dolar euroDolar = (Dolar)e;
            if (pesoDolar.GetCantidad() == euroDolar.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator !=(Peso p, Euro e)
        {
            return (!(p == e));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Peso p1, Peso p2)
        {
            return (p1.GetCantidad() == p2.GetCantidad());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Peso p1, Peso p2)
        {
            return (!(p1 == p2));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Peso operator +(Peso p, Dolar d)
        {
            Peso aux = (Peso)d;
            return (aux.GetCantidad() + p.cantidad);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Peso operator +(Peso p, Euro e)
        {
            Peso aux = (Peso)e;
            return (aux.GetCantidad() * p.cantidad);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Peso operator -(Peso p, Dolar d)
        {
            Peso aux = (Peso)d;
            return (aux.GetCantidad() - p.cantidad);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Peso operator -(Peso p, Euro e)
        {
            Peso aux = (Peso)e;
            return (aux.GetCantidad() - p.cantidad);
        }
    }
}
