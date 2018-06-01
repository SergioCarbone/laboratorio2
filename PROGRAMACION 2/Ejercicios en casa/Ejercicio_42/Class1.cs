using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class Class1 
    {
        public Class1()
        {
            try
            {
                Dividir(8, 0);
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }
        }

        public Class1(int i)
        {
            try
            {
                new Class1();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("error", e);
            }
        }

        
        public static double Dividir(int a, int b)
        {
            double resultado = 0;
            try
            {
                resultado = a / b;
            }
            catch (DivideByZeroException error)
            {
                throw error;
            }
            return resultado;
        }


    }
}
