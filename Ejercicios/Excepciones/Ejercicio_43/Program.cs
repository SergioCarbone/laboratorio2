using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_43_Libreria;

namespace Ejercicio_43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_36";
            Console.ForegroundColor = ConsoleColor.Green;

            //Competencia al = new Competencia(3, 5, Competencia.TipoCompetencia.MotoCross);
            Competencia monaco = new Competencia(15, 10, Competencia.TipoCompetencia.AutoF1);
            AutoF1 a1 = new AutoF1(1, "ferrari", 350);
            AutoF1 a2 = new AutoF1(2, "ferrari", 300);
            AutoF1 a3 = new AutoF1(1, "mercedes", 400);
            MotoCross m4 = new MotoCross(5, "Rouser", 135);

            if (monaco + a1)
            {
                Console.WriteLine("a1");
            }

            if (monaco + a2)
            {
                Console.WriteLine("a2");
            }

            if (monaco + a3)
            {
                Console.WriteLine("a3");
            }
            if (monaco + m4)
            {
                Console.WriteLine("m4");
            }

            Console.ReadKey();
            Console.Clear();

            if (monaco - a3)
            {
                Console.WriteLine(monaco.MostrarDatos());
            }
            Console.ReadKey();

        }
    }
}
