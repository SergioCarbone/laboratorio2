using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52_ClassLibrary1
{
    public class Cartuchera1
    {
        List<IAcciones> cart1;

        public bool ProbarElementos()
        {
            int flag = 0;
            foreach (IAcciones item in this.cart1)
            {                
                item.Escribir("1234567891");
            }
            return true;
        }
    }
}
