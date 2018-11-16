using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_72
{
    public static class Extension
    {
        public static int CantidadDeDigitos(this long numero, string a)
        {
            return a.Length;
        }
    }
}
