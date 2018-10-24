using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_14";
            Console.ForegroundColor = ConsoleColor.Green;

            char salir = 'n';
            int opcion;            

            do
            {
                Console.WriteLine("1- Calcular el area del cuadrado");
                Console.WriteLine("2- Caluclar el area del triangulo");
                Console.WriteLine("3- Calcular el area del circulo");
                Console.WriteLine("4- Salir");
                Console.WriteLine("");
                Console.Write("Elija una opcion: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch(opcion)
                    {
                        case 1:
                            double lado;
                            Console.Write("Ingrese la medida del lado: ");
                            if (double.TryParse(Console.ReadLine(), out lado) && lado > 0)
                            {
                                Console.WriteLine("El area del cuadrado es: {0}", CalculoDeArea.CalcularCuadrado(lado));
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Error, ingrese un numero mayor a 0");
                            }
                            break;
                        case 2:
                            double altura;
                            Console.Write("Ingrese el lado del triangulo: ");
                            if (double.TryParse(Console.ReadLine(), out lado) && lado > 0)
                            {
                                Console.Write("Ingrese la altura del triangulo: ");
                                if(double.TryParse(Console.ReadLine(), out altura) && altura > 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("El area del triangulo es: {0}", CalculoDeArea.CalcularTriangulo(lado, altura));
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Error, ingrese un numero mayor a 0");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Error, ingrese un numero mayor a 0");
                            }
                            break;
                        case 3:
                            Console.Write("Ingrese el radio del circulo: ");
                            if(double.TryParse(Console.ReadLine(), out lado) && lado > 0)
                            {
                                Console.Clear();
                                Console.WriteLine("El area del circulo es: {0}", CalculoDeArea.CalcularCirculo(lado));
                                Console.ReadKey();                                
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Error, ingrese un numero mayor a 0");
                            }
                            break;
                        case 4:
                            salir = 's';
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Error, ingrese una de las opciones");
                            Console.ReadKey();
                            break;
                    }

                }
                Console.Clear();
            } while (salir != 's');
        }
    }
}
