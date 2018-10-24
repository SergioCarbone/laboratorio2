using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_53_Libreria;

namespace Ejercicio_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Cartuchera1 c1 = new Cartuchera1();
            Cartuchera2 c2 = new Cartuchera2();

            c1.miCartuchera = new List<IAcciones>();
            c2.boligrafo = new List<Boligrafo>();
            c2.lapiz = new List<Lapiz>();

            Lapiz l1 = new Lapiz(1);
            Lapiz l2 = new Lapiz(1);

            Boligrafo b1 = new Boligrafo(1, ConsoleColor.Green);
            Boligrafo b2 = new Boligrafo(1, ConsoleColor.Green);

            c2.lapiz.Add(l1);
            c2.lapiz.Add(l2);

            c2.boligrafo.Add(b1);
            c2.boligrafo.Add(b2);

            c1.miCartuchera.Add(l1);
            c1.miCartuchera.Add(l2);
            c1.miCartuchera.Add(b1);
            c1.miCartuchera.Add(b2);

            Console.WriteLine("Imprimo c1.miCartuchera");

            for (int i = 0; i < c1.miCartuchera.Count; i++)
            {
                Console.WriteLine(c1.ProbarElementos());
                Console.WriteLine(c1.miCartuchera[i]);
            }

            int cantidad = c1.miCartuchera.Count + c2.boligrafo.Count + c2.lapiz.Count;
            for (int i = 0; i < cantidad; i++)
            {
                
                if (c2.ProbarElementos() == true)
                {
                    Console.WriteLine("c2 = true");
                    //Console.WriteLine(c1.miCartuchera[i]);
                }
                else
                {
                    Console.WriteLine("c2 = false");
                    //Console.WriteLine(c1.miCartuchera[i]);
                    break;
                }

                if(c1.ProbarElementos() == true)
                {
                    Console.WriteLine("c1 = true");
                   // Console.WriteLine(c1.miCartuchera[i]);
                }
                else
                {
                    Console.WriteLine("c1 = false");
                    //Console.WriteLine(c1.miCartuchera[i]);
                    break;
                }                
            }
            Console.ReadKey();
            Console.WriteLine("Imprimo c1.miCartuchera");

            for (int i = 0; i < c1.miCartuchera.Count; i++)
            {
                Console.WriteLine(c1.ProbarElementos());                
                Console.WriteLine(c1.miCartuchera[i]);
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Imprimo c2");

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(c2.ProbarElementos());
            }



            Console.ReadKey();
        }
    }
}
