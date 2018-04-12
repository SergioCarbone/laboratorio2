using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private int nota1;
        private int nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public string Mostrar()
        {
            StringBuilder datosAlumno = new StringBuilder();

            datosAlumno.AppendFormat("\nNombre: {0}", this.nombre);
            datosAlumno.AppendLine();
            datosAlumno.AppendFormat("Apellido: {0}", this.apellido);
            datosAlumno.AppendLine();
            datosAlumno.AppendFormat("Legajo: {0}", this.legajo);
            datosAlumno.AppendLine();
            datosAlumno.AppendFormat("Nota 1: {0}", this.nota1);
            datosAlumno.AppendLine();
            datosAlumno.AppendFormat("Nota 2: {0}", this.nota2);
            datosAlumno.AppendLine();

            if (this.notaFinal != -1)
            {
                datosAlumno.AppendFormat("Nota Final: {0}", this.notaFinal);
            }
            else
            {
                datosAlumno.Append("Alumno desaprobado!!.");
            }
            return datosAlumno.ToString();
        }

/*********************************************************************************************/

         public void Estudiar(int notaUno, int notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
            this.CalcularFinal();
        }

/*********************************************************************************************/

         public void CalcularFinal()
        {
            Random final = new Random();
            int notaFinal;

            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                notaFinal = final.Next(4, 10);
                this.notaFinal = notaFinal;
            }
            else
            {
                this.notaFinal = -1;
            }
        }
    }
}
