using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            string marca;
            short cantRuedas, cilindrada, cantPuertas;
            int modelo = 2017;
            ConsoleColor color;
            VehiculoTerrestre honda;

            Console.Write("Ingrese la marca del vehiculo: ");
            marca = Console.ReadLine();

            Console.Write("Cantidad de ruedas: ");
            if(short.TryParse(Console.ReadLine(), out cantRuedas))
            {
                Console.Write("Cantidad de puertas: ");
                if (short.TryParse(Console.ReadLine(), out cantPuertas))
                {
                    Console.Write("Cilindrada: ");
                    if(short.TryParse(Console.ReadLine(), out cilindrada))
                    {
                        honda = new VehiculoTerrestre(cilindrada,cantPuertas,cantRuedas,Cualidades.Colores.Azul,marca,modelo);
                        Console.Write(honda.MostrarDatos());
                    }
                }
            }



            
            Console.ReadKey();
        }
    }
}
