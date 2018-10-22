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
            int numero;
            int min = int.MaxValue;
            int max = int.MinValue;
            int acum = 0;
            int prom;
            for(int i = 0; i <10; i++) { 
                numero = Convert.ToInt32(Console.ReadLine());
                if (Validacion.Validar(numero, -100, 100)) {
                    if (numero < min)
                    {
                        min = numero;
                    }
                    if (numero > max)
                    {
                        max = numero;
                    }
                    acum += numero;
                }
            }
            prom = acum / 10;
            Console.WriteLine("Valor maximo{0}", max);
            Console.WriteLine("Valor minimo{0}", min);
            Console.WriteLine("Valor promedio{0}", prom);
            Console.ReadKey();
        }
    }
}
