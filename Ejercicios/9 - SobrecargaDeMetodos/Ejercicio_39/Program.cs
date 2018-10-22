using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_39";
            Console.ForegroundColor = ConsoleColor.Green;

            SobreSobreescrito sobrecarga = new SobreSobreescrito();
            //Console.WriteLine(sobrecarga.ToString());
            Console.WriteLine(sobrecarga.MiMetodo());

            string objeto = "¡Este es mi método ToString sobreescrito!";
            Console.WriteLine("----------------------------------------------");

            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(sobrecarga.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(sobrecarga.GetHashCode());
            Console.ReadKey();
        }
    }
}
