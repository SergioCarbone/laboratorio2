using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        #region Propiedad

        public int Antiguedad
        {
            get
            {
                return (DateTime.Now - fechaIngreso).Days;
            }
        }
        #endregion

        #region Metodos

        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder(base.ExponerDatos());
            datos.AppendFormat("\nAntiguedad: {0} dias", this.Antiguedad);
            return datos.ToString();
        }

        public Profesor(string nombre, string apellido, string documento)
            : base(nombre, apellido, documento)
        {

        }


        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }


        protected override bool ValidarDocumentacion(string doc)
        {
            return true;
        }
        #endregion
    }
}
