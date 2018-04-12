using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 100;
            const int min = -100;
            int numero;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Rango -100 a 100");
                Console.Write("Ingrese el numero {0} de 10: ", i + 1);
                if(int.TryParse(Console.ReadLine(), out numero))
                {
                    if(Validacion.validar(numero,max,min))
                    {
                        Console.WriteLine("Correcto.");
                    }
                    else
                    {
                        Console.WriteLine("Error, fuera de rango");
                    }
                    
                }
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
