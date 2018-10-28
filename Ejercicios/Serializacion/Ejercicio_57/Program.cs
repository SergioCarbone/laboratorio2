using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Persona p = new Persona("Sergio", "Carbone");
            Persona.Guardar(p);

            Persona a = new Persona();
            a = Persona.Leer();

            Console.WriteLine(p.ToString());
            Console.WriteLine(a.ToString());
            Console.ReadKey();
        }
    }
}
