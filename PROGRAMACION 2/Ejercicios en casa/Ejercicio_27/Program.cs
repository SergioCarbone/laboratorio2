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
            List<int> ListaNumeros = new List<int>();
            Queue<int> QueueNumeros = new Queue<int>();
            Stack<int> StackNumeros1 = new Stack<int>();
 
            Random numero = new Random();
            int cantidad = 20;

            for (int i = 0; i < cantidad; i++)
            {
               ListaNumeros.Add( numero.Next(-100, 1000));
            }
            
            Console.WriteLine("EMPIEZA LA LISTA");
            foreach (int a in ListaNumeros)
            {
                Console.WriteLine("numero ingresado: {0}", a);                
            }
            Console.WriteLine("TERMINA LA LISTA");

            Console.WriteLine("-------------------------------------------------------");

            ListaNumeros.Sort(Class1.OrdenarDecreciente);
            foreach (int a in ListaNumeros)
            {
                QueueNumeros.Enqueue(a);
            }

            Console.WriteLine("EMPIEZA EL QUEUE");
            foreach (int a in QueueNumeros)
            {
                if(a >= 0)
                {
                    Console.WriteLine("numero ingresado: {0}", a);
                }
            }
            Console.WriteLine("TERMINA EL QUEUE");
            Console.WriteLine("-------------------------------------------------------");

            ListaNumeros.Sort(Class1.OrdenarCreciente);
            foreach (int a in ListaNumeros)
            {
                StackNumeros1.Push(a);
            }

            Console.WriteLine("EMPIEZA EL STACK");
            foreach (int a in StackNumeros1)
            {
                if(a < 0)
                {
                    Console.WriteLine("numero ingresado: {0}", a);
                }
            }
            Console.WriteLine("TERMINA EL STACK");
            Console.ReadKey();
        }
    }
}