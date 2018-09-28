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

        #region Propiedades

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
            StringBuilder datosCurso = new StringBuilder();
            datosCurso.AppendFormat("\nProfesor: {0}", c.profesor.ExponerDatos());
            datosCurso.AppendFormat("\nAnio y division: {0}", c.AnioDivision);
            datosCurso.AppendLine();
            foreach (Alumno al in c.alumnos)
            {
                datosCurso.AppendFormat(al.ExponerDatos());
                datosCurso.AppendLine();
            }
            return datosCurso.ToString();
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
