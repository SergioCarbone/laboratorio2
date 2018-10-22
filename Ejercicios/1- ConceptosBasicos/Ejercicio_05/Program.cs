using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_05";
            Console.ForegroundColor = ConsoleColor.Green;

            int numero, grupo1 = 0, grupo2 = 0, s; 

            Console.Write("Ingrese un numero limite: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                for (int i = 1; i <= numero; i++)
                {
                    grupo1 += (i - 1);
                    s = i + 1;

                    do
                    {
                        grupo2 += s;
                        if (grupo1 == grupo2)
                        {
                            Console.WriteLine("El {0} es un centro numerico", i);
                        }
                        s++;
                    }
                    while (grupo2 <= grupo1);
                    grupo2 = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
