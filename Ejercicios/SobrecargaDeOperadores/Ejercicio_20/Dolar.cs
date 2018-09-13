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
            Dolar.cotizRespectoDolar = 1;
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Euro(Dolar d)
        {
            Euro retorno = new Euro(d.cantidad / GetCotizacion());
            return retorno;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Peso(Dolar d)
        {
            Peso retorno = new Peso(d.cantidad / GetCotizacion());
            return retorno;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Dolar(double d)
        {
            Dolar aux = new Dolar(d);
            return aux;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dolar1"></param>
        /// <param name="dolar2"></param>
        /// <returns></returns>
        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            return (dolar1.GetCantidad() == dolar2.GetCantidad());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dolar1"></param>
        /// <param name="dolar2"></param>
        /// <returns></returns>
        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            return (!(dolar1 == dolar2));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Dolar d, Peso p)
        {
            bool retorno = false;
            Dolar aux = (Dolar)p;
            if(d.GetCantidad() == aux.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Dolar d, Peso p)
        {
            return (!(d == p));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator ==(Dolar d, Euro e)
        {
            bool retorno = false;
            Dolar aux = (Dolar)e;
            if(d.GetCantidad() == aux.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator !=(Dolar d, Euro e)
        {
            return (!(d == e));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar aux = (Dolar)p;
            return (d.GetCantidad() + aux.GetCantidad());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar aux = (Dolar)e;
            return (d.GetCantidad() + aux.GetCantidad());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar aux = (Dolar)p;
            return (d.GetCantidad() - aux.GetCantidad());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar aux = (Dolar)e;
            return (d.GetCantidad() - aux.GetCantidad());
        }
    }
}
