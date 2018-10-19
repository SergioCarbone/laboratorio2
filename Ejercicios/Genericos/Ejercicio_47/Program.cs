using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_47_Libreria;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Torneo<EquipoBasquet> basquet = new Torneo<EquipoBasquet>("basquet 5");
            Torneo<EquipoFutbol> futbol = new Torneo<EquipoFutbol>("futbol 8");

            EquipoBasquet b1 = new EquipoBasquet("equipo 1",DateTime.Now);
            EquipoBasquet b2 = new EquipoBasquet("equipo 2", DateTime.Now);
            EquipoBasquet b3 = new EquipoBasquet("equipo 3", DateTime.Now);

            EquipoFutbol f1 = new EquipoFutbol("equipo 4", DateTime.Now);
            EquipoFutbol f2 = new EquipoFutbol("equipo 5", DateTime.Now);
            EquipoFutbol f3 = new EquipoFutbol("equipo 6", DateTime.Now);

            futbol += f1;
            futbol += f2;
            futbol += f3;
            basquet += b1;
            basquet += b2;
            basquet += b3;

            Console.WriteLine(futbol.Mostrar());           
            Console.WriteLine(futbol.JugarPartido);
            Console.WriteLine(futbol.JugarPartido);
            Console.WriteLine(futbol.JugarPartido);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(basquet.Mostrar());
            Console.WriteLine(basquet.JugarPartido);
            Console.WriteLine(basquet.JugarPartido);
            Console.WriteLine(basquet.JugarPartido);
        }
    }
}
