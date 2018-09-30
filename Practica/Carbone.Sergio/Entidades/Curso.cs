using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

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

        private Curso()
        {
            alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor)
            : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("\nProfesor {0}", c.profesor.ExponerDatos());            
            datos.AppendFormat("\nAño y Division: {0}", c.AnioDivision);
            datos.AppendLine();
            foreach (Alumno aux in c.alumnos)
            {
                datos.AppendLine();
                datos.AppendFormat(aux.ExponerDatos());
            }
            return datos.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            bool retorno = false;
            if(c.AnioDivision == a.AnioDivision)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return (!(c == a));
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if(c == a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }
        #endregion
    }
}
