using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    public class AnioBisiesto
    {
        public static bool BuscarAnioBisiesto(int numero)
        {
            bool bisiesto;
            if ((numero % 4) == 0)
            {
                if ((numero % 100) == 0 && (numero % 400) == 0)
                {
                    bisiesto = true;
                }
                else if ((numero % 4) == 0 && (numero % 100) != 0)
                {
                    bisiesto = true;
                }
                else
                {
                    bisiesto = false;
                }
            }
            else
            {
                bisiesto = false;
            }
            return bisiesto;
        }
    }
}
