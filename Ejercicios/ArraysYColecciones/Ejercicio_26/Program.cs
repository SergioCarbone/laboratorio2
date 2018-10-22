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
            Console.Title = "Ejercicio 26";
            Console.ForegroundColor = ConsoleColor.Green;

            int j = 1;
            List<int> lista = new List<int>();
            Random numero = new Random();

            for (int i = 0; i < 20; i++)
            {
                lista.Add(numero.Next(-200, 500));
            }
            
            foreach (int list in lista)
            {                
                Console.WriteLine("Valores ingresados originalmente: {0}º - {1}", j, list);
                j++;
            }
            Console.ReadKey();
            lista.Sort(Class1.OrdenarDes);

            Console.WriteLine();
            Console.WriteLine("Valores positivos ordenados");
            foreach (int valor in lista)
            {
                if(valor >= 0)
                {
                    Console.WriteLine(valor);
                }
            }
            Console.ReadKey();
            lista.Sort(Class1.OrdenarDes);

            Console.WriteLine();
            Console.WriteLine("Valores negativos ordenados");
            foreach (int valor in lista)
            {
                if(valor < 0)
                {
                    Console.WriteLine(valor);
                }
            }

            
            Console.ReadKey();
        }
    }
}
