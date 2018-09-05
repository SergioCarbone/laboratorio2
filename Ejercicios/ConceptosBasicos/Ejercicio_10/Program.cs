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
            Console.Title = "Ejercicio_10";
            Console.ForegroundColor = ConsoleColor.Green;

            int pisos;
            string asterisco = "*", espacio = " ";

            Console.Write("Ingrese la cantidad de pisos: ");
            if((int.TryParse(Console.ReadLine(), out pisos) && pisos > 0))
            {
                Console.Clear();
                for (int i = 0; i < pisos; i++)
                {                    
                    for (int j = i; j <= pisos - 1; j++)
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
