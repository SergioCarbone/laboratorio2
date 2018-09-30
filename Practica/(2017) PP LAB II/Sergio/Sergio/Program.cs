using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Practica";
            Console.ForegroundColor = ConsoleColor.Green;

            Grupo g = new Grupo("lala", Grupo.TipoManada.Mixta);
            Perro p1 = new Perro("Emilio", "caniche", 6, true);
            Perro p2 = new Perro("Gala", "nose",12,false);
            Gato g1 = new Gato("tito", "persa");
            Gato g2 = new Gato("tomi", "trucho");

            g += p1;
            g += p2;
            g += g1;
            g += g2;

            Console.WriteLine((string)g);
            Console.ReadKey();

        }
    }
}
