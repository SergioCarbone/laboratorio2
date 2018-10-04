using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los datos completos de la persona
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine();
            datos.AppendFormat("\nNombre: {0}", this.Nombre);
            datos.AppendFormat("\nApellido: {0}", this.Apellido);
            datos.AppendFormat("\nDni: {0}", this.Dni);
            datos.AppendFormat("\nEdad: {0}", this.Edad);

            return datos.ToString();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, string apellido ,int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract bool ValidarAptitud();
        #endregion
    }
}
