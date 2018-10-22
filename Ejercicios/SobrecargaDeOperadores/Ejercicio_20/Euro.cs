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
            Euro.cotizRespectoDolar = (float)1.16;
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
        /// <param name="e"></param>
        public static explicit operator Dolar(Euro e)
        {           
            Dolar retorno = new Dolar(e.cantidad * GetCotizacion());
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Peso(Euro e)
        {
            Peso retorno = new Peso(e.cantidad * Euro.GetCotizacion() * Peso.GetCotizacion());
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="d"></param>
        public static implicit operator Euro(double d)
        {
            Euro aux = new Euro(d);
            return aux;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="euro1"></param>
        /// <param name="euro2"></param>
        /// <returns></returns>
        public static bool operator ==(Euro euro1, Euro euro2)
        {
            return (euro1.GetCantidad() == euro2.GetCantidad());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="euro1"></param>
        /// <param name="euro2"></param>
        /// <returns></returns>
        public static bool operator !=(Euro euro1, Euro euro2)
        {
            return (!(euro1 == euro2));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Euro e, Peso p)
        {
            bool retorno = false;
            Dolar euroDolar = (Dolar)e;
            Dolar pesoDolar = (Dolar)p;
            if(euroDolar.GetCantidad() == pesoDolar.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Euro e, Peso p)
        {
            return (!(e == p));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator ==(Euro e, Dolar d)
        {
            bool retorno = false;
            Dolar euroDolar = (Dolar)e;
            if(euroDolar.GetCantidad() == d.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator !=(Euro e, Dolar d)
        {
            return (!(e == d));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Euro operator +(Euro e, Peso p)
        {
            Euro aux = (Euro)p;
            return (aux.GetCantidad() + e.GetCantidad());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro aux = (Euro)d;
            return (aux.GetCantidad() + e.GetCantidad());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Euro operator -(Euro e, Peso p)
        {
            Euro aux = (Euro)p;
            return (aux.GetCantidad() - e.GetCantidad());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Euro operator -(Euro e, Dolar d)
        {
            Euro aux = (Euro)d;
            return (aux.GetCantidad() - e.GetCantidad());
        }
    }
}
