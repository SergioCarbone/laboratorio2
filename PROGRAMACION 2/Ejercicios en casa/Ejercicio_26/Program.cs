using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux, j;
            int[] valor = new int[20];
            Random numero = new Random();

            for (int i = 0; i < valor.Length; i++)
            {
                valor[i] = numero.Next(-100, 1000);
            }

            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine("{0}º numero ingresado: {1}",i+1,valor[i]);
            }

            for (int i = 1; i < valor.Length; i++)
            {
                aux = valor[i];
                j = i;
                while (j > 0 && aux > valor[j-1])
                {
                    valor[j] = valor[j - 1];
                    j--;
                }
                valor[j] = aux;
            }
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] >= 0)
                {
                    Console.WriteLine("{0}º numero ingresado: {1}", i + 1, valor[i]);
                }
            }


            
            Console.WriteLine("--------------------------------------------------------------");

            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] <= 0)
                {
                    Console.WriteLine("{0}º numero ingresado: {1}", i + 1, valor[i]);
                }
            }


            Console.ReadKey();
        }
    }
}

