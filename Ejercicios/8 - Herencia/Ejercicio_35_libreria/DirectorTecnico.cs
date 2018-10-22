using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35_libreria
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        #region Propiedades

        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
            }
        }

        #endregion

        #region Metodos
        private DirectorTecnico(string nombre, long dni) : base(dni, nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento, long dni) : this(nombre, dni)
        {
            this.FechaNacimiento = fechaNacimiento;
        }

        /// <summary>
        /// Muestra los datos del Director tecnico
        /// </summary>
        /// <returns>Retorna un stringBuilder</returns>
        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());
            datos.AppendLine();
            datos.AppendFormat("Fecha de nacimiento: {0}", this.FechaNacimiento);
            return datos.ToString();
        }

        /// <summary>
        /// Compara los datos de 2 dt
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns>true si son iguales, caso contrario false</returns>
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            bool retorno = false;
            if (d1.Nombre == d2.Nombre && d1.FechaNacimiento == d2.FechaNacimiento)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara los datos de 2 dt
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns>true si son distintos, caso contrario false</returns>
        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return (!(d1 == d2));
        }

        #endregion


    }
}
