using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int auxiliar;
            float promedio;
            int mayor=0;
            int menor=0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("ingrese un numero: ");
                auxiliar = int.Parse(Console.ReadLine());
                //if (int.TryParse(Console.ReadLine(), out auxiliar))
                //{
                //}
                numero = numero + auxiliar;
                if (i == 0)
                {
                    mayor = auxiliar;
                    menor = auxiliar;
                }
                else
                {
                    if (auxiliar > mayor)
                    {
                        mayor = auxiliar;
                    }
                    if (auxiliar < menor)
                    {
                        menor = auxiliar;
                    }
                }
            }
            promedio = (float) numero / 5;

            Console.WriteLine("la suma de los numeros es: {0}",numero);
            Console.WriteLine("El promedio es: {0}",promedio);
            Console.WriteLine("El mayor es {0}", mayor);
            Console.WriteLine("El menor es {0}", menor);
            
            
            

            Console.ReadKey();
        }
    }
}
