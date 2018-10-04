using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        #region Propiedad

        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }
        #endregion

        #region Metodos
         /// <summary>
         /// Carga los datos correspondientes a la clase y llama a la base
         /// </summary>
         /// <param name="nombre"></param>
         /// <param name="apellido"></param>
         /// <param name="edad"></param>
         /// <param name="dni"></param>
         /// <param name="añosExperiencia"></param>
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia)
            : base(nombre,apellido,edad,dni)
        {
            this.AñosExperiencia = añosExperiencia;
        }


        /// <summary>
        /// Muestra los datos Completos del DT
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder(base.Mostrar());
            datos.AppendLine();
            datos.AppendFormat("\nAños de experiencia: {0}", this.AñosExperiencia);
            return datos.ToString();
        }


        /// <summary>
        /// Valida que la experiencia este dentro de un rango especifico
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(this.AñosExperiencia >= 2 && this.AñosExperiencia < 65)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
