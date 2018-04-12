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
            int numero=0;
            double cuadrado = 0;
            double cubo = 0;

            do
            {
                Console.Write("Ingrese un numero: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero > 0)
                    {
                        cuadrado = Math.Pow(numero,2);
                        cubo = Math.Pow(numero,3);

                        Console.WriteLine("El cuadrado de {0} es {1}", numero,cuadrado);
                        Console.WriteLine("El cubo de {0} es {1}",numero,cubo);
                    }
                }
                if (numero < 0)
                {
                    Console.Write("Error, reingrese");
                }

            } while (numero < 0);

            Console.ReadKey();
        }
    }
}
