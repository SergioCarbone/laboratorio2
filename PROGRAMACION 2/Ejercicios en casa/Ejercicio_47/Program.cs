using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoDeBasquet> basquet = new Torneo<EquipoDeBasquet>("torneoBasquet");
            Torneo<EquipoDeFutbol> futbol = new Torneo<EquipoDeFutbol>("torneoFutbol");

            EquipoDeBasquet b1 = new EquipoDeBasquet("equipo1", DateTime.Today);
            EquipoDeBasquet b2 = new EquipoDeBasquet("equipo2", DateTime.Today);
            EquipoDeBasquet b3 = new EquipoDeBasquet("equipo3", DateTime.Today);

            EquipoDeFutbol f1 = new EquipoDeFutbol("equipo4", DateTime.Today);
            EquipoDeFutbol f2 = new EquipoDeFutbol("equipo5", DateTime.Today);
            EquipoDeFutbol f3 = new EquipoDeFutbol("equipo6", DateTime.Today);

            basquet += b1;
            basquet += b2;
            basquet += b3;           
            futbol += f1;
            futbol += f2;

            Console.WriteLine(futbol.Mostrar());
            Console.WriteLine(basquet.Mostrar());

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(futbol.JugarPartido);
            Console.WriteLine(basquet.JugarPartido);
            Console.WriteLine(futbol.JugarPartido);
            Console.WriteLine(basquet.JugarPartido);
            Console.ReadKey();

        }
    }
}
