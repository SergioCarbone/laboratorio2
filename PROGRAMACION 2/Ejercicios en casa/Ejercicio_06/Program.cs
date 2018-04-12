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
            Console.Title = "Ejercicio 06";
            int numero;

            Console.Write("Ingrese el ano que desea saber si es bisiesto: ");
            if(int.TryParse(Console.ReadLine(),out numero))
            {               
                if((numero % 4) == 0)
                {
                    if((numero % 100) == 0 && (numero % 400) == 0)
                    {
                        Console.WriteLine("Es bisiesto");
                    }
                    else if ((numero % 4) == 0 && (numero % 100) != 0)
                    {
                        Console.WriteLine("Es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("No es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("No es bisiesto");
                }

            }
            Console.ReadKey();
        }
    }
}
