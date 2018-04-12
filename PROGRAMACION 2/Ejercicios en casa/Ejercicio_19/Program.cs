using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor de numeros";
            int numero;
            string auxiliar;
            int opcion;
            int entero;
            string binario;
            string salir = "n";
            int suma, num1, num2;
            
            Calculador calculador = new Calculador();
            Sumador suma1 = new Sumador();
            Sumador suma2 = new Sumador();

            Console.Write("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out num1))
            {
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine(suma1.Sumar(num1, num2));
                }
            }
            Console.Write("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out num1))
            {
                if (int.TryParse(Console.ReadLine(), out num2))
                {                    
                    Console.WriteLine(suma2.Sumar(num1, num2));
                }
            }
            Console.Write("Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out num1))
            {
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine(suma2.Sumar(num1, num2));
                }
            }
            Console.WriteLine("suma vale: {0}", (int)suma1);
            Console.WriteLine("suma vale: {0}", (int)suma2);

            Console.Write("Los sumadores son iguales? {0}",suma1 | suma2);

            Console.WriteLine();
            
            
           

            do
            {
                Console.WriteLine();
                Console.WriteLine("1 - Convertir de Binario a Entero");
                Console.WriteLine("2 - Convertir de Entero a Binario");
                Console.WriteLine("3 - Mostrar Numero convertido a binario");
                Console.WriteLine("4 - Mostrar Numero convertido a entero");
                Console.WriteLine("5 - Salir");
                Console.WriteLine();
                Console.Write("Elija una opcion: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese un numero: ");
                            auxiliar = Console.ReadLine();
                            if (int.TryParse(auxiliar, out numero))
                            {
                                calculador.Acumular(auxiliar);
                                Console.WriteLine("En entero es: {0}", calculador.GetResultadoEntero());
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            Console.Write("Ingrese un numero: ");
                            if (int.TryParse(Console.ReadLine(), out numero))
                            {
                                Console.WriteLine("En binario es: {0}", Conversor.enteroBinario(numero));
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            Console.Write("Numero convertido a binario: ");
                            Console.Write(calculador.GetResultadoBinario());
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Write("Numero entero ingresado:");
                            Console.Write(calculador.GetResultadoEntero());
                            Console.ReadKey();
                            break;
                        case 5:
                            salir = "s";
                            break;
                    }
                }
                Console.Clear();
            } while (salir != "s");

        }
    }
}
