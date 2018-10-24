using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_11";
            Console.ForegroundColor = ConsoleColor.Green;

            int valor, min = int.MaxValue, max = int.MinValue, i = 1, total = 0;
            do
            {
                Console.Write("Ingrese el {0}º numero de 10: ", i);
                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    if (Validacion.Validar(valor, -100, 100))
                    {
                        total += valor;
                        if(valor <= min)
                        {
                            min = valor;
                        }
                        if(valor >= max)
                        {
                            max = valor;
                        }
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Error, ingrese un numero entre -100 y 100");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Error, ingrese un numero");
                    Console.ReadKey();
                }                
                Console.Clear();
            } while (i <= 10);

            Console.WriteLine("El numero maximo es: {0} y el numero minimo es: {1}", max, min);
            Console.WriteLine("El promedio de: {0} / 10 es: {1}", total, (total / 10));
            Console.ReadKey();
        }
    }
}
