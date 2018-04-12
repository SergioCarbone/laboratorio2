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
            string asterisco = "*";
            string espacio = " ";
            int numero = 0;
            int a;

            Console.Write("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
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
