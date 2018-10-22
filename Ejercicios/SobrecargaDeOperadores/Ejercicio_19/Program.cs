using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_19";
            Console.ForegroundColor = ConsoleColor.Green;

            Sumador prueba = new Sumador();
            Sumador prueba2 = new Sumador();

            Console.WriteLine(prueba.Sumar("sergio ","carbone"));
            Console.WriteLine(prueba.Sumar(100, 100));
            Console.WriteLine(prueba2.Sumar(50, 150));

            Console.Write("Los sumadores son iguales? {0}", prueba | prueba2);

            Console.ReadKey();
        }
    }
}
