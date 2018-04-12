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
            Console.Title = "Ejercicio 15";
            Console.ForegroundColor = ConsoleColor.Yellow;
            char operador;
            double numero1, numero2;
            string salir = "no";
            do
            {
                Console.Write("Ingrese el primer numero: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                numero2 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la operacion que desea + , - , / , *: ");
                operador = char.Parse(Console.ReadLine());
                Console.WriteLine();
                
                    switch (operador)
                    {
                        case '+':
                        Calculadora.Mostrar(Calculadora.Calcular(numero1, numero2, operador));
                            Console.ReadKey();
                            break;
                        case '-':
                        Calculadora.Mostrar(Calculadora.Calcular(numero1, numero2, operador));
                            Console.ReadKey();
                            break;
                        case '*':
                        Calculadora.Mostrar(Calculadora.Calcular(numero1, numero2, operador));
                        Console.ReadKey();
                            break;
                        case '/':
                        double resultado = Calculadora.Calcular(numero1, numero2, operador);
                        if(resultado == -1)
                        {
                            Console.WriteLine("Error, no se puede dividir por 0");
                        }
                        else
                        {
                            Calculadora.Mostrar(resultado);
                        }
                            Console.ReadKey();
                            break;
                    default:
                            salir = "si";
                            break;
                    }
                Console.Clear();
            } while (salir == "no");


            Console.ReadKey();
        }
    }
}
