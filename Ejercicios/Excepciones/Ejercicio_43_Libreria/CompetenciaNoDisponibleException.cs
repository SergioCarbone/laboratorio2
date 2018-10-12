using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_43_Libreria
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        #region Propiedades

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
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

        #region Metodos

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : this(mensaje,clase,mensaje,null)
        {

        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo,Exception innerException)
            : base(mensaje,innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        #endregion
    }
}
