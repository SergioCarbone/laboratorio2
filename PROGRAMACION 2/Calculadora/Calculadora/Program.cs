using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor de numeros";
            int numero;
            string auxiliar;
            int opcion;
            double entero;
            string binario;
            string salir = "n";

            do
            {
                Console.WriteLine();
                Console.WriteLine("1 - Convertir de Binario a Entero");
                Console.WriteLine("2 - Convertir de Entero a Binario");
                Console.WriteLine("3 - Salir");
                Console.WriteLine();
                Console.Write("Elija una opcion: ");

                if(int.TryParse(Console.ReadLine(), out opcion))
                {
                        switch (opcion)
                        {
                            case 1:
                                Console.Write("Ingrese un numero: ");
                                auxiliar = Console.ReadLine();                           
                                if(int.TryParse(auxiliar,out numero))
                                {                              
                                    entero = Conversor.binarioEntero(auxiliar);
                                    if (entero == -1)
                                    {
                                        Console.WriteLine("Error, solo se permiten 0 y 1");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El numero {0} convertido a binario es: {1}", numero, entero);
                                        Console.ReadKey();
                                    }                                
                                }
                                break;
                            case 2:
                                Console.Write("Ingrese un numero: ");                           
                                if (int.TryParse(Console.ReadLine(), out numero))
                                {                                
                                    binario = Conversor.enteroBinario(numero);
                                    Console.WriteLine("El numero {0} convertido a binario es: {1}", numero, binario);
                                    Console.ReadKey();
                                }
                                break;
                            case 3:
                                salir = "s";
                                break;
                        }               
                    }
                Console.Clear();
            } while (salir != "s"); 
            
        }
    }
}
