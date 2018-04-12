using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            const int cantEmpleados = 5;
            Console.Title = "Ejercicio 08";
            string nombre;
            int cantHoras, antiduedad, valorHora;

            for (int i = 0; i < cantEmpleados; i++)
            {
                Empleado empleado = new Empleado();
                Console.Write("Ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese la cantidad de años trabajados: ");
                antiduedad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese cuanto gana por hora: ");
                valorHora = int.Parse(Console.ReadLine());

                Console.Write("Ingrese cuantas horas trabajo en el mes: ");
                cantHoras = int.Parse(Console.ReadLine());

                Console.WriteLine();                
                Console.WriteLine("{0} cobra {1} por hora",nombre, valorHora);
                Console.WriteLine("Trabajo {0} horas en el mes.",cantHoras);
                Console.WriteLine("Trabaja hace {0} años.", antiduedad);
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("El sueldo de {1} es de: {0}", empleado.CalcularSueldo(valorHora, cantHoras, antiduedad),nombre);
                Console.ReadKey();
                Console.Clear();
            }

            
            
        }
    }
}
