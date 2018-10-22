using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class Class3
    {
        public static void MiClase3()
        {
            try
            {
                Class2 a = new Class2();
            }
            catch(UnaExcepcion a)
            {
                throw new MiException("Error, clase3", a);
            }
        }

    }
}
