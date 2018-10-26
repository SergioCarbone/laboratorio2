using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_54_IO;

namespace Ejercicio_54
{
    class Program
    {
        static void Main(string[] args)
        {
            string fecha; //= DateTime.Now.Year.ToString();
            //fecha += DateTime.Now.Month.ToString();
            //fecha += DateTime.Now.Day.ToString();
            //fecha += "-";
            //fecha += DateTime.Now.Hour.ToString();
            //fecha += DateTime.Now.Minute.ToString();
            fecha = DateTime.Now.ToString("yyyyMMdd-HHmm");
            try
            {
                Class3.MiClase3();
            }
            catch (DivideByZeroException a)
            {
                ArchivoTexto.Guardar(fecha, a.Message.ToString());
            }
            catch (MiException e)
            {
                Exception a = e;
                ArchivoTexto.Guardar(fecha, a.Message.ToString());
                while (a.InnerException != null)
                {
                    ArchivoTexto.Guardar(fecha, a.Message.ToString());
                    a = a.InnerException;
                }
            }

            Console.WriteLine(ArchivoTexto.Leer(fecha));
            Console.ReadKey();
        }
    }
}
