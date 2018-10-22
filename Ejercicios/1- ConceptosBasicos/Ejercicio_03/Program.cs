using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercico_03";
            Console.ForegroundColor = ConsoleColor.Green;

            int numero;
            bool flag = false;
            Console.Write("Ingrese un numero: ");
            if(int.TryParse(Console.ReadLine(), out numero))
            {
                for (int i = 2; i < numero; i++)
                {
                    flag = false;
                    for (int j = 2; j < i; j++)
                    {
                        if((i%j) == 0)
                        {
                            flag = true;
                            break;
                        }                                 
                    }
                    if(flag == false)
                    {
                        Console.WriteLine("Los numeros primos son: {0} ",i );                        
                    }                    
                }                
            }
            Console.ReadKey();
        }        
    }
}
