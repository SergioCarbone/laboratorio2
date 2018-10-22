using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1, nota2;
        private float notaFinal;
        public string nombre, apellido;
        public int legajo;


        /// <summary>
        /// 
        /// </summary>
        private void CalcularFinal()
        {
            Random aux = new Random();
            if (nota1 >= 4 && nota2 >= 4)
            {
                this.notaFinal = aux.Next(4, 11);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nota1"></param>
        /// <param name="nota2"></param>
        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            CalcularFinal();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder datosAlumno = new StringBuilder();
            datosAlumno.AppendFormat("Nombre del alumno: {0}", this.nombre);
            datosAlumno.AppendFormat("\nApellido del alumno: {0}", this.apellido);
            datosAlumno.AppendFormat("\nLegajo: {0}", this.legajo);
            if (notaFinal != -1)
            {
                datosAlumno.AppendFormat("\nNota final: {0}", this.notaFinal);
            }
            else
            {
                datosAlumno.AppendFormat("\nAlumno desaprobado");
            }
            return datosAlumno.ToString();
        }
    }
}
