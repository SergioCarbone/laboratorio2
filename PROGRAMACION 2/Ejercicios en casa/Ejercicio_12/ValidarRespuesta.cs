using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public class ValidarRespuesta
    {
        public static bool Validar_N(char c)
        {
            bool retorno;
            if(c == 's')
            {
                retorno = true; 
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }   
    }
}
