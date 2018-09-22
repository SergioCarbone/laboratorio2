using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_27";
            Console.ForegroundColor = ConsoleColor.Green;

            List<int> lista = new List<int>();
            Queue<int> cola = new Queue<int>();
            Stack<int> pila = new Stack<int>();
            Random numero = new Random();
            
            for (int i = 0; i < 20; i++)
            {
                lista.Add(numero.Next(-200, 200));                
            }

            Console.WriteLine("Numeros en la lista: ");
            foreach (int valor in lista)
            {
                Console.WriteLine("Valor: {0}", valor);
            }
            Console.ReadKey();

            lista.Sort(Class1.OrdenarDes);

            Console.WriteLine();
            Console.WriteLine("Numeros en la cola");
            foreach (int valor in lista)
            {
                cola.Enqueue(valor);
                if(valor >= 0)
                {
                    Console.WriteLine("Valor: {0}", valor);
                }
            }
            Console.ReadKey();
         
            lista.Sort(Class1.OrdenarAsc);

            Console.WriteLine();
            Console.WriteLine("Numeros en la pila");
            foreach (int valor in lista)
            {
                pila.Push(valor);               
            }

            foreach (int valor in pila)
            {               
                if (valor < 0)
                {
                    Console.WriteLine("Valor: {0}", valor);
                }
            }
            Console.ReadKey();
        }
    }
}
