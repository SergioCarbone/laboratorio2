using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_06";
            Console.ForegroundColor = ConsoleColor.Green;

            int fecha;
            Console.Write("Ingrese el año de desea averiguar si es bisiesto: ");
            if(int.TryParse(Console.ReadLine(), out fecha))
            {
                if ((fecha % 4) == 0 ) 
                {
                    if ((fecha % 100) == 0 && (fecha % 400) == 0)
                    {
                        Console.WriteLine("El año es bisiesto");
                    }
                    else if ((fecha % 4) == 0 && (fecha % 100) != 0)
                    {
                        Console.WriteLine("El año es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("El año {0} NO es bisiesto", fecha);
                    }
                }
                else
                {
                    Console.WriteLine("El año {0} NO es bisiesto", fecha);
                }
            }
            Console.ReadKey();
        }
    }
}
