using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static double Calcular(double numero1, double numero2, char operador)
        {
            double resultado = 0;
            if(operador == '/')
            {
                if(Validar(numero2))
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    resultado = -1;
                }
            }
            else if(operador == '+')
            {
                resultado = numero1 + numero2;
            }
            else if(operador == '-')
            {
                resultado = numero1 - numero2;
            }
            else if(operador == '*')
            {
                resultado = numero1 * numero2;
            }
            
            return resultado;
        }

        private static bool Validar(double numero2)
        {
            bool retorno = false;
            if(numero2 != 0)
            {
                retorno = true;
            }
            return retorno;
        }

        public static void Mostrar(double resultado)
        {
            Console.Write("El resultado es: {0}", resultado);
        }
    }
}
