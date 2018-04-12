using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07";
            int anio, mes, dia;
        
            FechaNacimiento nacimiento = new FechaNacimiento();

            Console.Write("Ingrese el año en que nacio: ");
            if(int.TryParse(Console.ReadLine(), out anio))
            {
                Console.Write("Ingrese el mes en que nacio: ");
                if(int.TryParse(Console.ReadLine(), out mes))
                {
                    Console.Write("Ingrese el dia en que nacio: ");
                    if(int.TryParse(Console.ReadLine(), out dia))
                    {
                        nacimiento.anio = anio;
                        nacimiento.mes = mes;
                        nacimiento.dia = dia;
                    }
                }
                Console.Write("Hace {0} dias que vive.", nacimiento.contarDias());
            }
            
            Console.ReadKey();
        }
    }
}
