using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    public class Empleado
    {
        public string nombre;
        public int valorHora;
        public int antiguedad;
        public int cantidadHoras;


        public int ValorizarAnos(int antiguedad)
        {
            return antiguedad * 150;
        }

        public double CalcularSueldo(int valorHora, int cantHoras, int antiguedad)
        {
            double total, auxiliar;
            auxiliar = ValorizarAnos(antiguedad);

            total = valorHora * cantHoras;
            total += auxiliar;
            total = (total * 0.87);
            return total;
        }





    }
}
