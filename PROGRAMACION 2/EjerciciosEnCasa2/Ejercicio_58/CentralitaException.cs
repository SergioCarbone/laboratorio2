using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaAbstracta
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public Exception ExcepcionInterna
        {
            get
            {
                return InnerException;
            }
        }

        public string NombreClase
        {
            get
            {
                return nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return nombreMetodo;
            }
        }

        public CentralitaException(string mensaje, string clase, string metodo)
            : this(mensaje, clase, metodo, null)
        {
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }
    }
}
