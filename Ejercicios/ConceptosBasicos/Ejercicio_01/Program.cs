using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            Console.ForegroundColor = ConsoleColor.Green;

            int numero, maximo = 0, minimo = 0, promedio, resultado = 0;
            bool flagMax = false, flagMin = false;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el {0} numero de 5: ", i+1);
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero < minimo || flagMin == false)
                    {
                        minimo = numero;
                        flagMin = true;
                    }
                    if (numero > maximo || flagMax == false)
                    {
                        maximo = numero;
                        flagMax = true;
                    }
                    resultado += numero;                    
                }
                else
                {
                    continue;
                }
            }
            promedio = resultado / 5;
            
            Console.WriteLine("El numero maximo es: {0}", maximo);
            Console.WriteLine("El numero minimo es: {0}", minimo);
            Console.WriteLine("El promedio es: {0}", promedio);

            Console.ReadKey();

            
        }
    }
}
