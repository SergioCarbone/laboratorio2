﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool retorno = false;
            if (c== 'S'||c=='s')
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
