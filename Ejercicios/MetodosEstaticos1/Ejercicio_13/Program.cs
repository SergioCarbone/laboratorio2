using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_13";
            Console.ForegroundColor = ConsoleColor.Green;

            int opcion, valor;
            char salir = 'n';
            string binario;          

            do
            {
                Console.WriteLine("1 - Convertir decimal a binario");
                Console.WriteLine("2 - Convertir binario a decimal");
                Console.WriteLine("3 - Salir");
                Console.WriteLine("");
                Console.Write("Ingrese una opcion: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese el valor a convertir: ");
                            if (int.TryParse(Console.ReadLine(), out valor))
                            {                                
                                binario = Conversor.DecimalBinario(Convert.ToDouble(valor));
                                Console.WriteLine("\nEl numero {0} en binario es {1}", valor, binario);
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            Console.Write("Ingrese el valor a convertir: ");
                            if (int.TryParse(Console.ReadLine(), out valor))
                            {
                                binario = Convert.ToString(valor);
                                valor = (int)Conversor.BinarioDecimal(binario);
                                if (valor == -1)
                                {                                    
                                    Console.WriteLine("Error, solo se pueden ingresar 0 o 1");
                                    Console.ReadKey();
                                }
                                else
                                {                                    
                                    Console.WriteLine("El numero {0} en decimal es: {1}", binario, valor);
                                    Console.ReadKey();
                                }
                            }
                            break;
                        case 3:
                            salir = 's';
                            break;
                    }
                    Console.Clear();
                }
            } while (salir != 's');            
        }
    }
}
