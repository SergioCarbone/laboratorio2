using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_31_AtencionAlCliente;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_31";
            Console.ForegroundColor = ConsoleColor.Green;

            Negocio coto = new Negocio("Coto");
            Cliente c1 = new Cliente(1, "sergio");
            Cliente c2 = new Cliente(2, "patricia");
            Cliente c3 = new Cliente(3, "diego");
            Cliente c4 = new Cliente(2, "carla");

            if(coto + c1)
            {                
                if(coto + c2)
                {                    
                    if (coto + c3)
                    {
                       if(coto + c4)
                       {

                       }
                       else
                       {
                            Console.WriteLine("No se pudo cargar un cliente");
                       }
                    }
                    else
                    {
                        Console.WriteLine("No se pudo cargar un cliente");
                    }
                }
                else
                {
                    Console.WriteLine("No se pudo cargar un cliente");
                }
            }
            else
            {
                Console.WriteLine("No se pudo cargar un cliente");
            }

            for (int i = 0; i < 4; i++)
            {
                if (~(coto))
                {
                    Console.WriteLine("Atendiendo.....");
                }
                else
                {
                    Console.WriteLine("Error.....");
                }
            }
            Console.ReadKey();
        }
    }
}
