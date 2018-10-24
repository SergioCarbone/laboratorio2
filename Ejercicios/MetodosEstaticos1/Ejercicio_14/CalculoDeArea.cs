using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return (lado*lado);
        }

        public static double CalcularTriangulo(double lado, double altura)
        {
            return (lado*altura);
        }

        public static double CalcularCirculo(double radio)
        {
            double pi = 3.14;
            return Math.Pow((pi * radio), 2);
        }
    }
}
