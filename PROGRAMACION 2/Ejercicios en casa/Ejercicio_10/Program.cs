using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";
            int numero;
            string asterisco = "*";
            string espacio = " ";

            Console.Write("Ingrese la cantidad de pisos: ");            
            if(int.TryParse(Console.ReadLine(),out numero))
            {
                Console.WriteLine();
                for (int i = 0; i < numero; i++)
                {
                    for (int j = i; j <= numero - 1; j++)
                    {
                        Console.Write(espacio);
                    }
                    Console.WriteLine(asterisco);
                    asterisco += "**";
                }
            }
            Console.ReadKey();
        }
    }
}
