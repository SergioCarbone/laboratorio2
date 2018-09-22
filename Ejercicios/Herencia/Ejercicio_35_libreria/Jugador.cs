using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35_libreria
{
    public class Jugador : Persona
    {
        private int dni;
        private string nombre;
        private int partidosJugados, totalGoles;


        #region Constructores

        private Jugador(long dni, string nombre) : base(dni, nombre)
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this((long)dni, nombre)
        {

        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        #endregion

        #region Propiedades
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return (this.totalGoles / (float)this.partidosJugados);
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());
            datos.AppendLine();
            datos.AppendFormat("Total de partidos: {0}", this.PartidosJugados);
            datos.AppendLine();
            datos.AppendFormat("Goles: {0}", this.TotalGoles);
            datos.AppendLine();
            datos.AppendFormat("Promedio: {0}", this.PromedioGoles);

            return datos.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if (j1.dni == j2.dni)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return (!(j1 == j2));
        }

        #endregion
    }
}
