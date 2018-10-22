using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_35_libreria;

namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_35";
            Console.ForegroundColor = ConsoleColor.Green;

            DateTime nac = new DateTime(1988, 12, 02);

            Equipo equipo1 = new Equipo(11, "rojo");
            Jugador j1 = new Jugador(1111, "sergio", 6, 30);
            DirectorTecnico dt1 = new DirectorTecnico("Gallardo", nac, 151515);


            if (equipo1 + j1)
            {
                Console.WriteLine("Se cargo el jugador");
                Console.WriteLine(j1.MostrarDatos());
                Console.WriteLine(dt1.MostrarDatos());
            }
            Console.ReadKey();
        }
    }
}
