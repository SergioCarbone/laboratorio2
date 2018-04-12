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
            Console.Title = "Ejercicio 02";
            int numero;
            double cuadrado = 0, cubo = 0;

            Console.Write("Ingrese un numero: ");
            do
            {                
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if(numero != 0)
                    {
                        cuadrado = Math.Pow(numero, 2);
                        cubo = Math.Pow(numero, 3);
                    }   
                    else
                    {
                        Console.Write("Error, Reingrese: ");
                    }
                }                
            } while (numero == 0);

            Console.Write("El cuadrado de {0} es {1} y el cubo es {2}", numero, cuadrado,cubo);
            Console.ReadKey();
        }
    }
}
