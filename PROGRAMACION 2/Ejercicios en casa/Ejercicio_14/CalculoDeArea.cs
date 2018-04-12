using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadraro(double lado)
        {
            return Math.Pow(lado,2);
        }

        public static double CalcularTriangulo(double lado, double altura)
        {
            double resultado = ((lado * altura) / 2);
            return resultado;
        }

        public static double CalcularCirculo(double radio)
        {
            double resultado = Math.Pow(Math.PI * radio, 2);
            return resultado;
        }
    }
}
