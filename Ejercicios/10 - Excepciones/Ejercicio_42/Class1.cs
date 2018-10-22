using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class Class1
    {
        public static int Operar(int num1, int num2)
        {
            int resultado = 0;
            if(num2 == 0)
            {
                throw new DivideByZeroException("Intento dividir por 0");
            }
            else
            {
                resultado = num1 / num2;
            }
            return resultado;
        }


        public Class1()
        {
            try
            {
                Operar(1,0);
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        
            
        
    }          
            
}
    

