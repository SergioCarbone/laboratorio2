using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {           
            try
            {
                Class2 ej = new Class2();
                ej.Operacion();
            }
            catch (MiException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }

        
        
    }
}
