using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int aux;
            string numero;
            long a = 0;

            Console.Write("Ingrese un numero ");
            if(int.TryParse(Console.ReadLine(),out aux))
            {
                numero = aux.ToString();
                aux = a.CantidadDeDigitos(numero);
            }

            Console.WriteLine("Tiene {0} digitos",aux);
            Console.ReadKey();
        }
    }
}
