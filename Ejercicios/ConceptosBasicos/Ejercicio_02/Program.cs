using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_02";
            Console.ForegroundColor = ConsoleColor.Green;

            double numero, cuadrado = 0, cubo = 0;
            bool flag = false;

            do
            {
                Console.Write("Ingrese un numero mayor a 0: ");
                if (double.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero > 0)
                    {
                        cubo = Math.Pow(numero, 3);
                        cuadrado = Math.Pow(numero, 2);
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Error, reingrese un numero mayor a 0");
                    }
                }
                else
                {
                    Console.WriteLine("Error, reingrese un numero");
                }
            } while (flag == false);

            Console.WriteLine();
            Console.WriteLine("El cuadrado de {0} es: {1}", numero, cuadrado);
            Console.WriteLine();
            Console.WriteLine("El cubo de {0} es: {1}", numero, cubo);

            Console.ReadKey();
            
        }
    }
}
