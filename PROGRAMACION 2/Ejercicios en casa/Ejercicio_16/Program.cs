using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 2; i++)
            {
                Alumno alumno = new Alumno();
                Console.Clear();
                string nombre, apellido;
                int nota1, nota2, legajo;                

                Console.Write("Ingrese el nombre del alumno: ");
                nombre = Console.ReadLine();
                alumno.nombre = nombre;

                Console.Write("Ingrese el apellido: ");
                apellido = Console.ReadLine();
                alumno.apellido = apellido;

                Console.Write("Ingrese el legajo: ");
                if (int.TryParse(Console.ReadLine(), out legajo))
                {
                    alumno.legajo = legajo;
                }

                Console.Write("Ingrese la nota 1: ");
                if (int.TryParse(Console.ReadLine(), out nota1))
                {
                    Console.Write("Ingrese la nota 2: ");
                    if (int.TryParse(Console.ReadLine(), out nota2))
                    {
                      alumno.Estudiar(nota1, nota2);
                    }
                }
                Console.WriteLine(alumno.Mostrar());
                Console.ReadKey();
            }                        
        }
    }
}
