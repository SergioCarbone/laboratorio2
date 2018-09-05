using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_04";
            Console.ForegroundColor = ConsoleColor.Green;
            int resto, cantidad = 0;

            for(int i = 2; ; i++)
            {
                resto = 0;
                for (int j = 1; j < i; j++)
                {
                    if((i%j)==0)
                    {
                        resto += j;
                    }
                }
                if(resto == i)
                {
                    Console.WriteLine("El {0} es un numero perfecto", i);
                    cantidad++;
                }
                if(cantidad == 6)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
