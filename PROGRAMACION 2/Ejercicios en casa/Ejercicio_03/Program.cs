using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int numero;
            int i, j;

            Console.Write("Ingrese un numero: ");
            if(int.TryParse(Console.ReadLine(),out numero))
            {
                for(i = 2; i <= numero; i++)
                {
                    for(j = 2; j < i; j++)
                    {
                        if((i % j) == 0)
                        {
                            break;
                        }
                    }
                    if(i == j)
                    {
                        Console.WriteLine("El {0} es un numero primo", i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
