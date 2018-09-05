using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    public class Calcular
    {
        public static double CalcularHorasTrabajadas(float valorHora, int cantHoras, int Ant)
        {
            int valorAntiguedad = Ant * 150;            

            return (valorAntiguedad + (valorHora * cantHoras));

        }
    }
}
