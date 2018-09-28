using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime FechaIngreso;

        #region Propiedades

        public int Antiguedad
        {
            get
            {               
                return (DateTime.Now - FechaIngreso).Days;
            }
        }
        #endregion

        #region Metodos

        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder(base.ExponerDatos());
            datos.AppendFormat("\nAntiguedad: {0}", this.Antiguedad);
            return datos.ToString();
        }


        public Profesor(string nombre, string apellido, string documento)
            : base(nombre,apellido,documento)
        {

        }


        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            :this(nombre,apellido,documento)
        {
            this.FechaIngreso = fechaIngreso;
        }


        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            int cont = 0;
            if (doc.Length == 8)
            {
                for (int i = 0; i < doc.Length; i++)
                {
                    if (doc[i] == '-' && (i == 7 || i == 2))
                    {
                        cont++;
                    }
                    else if (!(doc[i] >= '0' && doc[i] <= '9'))
                    {
                        break;
                    }

                    if (cont == 2 && doc[i] == doc.Length - 1)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        #endregion
    }
}
