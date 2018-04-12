using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            string asterisco = "", salir = "n";
            int opcion;
            short cantidad;
            ConsoleColor colorPrincipal = Console.ForegroundColor;
            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Pintar en rojo.");
                Console.WriteLine("2 - Pintar en azul.");
                Console.WriteLine("3 - Cargar tinta roja.");
                Console.WriteLine("4 - Cargar tinta azul.");
                Console.WriteLine("5 - Salir.");
                Console.WriteLine("");
                Console.Write("Elija una de las opciones: ");

                if(int.TryParse(Console.ReadLine(),out opcion))
                {
                    switch(opcion)
                    {
                        case 1:
                            Console.Write("Cuanto quiere pintar: ");
                            if(short.TryParse(Console.ReadLine(),out cantidad))
                            {
                                if(boligrafoRojo.Pintar(cantidad, out asterisco))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(asterisco);
                                }
                                else
                                {
                                    Console.Write("No se pudo pintar la cantidad deseada, recargue tinta.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(asterisco);
                                }
                            }
                            break;
                        case 2:
                            Console.Write("Cuanto quiere pintar: ");
                            if (short.TryParse(Console.ReadLine(), out cantidad))
                            {
                                if (boligrafoAzul.Pintar(cantidad, out asterisco))
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(asterisco);
                                }
                                else
                                {
                                    Console.Write("No se pudo pintar la cantidad deseada, recargue tinta.");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(asterisco);                                    
                                }
                            }
                            break;
                        case 3:
                            Console.Write("Cuanto quiere recargar: ");
                            if (short.TryParse(Console.ReadLine(), out cantidad))
                            {
                                if(boligrafoRojo.GetTinta() < 100)
                                {
                                    boligrafoRojo.Recargar(cantidad);
                                }
                                else
                                {
                                    Console.Write("El boligrafo esta completo.");
                                }
                            }
                            break;
                        case 4:
                            Console.Write("Cuanto quiere recargar: ");
                            if (short.TryParse(Console.ReadLine(), out cantidad))
                            {
                                if (boligrafoAzul.GetTinta() < 100)
                                {
                                    boligrafoAzul.Recargar(cantidad);
                                }
                                else
                                {
                                    Console.Write("El boligrafo esta completo.");
                                }
                            }
                            break;
                        case 5:
                            salir = "s";
                            break;
                    }
                    Console.ForegroundColor = colorPrincipal;
                }
                Console.ReadKey();
            } while (salir == "n");
           

        }
    }
}
