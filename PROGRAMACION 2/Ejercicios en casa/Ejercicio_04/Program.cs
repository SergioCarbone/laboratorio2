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
            Console.Title = "Ejercicio 04";
            int i = 2, j, contador = 0;
            int resultado;

            do
            {
                resultado = 0;
                for(j = i - 1; j > 0; j--)
                {
                    if((i % j) == 0)
                    {
                        resultado = resultado + j;
                    }

                    if (resultado == i && j == 1)
                    {
                        contador++;
                        Console.WriteLine("El {0} es perfecto", i);
                    }
                }
                i++;
            } while (contador < 4);
            Console.ReadKey();
        }
    }
}
