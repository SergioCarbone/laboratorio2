using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido, nombre, documento;

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
                if(this.ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("\nNombre: {0}", this.Nombre);
            datos.AppendFormat("\nApellido: {0}", this.Apellido);
            datos.AppendFormat("\nDocumento: {0}", this.Documento);
            return datos.ToString();
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        protected abstract bool ValidarDocumentacion(string doc);


        #endregion
    }
}
