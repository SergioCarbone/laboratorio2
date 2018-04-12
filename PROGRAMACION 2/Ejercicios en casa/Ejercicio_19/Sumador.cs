using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSuma;

        public Sumador() : this(0)
        {            
        }

        public Sumador(int valor)
        {
            this.cantidadSuma = valor;
        }

        public static long operator + (Sumador s1, Sumador s2)
        {
            long retorno = s1.cantidadSuma + s2.cantidadSuma;
            return retorno;
        }   

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;
            if (s1.cantidadSuma == s2.cantidadSuma)
            {
                retorno = true;
            }
            return retorno;
        }


        public long Sumar(long valorA, long valorB)
        {
            this.cantidadSuma += 1;
            return valorA + valorB;
        }

        public string Sumar(string palabraA, string palabraB)
        {
            this.cantidadSuma += 1;
            return palabraA + palabraB;
        }
        
        public static explicit operator int (Sumador s)
        {
            
            return s.cantidadSuma;
        }
        

        
    }
}
