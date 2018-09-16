using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billete;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_20";
            Console.ForegroundColor = ConsoleColor.Green;

            //Euro e = new Euro(10, 0.809f);
            //Dolar d = new Dolar(10);
            //Peso p = new Peso(10, 20.1655f);

            Euro e = new Euro(1);
            Dolar d = new Dolar(1);
            Peso p = new Peso(1);

            Euro aux_e = e + d;
            Console.WriteLine("Euro + Dólar = EUR {0}", aux_e.GetCantidad());
            aux_e = e + p;
            Console.WriteLine("Euro + Pesos= EUR {0}", aux_e.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Dolar aux_d = d + e;
            Console.WriteLine("Dólar + Euro: USD {0}", aux_d.GetCantidad());
            aux_d = d + p;
            Console.WriteLine("Dólar + Pesos: USD {0}", aux_d.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Peso aux_p = p + e;
            Console.WriteLine("Pesos + Euro: ARS {0}", aux_p.GetCantidad());
            aux_p = p + d;
            Console.WriteLine("Pesos + Dólar: ARS {0}", aux_p.GetCantidad());

            Console.ReadKey();
        }
    }
}
