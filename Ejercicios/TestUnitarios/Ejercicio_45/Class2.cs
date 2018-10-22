using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_45
{
    public class Class2
    {
        public Class2()
        {
            try
            {
                Class1 clase1 = new Class1();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("Error clase2", e);
            }
        }

    }
}
