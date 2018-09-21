using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_34_Libreria;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion cam1 = new Camion(8, 2, Colores.Rojo, 6, 1500);

            Console.WriteLine(cam1.Imprimir());
            Console.ReadKey();
        }
    }
}
