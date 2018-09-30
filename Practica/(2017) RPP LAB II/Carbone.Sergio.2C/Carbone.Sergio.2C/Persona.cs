using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbone.Sergio._2C
{
    public abstract class Persona
    {
        private string nombre, apellido;

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        #endregion

        #region Metodos

        protected abstract string FichaTecnica();

        protected virtual string NombreCompteto()
        {
            return string.Format("{0} {1}", this.Nombre, this.Apellido);
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion
    }
}
