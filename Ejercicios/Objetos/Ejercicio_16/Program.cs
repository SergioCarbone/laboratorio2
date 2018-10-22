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
            Console.Title = "Ejercicio_16";
            Console.ForegroundColor = ConsoleColor.Green;

            int legajo;
            byte nota1, nota2;

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Alumno alumno = new Alumno();

                Console.Write("Ingrese el nombre del alumno: ");
                alumno.nombre = Console.ReadLine();

                Console.Write("Ingrese el apellido del alumno: ");
                alumno.apellido = Console.ReadLine();

                Console.Write("Ingrese el legajo: ");
                if (int.TryParse(Console.ReadLine(), out legajo))
                {
                    alumno.legajo = legajo;
                    Console.Write("Ingrese la primer nota: ");
                    if (byte.TryParse(Console.ReadLine(), out nota1) && nota1 >= 0 && nota1 <= 10)
                    {
                        Console.Write("Ingrese la segunda nota: ");
                        if (byte.TryParse(Console.ReadLine(), out nota2) && nota2 >= 0 && nota2 <= 10)
                        {
                            alumno.Estudiar(nota1, nota2);
                        }
                        else
                        {
                            Console.WriteLine("Error, solo se permiten numeros entre 0 y 10");
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error, solo se permiten numeros entre 0 y 10");
                        Console.ReadKey();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Error, solo se permiten numeros");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine(alumno.Mostrar());
                Console.ReadKey();
            }
        }
    }
}
