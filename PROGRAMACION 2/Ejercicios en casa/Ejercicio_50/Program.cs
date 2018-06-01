using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_50
{
    class Program
    {
        static void Main(string[] args)
        {

            GuardarTexto<string, string> aux = new GuardarTexto<string, string>();

            Console.WriteLine(aux.Leer());

            Double d = -2.345;
            int i = (int)Convert.ChangeType(d, typeof(int));

            Console.WriteLine("The double value {0} when converted to an int becomes {1}", d, i);

            Console.ReadKey();
        }
    }
}
