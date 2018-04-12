using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            int suma = 0, auxiliar, numero;
            int maximo = 0, minimo = 0;
            float promedio = 0;

            Console.Write("Cuantos numeros quiere ingresar: ");
            if(int.TryParse(Console.ReadLine(),out numero))
            {
                for (int i = 0; i < numero; i++)
                {
                    Console.Write("Ingrese un numero: ");
                    if (int.TryParse(Console.ReadLine(), out auxiliar))
                    {
                        suma = suma + auxiliar;
                        if (i == 0)
                        {
                            maximo = auxiliar;
                            minimo = auxiliar;
                        }
                        else
                        {
                            if (auxiliar > maximo)
                            {
                                maximo = auxiliar;
                            }
                            if (auxiliar < minimo)
                            {
                                minimo = auxiliar;
                            }
                        }
                    }
                }
                    promedio = (float) suma / numero;              
            }

            Console.WriteLine("El {0} fue el numero maximo", maximo);
            Console.WriteLine("El {0} fue el numero minimo", minimo);
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.ReadKey();
        }
    }
}
