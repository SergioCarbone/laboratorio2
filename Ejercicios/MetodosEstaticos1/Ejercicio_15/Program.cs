using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_15";
            Console.ForegroundColor = ConsoleColor.Green;

            double numero1, numero2;
            int opcion;
            double resultado;
            char operacion, salir = 's';

            do
            {                
                Console.WriteLine("1- Realizar una cuenta");
                Console.WriteLine("2- Salir");
                Console.WriteLine("");
                Console.Write("Ingrese una opcion: ");
                if(int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese el primer numero: ");
                            if (double.TryParse(Console.ReadLine(), out numero1))
                            {
                                Console.Write("Ingrese el segundo numero: ");
                                if (double.TryParse(Console.ReadLine(), out numero2))
                                {
                                    Console.Write("Ingrese la operacion que desea: ");
                                    operacion = (char)Console.Read();

                                    resultado = Calculadora.Calcular(numero1, numero2, operacion);
                                    if (resultado == -0.1 && operacion == '/')
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Error, no se puede dividir por 0");
                                        Console.ReadKey();
                                    }
                                    else if (resultado == -0.2)
                                    {
                                        Console.Clear();
                                        Console.Write("Error, ingrese una operacion valida");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Calculadora.Mostrar(resultado);
                                        Console.ReadKey();
                                    }
                                }
                            }
                            break;
                        case 2:
                            salir = 'n';
                            break;
                        case 3:
                            Console.Write("Error, elija una opcion correcta");
                            Console.ReadKey();
                            break;
                    }
                }
                Console.Clear();
            } while (salir != 'n');            
        }
    }
}
