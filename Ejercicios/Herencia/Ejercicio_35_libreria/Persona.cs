using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35_libreria
{
    public class Persona
    {
        private long dni;
        private string nombre;

        #region Propiedades
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        #endregion

        #region Metodos

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public Persona(long dni, string nombre) : this(nombre)
        {
            this.Dni = dni;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Nombre: {0}", this.Nombre);
            datos.AppendLine();
            datos.AppendFormat("Dni: {0}", this.Dni);
            return datos.ToString();
        }
        #endregion
    }
}
