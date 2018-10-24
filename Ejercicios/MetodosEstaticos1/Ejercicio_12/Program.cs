using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_12";
            Console.ForegroundColor = ConsoleColor.Green;

            char continuar = 's';
            bool seguir = true;
            int valor, total = 0;

            do
            {
                Console.Write("Ingrese un numero entero: ");
                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    total += valor;
                    Console.Write("Desea continuar? S/N: ");                                  
                    if(char.TryParse(Console.ReadLine(), out continuar))
                    {
                        seguir = ValidarRespuesta.ValidaS_N(continuar);
                    }
                }
                else
                {                    
                    Console.WriteLine("Error, ingrese un numero entero");
                    Console.ReadKey();
                }
                Console.Clear();
            } while (seguir);

            Console.WriteLine("La suma total es: {0}", total);
            Console.ReadKey();
        }
    }
}
