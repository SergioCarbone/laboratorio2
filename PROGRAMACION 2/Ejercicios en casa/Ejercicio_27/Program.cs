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
<<<<<<< HEAD
            
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
=======
            //numeros.Sort();
            //numeros1.Push(numero.Next(-100, 1000));
            //numeros.Enqueue(numero.Next(-100, 1000));

            ListaNumeros.Sort(Class1.Ordenar);
            
            foreach (int a in ListaNumeros)
            {
                Console.WriteLine("numero ingresado: {0}", a);                
                QueueNumeros.Enqueue(a);
            }

            foreach (int a in ListaNumeros)
            {
                Console.WriteLine("numero ingresado: {0}", a);
                
            }
            Console.WriteLine("-------------------------------------------------------");

            foreach (int a in QueueNumeros)
            {
                Console.WriteLine("numero ingresado: {0}", a);
                
            }
            
            Console.WriteLine("-------------------------------------------------------");



             /*
            foreach (int b in numeros1)
            {
                Console.WriteLine("numero ingresado: {0}", b);
            }
           */

            /*
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("{0}º numero ingresado: {1}", i + 1, numeros[i]);
            }
             * */
             
            Console.ReadKey();
        }
    }
}


/*
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
*/
>>>>>>> 1d3bb7e5dc4644709e0d2edacbea9ef6fa4bbcde
