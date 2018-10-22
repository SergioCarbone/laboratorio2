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
                Class3.MiClase3();
            }
            catch(DivideByZeroException a)
            {
                Console.WriteLine(a.Message);
            }
            catch(MiException e)
            {
                Exception a = e;
                Console.WriteLine(e.Message);
                while(a.InnerException != null)
                {                                   
                    Console.WriteLine(a.InnerException.Message);
                    a = a.InnerException;
                }
            }



            Console.ReadKey();
        }
    }
}
