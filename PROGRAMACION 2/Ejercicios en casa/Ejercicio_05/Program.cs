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
            Console.Title = "Ejercicio 05";
            int numero;
            int grupo1, grupo2;

            Console.Write("Ingrese hasta que numero quiere buscar: ");
            if(int.TryParse(Console.ReadLine(),out numero))
            {
                for(int i = 2; i <= numero; i++)
                {
                    grupo1 = 0;
                    grupo2 = 0;

                    for (int j = 0; j < i; j++)
                    {
                        grupo1 = grupo1 + j;
                    }

                    for (int k = i + 1; grupo2 < grupo1; k++)
                    {
                        grupo2 = grupo2 + k;
                    }

                    if(grupo1 == grupo2)
                    {
                        Console.WriteLine("El {0} es centro numerico",i);
                        Console.WriteLine("El grupo 1 vale: {0} y el grupo 2 vale: {0}", grupo1, grupo2);

                    }
                }
            }

            Console.ReadKey();
        }
    }
}
