using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_18";
            Console.ForegroundColor = ConsoleColor.Green;

            Punto p1 = new Punto(2, 3);
            Punto p3 = new Punto(5, 1);
            Rectangulo rectangulo = new Rectangulo(p1, p3);

            Console.WriteLine(rectangulo.Area());


            Console.ReadKey();
        }
    }
}
