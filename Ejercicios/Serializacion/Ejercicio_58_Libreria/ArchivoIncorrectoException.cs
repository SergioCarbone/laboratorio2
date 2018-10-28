using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_58_Libreria
{
    public class ArchivoIncorrectoException : Exception
    {
        private string mensaje;

        public string Mensaje
        {
            get
            {
                return this.mensaje;
            }
            set
            {
                this.mensaje = value;
            }
        }

        public ArchivoIncorrectoException(string mensaje) : this(mensaje,null)
        {
            this.Mensaje = mensaje;
        }

        public ArchivoIncorrectoException(string mensaje, Exception innerException ) : base(mensaje,innerException)        
        {
            
        }      
    }
}
