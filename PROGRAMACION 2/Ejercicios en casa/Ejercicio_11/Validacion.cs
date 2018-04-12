using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool validar(int numero, int max, int min)
        {
            bool retorno = false;
            if(numero <= max && numero >= min)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
