using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            double altura, lado, radio;
            int opcion;
            string salir = "no";
            do
            {
                Console.WriteLine("1 - Calcular el area de un cuadrado.");
                Console.WriteLine("2 - Calcular el area de un triangulo.");
                Console.WriteLine("3 - Calcular el area de un circulo.");
                Console.WriteLine("4 - Salir");
                Console.WriteLine();
                Console.Write("Ingrese una de las opciones: ");
                if(int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch(opcion)
                    {
                        case 1:
                            Console.Write("Ingrese la medida del lado: ");
                            lado = int.Parse(Console.ReadLine());
                            Console.Write("El area del cuadrado es: {0}", CalculoDeArea.CalcularCuadraro(lado));
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Write("Ingrese la medida del lado: ");
                            lado = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese la altura: ");
                            altura = int.Parse(Console.ReadLine());
                            Console.Write("El area del triangulo es: {0}", CalculoDeArea.CalcularTriangulo(lado, altura));
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("Ingrese el radio del circulo: ");
                            radio = int.Parse(Console.ReadLine());
                            Console.Write("El area del circulo es: {0}", CalculoDeArea.CalcularCirculo(radio));
                            Console.ReadKey();
                            break;
                        case 4:
                            salir = "si";
                            break;
                    }
                }
                Console.Clear();
            } while (salir == "no");

            Console.ReadKey();
        }
    }
}
