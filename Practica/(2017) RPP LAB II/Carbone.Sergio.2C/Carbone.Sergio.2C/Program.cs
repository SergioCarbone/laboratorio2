using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbone.Sergio._2C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            DirectorTecnico d = new DirectorTecnico("Marcelo", "Gallardo");
            Equipo e = new Equipo("River", d);

            Jugador j1 = new Jugador("Leo", "Ponzio", 23, true);
            Jugador j2 = new Jugador("Nacho", "Fernandez", 26, false);
            Jugador j3 = new Jugador("Franco", "Armani", 1, false);

            e += j1;
            e += j2;
            e += j3;

            Console.WriteLine((string)e);
            Console.ReadKey();
        }
    }
}
