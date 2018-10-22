using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_48_Libreria;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Factura A = new Factura(1500);
            Recibo X = new Recibo();
            Recibo Z = new Recibo(10);
            Contabilidad<Factura, Recibo> Agrisol = new Contabilidad<Factura, Recibo>();

            Agrisol += A;
            Agrisol += X;
            Agrisol += Z;

            
            Console.WriteLine(Agrisol.MostrarEgresos());
            Console.WriteLine(Agrisol.MostrarIngresos());
            Console.ReadKey();

        }
    }
}
