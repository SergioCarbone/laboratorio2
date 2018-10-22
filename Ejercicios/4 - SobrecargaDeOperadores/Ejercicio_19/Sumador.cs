using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador() : this(0)
        {

        }

        public Sumador(int cantidadSumas) 
        {
            this.cantidadSumas = cantidadSumas;
        }

        /// <summary>
        /// Suma dos numeros
        /// </summary>
        /// <param name="a">Numero pasado por parametro</param>
        /// <param name="b">Numero pasado por parametro</param>
        /// <returns>Retorna el total de la suma</returns>
        public long Sumar(long a, long b)
        {
            cantidadSumas += 1;
            return (a + b);
        }

        /// <summary>
        /// Concatena dos string
        /// </summary>
        /// <param name="a">Primer palabra</param>
        /// <param name="b">Segunda palabra</param>
        /// <returns>Retorna las palabras concatenadas</returns>
        public string Sumar(string a, string b)
        {
            cantidadSumas += 1;
            return (a + b);
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;
            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }


    }
}
