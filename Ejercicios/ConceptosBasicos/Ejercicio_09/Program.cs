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
            Console.Title = "Ejercicio_09";
            Console.ForegroundColor = ConsoleColor.Green;

            int pisos;
            string asterisco = "*";
            Console.Write("Ingrese la cantidad de pisos: ");
            if((int.TryParse(Console.ReadLine(), out pisos) && pisos > 0))
            {
                for (int i = 0; i < pisos; i++) 
                {
                    Console.WriteLine(asterisco);
                    asterisco += "**";
                }
            }
            Console.ReadKey();
        }
    }
}
