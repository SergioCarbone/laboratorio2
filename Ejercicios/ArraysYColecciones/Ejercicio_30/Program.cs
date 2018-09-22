using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_ 30";
            Console.ForegroundColor = ConsoleColor.Green;

            Competencia monaco = new Competencia(15, 10);
            AutoF1 a1 = new AutoF1(1, "ferrari");
            AutoF1 a2 = new AutoF1(2, "ferrari");
            AutoF1 a3 = new AutoF1(1, "mercedes");

            if (monaco + a1)
            {                
                if(monaco + a2)
                {
                    if(monaco + a3)
                    {
                        Console.WriteLine(monaco.MostrarDatosCompetencia());
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            Console.ReadKey();
            Console.Clear();

            if (monaco - a3)
            {
                Console.WriteLine(monaco.MostrarDatosCompetencia());
            }
            Console.ReadKey();
        }        
    }
}
