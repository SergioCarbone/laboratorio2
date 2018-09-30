using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string documento;

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if(ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }
        #endregion

        #region Metodos

        protected abstract bool ValidarDocumentacion(string doc);

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        public virtual string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("\nNombre: {0}", this.nombre);
            datos.AppendFormat("\nApellido: {0}", this.apellido);
            datos.AppendFormat("\nDocumento: {0}", this.Documento);
            return datos.ToString();
        }


        #endregion
    }
}
