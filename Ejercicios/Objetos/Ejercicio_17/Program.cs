using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lapicera;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_17";
            Console.ForegroundColor = ConsoleColor.Green;

            Boligrafo azul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);
            char salir = 'n';
            string dibujo = "";
            int opcion, cantTinta;

            do
            {                
                Console.WriteLine("1- Escribir en rojo.");
                Console.WriteLine("2- Escribir en azul");
                Console.WriteLine("3- Recargar");
                Console.WriteLine("4- Salir");
                Console.WriteLine();
                Console.Write("Ingrese una opcion: ");
                if ((int.TryParse(Console.ReadLine(), out opcion)) && opcion >= 1 || opcion <= 4)
                {                    
                    switch(opcion)
                    {                                  
                        case 1:
                            Console.Write("Cuanto desea escribir: ");
                            if(int.TryParse(Console.ReadLine(), out cantTinta))
                            {
                                if(rojo.Pintar(cantTinta, out dibujo))
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(dibujo);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("No se pudo pintar por completo, recargue tinta.");
                                    Console.Write("Solo le quedaban: ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(dibujo);
                                    Console.ReadKey();
                                }
                            }
                            break;
                        case 2:
                            Console.Write("Cuanto desea escribir: ");
                            if (int.TryParse(Console.ReadLine(), out cantTinta))
                            {
                                if (azul.Pintar(cantTinta, out dibujo))
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(dibujo);
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("No se pudo pintar por completo, recargue tinta.");
                                    Console.Write("Solo le quedaban: ");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(dibujo);
                                    Console.ReadKey();
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("1- Recargar tinta roja.");
                            Console.WriteLine("2- Recargar tinta azul.");
                            Console.WriteLine();
                            Console.Write("Elija una opcion: ");
                            if(int.TryParse(Console.ReadLine(), out opcion))
                            {
                                switch(opcion)
                                {
                                    case 1:
                                        rojo.Recargar();
                                        Console.Clear();
                                        Console.Write("Se recargo la tinta roja");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        azul.Recargar();
                                        Console.Clear();
                                        Console.Write("Se recargo la tinta azul ");
                                        Console.ReadKey();
                                        break;
                                    default:
                                        Console.WriteLine("Error.");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            break;
                        case 4:
                            salir = 's';
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error elija entre las opciones.");
                    Console.ReadKey();
                }                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
            } while (salir != 's');            
        }
    }
}
