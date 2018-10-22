using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_33_Libreria;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_32";
            Console.ForegroundColor = ConsoleColor.Green;

            Libro a = new Libro();

            a[0] = "Hola";

            Console.WriteLine(a[0]);
            Console.ReadKey();
        }
    }
}
