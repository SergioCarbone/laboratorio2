using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado ;
            int contador = 0;
            int j,i=2;

            do
            {
                resultado = 0;
                                
                for(j=i-1; j>0; j--)                
                {
                    if ((i % j) == 0)
                    {
                        resultado = resultado + j;                   
                    }
                    if (resultado == i && j == 0)
                    {
                        contador++;
                        Console.WriteLine("Numero perfecto: {0}", i);
                    }
                    if (contador == 4)
                    {                        
                        break;
                    }
                    j--;
                }
                i++;                
            }while(contador <4);
            Console.ReadKey();
        }
    }
}
