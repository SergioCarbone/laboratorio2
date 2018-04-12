using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";
            int numero;
            string asterisco = "*";

            Console.Write("Ingrese la cantidad de pisos: ");
            if(int.TryParse(Console.ReadLine(),out numero))
            {
                for (int i = 0; i < numero * 2; i = i + 2)
                {
                    Console.WriteLine(asterisco);
                    asterisco += "**";
                }
            }

            Console.ReadKey();
        }
    }
}
