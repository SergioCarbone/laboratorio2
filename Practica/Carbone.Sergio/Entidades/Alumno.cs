using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;

        #region Propiedad

        public string AnioDivision
        {
            get
            {
                return string.Format("{0}º{1}", this.anio, this.division);
            }
        }
        #endregion

        #region Metodos

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder datos = new StringBuilder(base.ExponerDatos());
            datos.AppendFormat("\nAño y Division: {0}", this.AnioDivision);
            return datos.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool retorno = false;
            short cont = 0;
            if (doc.Length == 9)
            {
                for(int i = 0; i < doc.Length; i++)
                {
                    if (doc[i] == '-' && (i == 2 || i == 7))
                    {
                        cont++;
                    }
                    else if(!char.IsNumber(doc[i]))
                    {
                        break;
                    }
                }
                if(cont == 2)
                {
                    retorno = true;
                }
            }
            return retorno;
        }


        #endregion
    }
}
