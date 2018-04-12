using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado = 0;
            char respuesta ;
            
            do
            {
                Console.Write("Ingrese un numero: ");
                if(int.TryParse(Console.ReadLine(), out numero))
                {
                    resultado = resultado +  numero;
                }

                Console.Write("Desea continuar? s/n: ");
                respuesta = (char) Console.Read();

            } while (ValidarRespuesta.Validar_N(respuesta));

            Console.Write("La suma de los numeros ingresados es: {0}", resultado);
            Console.ReadKey();
        }
    }
}
