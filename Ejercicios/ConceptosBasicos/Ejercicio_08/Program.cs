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
            Console.Title = "Ejercicio_08";
            Console.ForegroundColor = ConsoleColor.Green;

            int antiguedad, cantHorasTrab, cantEmpleados;
            string nombre;
            double importeTotal;
            float valorHora;
            bool flag = false;

            Console.Write("Cuantos empleados va a ingresar?: ");
            if((int.TryParse(Console.ReadLine(), out cantEmpleados) && cantEmpleados > 0))
            {
                for (int i = 0; i < cantEmpleados; i++)
                {
                    Console.Clear();
                    Console.Write("Ingrese el nombre del empleado: ");
                    nombre = Console.ReadLine();

                    Console.Write("Ingrese la antiguedad: ");
                    if((int.TryParse(Console.ReadLine(), out antiguedad) && antiguedad > 0))
                    {
                        Console.Write("Ingrese el valor de la hora: ");
                        if((float.TryParse(Console.ReadLine(), out valorHora) && valorHora > 0))
                        {
                            Console.Write("Ingrese la cantidad de horas trabajadas: ");
                            if ((int.TryParse(Console.ReadLine(), out cantHorasTrab) && cantHorasTrab > 0))
                            {
                                flag = true;
                                importeTotal = Calcular.CalcularHorasTrabajadas(valorHora, cantHorasTrab, antiguedad);                                
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }
                    if (flag == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Recibo de sueldo de: {0}", nombre);
                        Console.WriteLine("");
                        Console.WriteLine("Antiguedad: {0} años", antiguedad);
                        Console.WriteLine("Valor de la hora trabajada: {0} pesos", valorHora);
                        Console.WriteLine("Total a cobrar en bruto: {0} pesos", importeTotal);
                        Console.WriteLine("Importe total de descuentos: {0} pesos", (importeTotal -(importeTotal * 0.87)));
                        Console.WriteLine("Valor neto a cobrar: {0} pesos", (importeTotal * 0.87));
                        Console.ReadKey();
                    }
                }                
            }
            else
            {
                Console.Write("Ingrese un valor valido");
            }                       
            Console.ReadKey();
        }
    }
}
