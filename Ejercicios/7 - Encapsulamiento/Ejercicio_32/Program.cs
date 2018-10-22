using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_32_Libreria;

namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_29";
            Console.ForegroundColor = ConsoleColor.Green;

            Equipo equipo1 = new Equipo(11, "rojo");
            Jugador j1 = new Jugador(1111, "sergio", 3, 15);

            if (equipo1 + j1)
            {
                Console.WriteLine("Se cargo el jugador");
                Console.WriteLine(j1.MostrarDatos());
            }
            Console.ReadKey();
        }
    }
}
