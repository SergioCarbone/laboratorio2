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
            Persona p1 = new Persona("Sergio", "Carbone");
            Persona p2 = new Persona();            

            try
            {
                Persona.Guardar(p1);
                p2 = Persona.Leer();

                Console.WriteLine(p1.ToString());
                Console.WriteLine(p2.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadKey();
        }
    }
}
