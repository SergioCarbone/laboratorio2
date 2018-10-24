using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static double Calcular(double num1, double num2, char operacion)
        {
            double resultado;
            switch(operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    if(Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        resultado = -0.1;
                    }
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                default:
                    resultado = -0.2;
                    break;
            }
            
            return resultado;
        }

        private static bool Validar(double numero)
        {
            bool retorno = false;
            if(numero != 0)
            {
                retorno = true;
            }
            return retorno;
        }

        public static void Mostrar(double numero)
        {
            Console.WriteLine("El resultado es: {0}", numero);            
        }
    }
}
