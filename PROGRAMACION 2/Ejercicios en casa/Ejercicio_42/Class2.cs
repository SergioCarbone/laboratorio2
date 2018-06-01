using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class Class2
    {
        public void Operacion()
        {
            try
            {
                new Class1(1);
            }
            catch(UnaException u)
            {
                throw new MiException("sergio", u);
            }
        }
    }
}
