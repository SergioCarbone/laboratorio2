using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_59_Libreria
{
    public class CentralitaException : Exception
    {
        private string nombre;
        private string nombreMetodo;

        #region Propiedades

        public string NombreClase
        {
            get
            {
                return this.nombre;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }


        #endregion

        #region

        public CentralitaException(string mensaje, string clase, string metodo)
            : this(mensaje, clase, metodo, null)
        {

        }


        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombre = clase;
            this.nombreMetodo = metodo;
        }
        #endregion
    }
}
