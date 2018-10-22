using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0;
            int numero;
            char c;

            do
            {
                Console.WriteLine("Ingrese un numero a sumar:");
                numero = Convert.ToInt32(Console.ReadLine());
                suma += numero;
                Console.Write("Desea seguir sumando otro numero (S/N): ");
                char.TryParse(Console.ReadLine(), out c);
                
            } while (ValidarRespuesta.ValidaS_N(c));

            Console.WriteLine("La suma de los numeros ingresados es: {0}", suma);
            Console.ReadKey();

        }
    }
}
