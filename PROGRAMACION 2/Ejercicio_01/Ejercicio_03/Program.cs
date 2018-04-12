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
            int numPrimo = 0;
            int numero = 0;
            int flag = 0;
            int j,i;
            Console.Write("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                for (j = 2; j <= numero; j++)
                {
                    for (i = 2; i < j; i++)
                    {
                        if ((j % i) == 0)
                        {
                            break;
                        }

                    }
                    if (i == j)
                    {
                        Console.WriteLine("Numero primo: {0}", j);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
