using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32_Libreria
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados, totalGoles;       


        #region Constructores

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;            
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
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


        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
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
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("\nNombre: {0}", this.Nombre);
            datos.AppendLine();
            datos.AppendFormat("Dni: {0}", this.dni);
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
