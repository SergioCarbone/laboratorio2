using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_28
{
    public class Class1
    {
        public static int OrdenarDes(KeyValuePair<string,int> a, KeyValuePair<string, int> b)
        {
            return b.Value.CompareTo(a.Value);
        }
    }
}
