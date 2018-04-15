using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    public class Class1
    {
        public static int OrdenarDecreciente(int a, int b)
        {
            return b.CompareTo(a);
        }

        public static int OrdenarCreciente(int a, int b)
        {
            return a.CompareTo(b);
        }
    }
}
