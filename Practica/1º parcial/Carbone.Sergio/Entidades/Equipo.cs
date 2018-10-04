using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        #region Propiedades

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }


        #endregion


        #region Metodos

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }


        /// <summary>
        /// Davuelve los datos completos del equipo y de todos sus jugadores
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator string(Equipo e)
        {
            StringBuilder datos = new StringBuilder();
            
            foreach (Jugador j in e.jugadores)
            {
                datos.AppendFormat(j.Mostrar());
            }
            if(e.directorTecnico != null)
            {
                datos.AppendFormat(e.directorTecnico.Mostrar());
            }
            else
            {
                datos.AppendFormat("\nSin DT asignado");
            }
            return datos.ToString();
        }

        /// <summary>
        /// Se fija que un jugador se encuentre en el equipo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;
            if(e.jugadores.Contains(j))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Se fija que un jugador no se encuentre en el equipo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator !=(Equipo e, Jugador j)
        {
            return (!(e == j));
        }


        /// <summary>
        /// Si el jugador no se encuentra en el equipo la agrega a la lista
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e.jugadores.Count < Equipo.cantidadMaximaJugadores)
            {
                if((e != j) && j.ValidarAptitud())
                {
                    e.jugadores.Add(j);
                }
            }
            return e;
        }


        /// <summary>
        /// Valida que el equipo cumpla con los requisitos pedidos
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false, flagDef = false, flagCentral = false, flagDelant = false;
            int contArquero = 0;

            if(e.directorTecnico != null && e.jugadores.Count == Equipo.cantidadMaximaJugadores)
            {
                foreach (Jugador aux in e.jugadores)
                {
                    if(aux.Posicion == Posicion.Arquero)
                    {
                        contArquero++;
                    }
                    if(aux.Posicion == Posicion.Central)
                    {
                        flagCentral = true;
                    }
                    if(aux.Posicion == Posicion.Defensor)
                    {
                        flagDef = true;
                    }
                    if(aux.Posicion == Posicion.Delantero)
                    {
                        flagDelant = true;
                    }
                }

                if(contArquero == 1 && flagCentral == true && flagDef == true && flagDelant == true )
                {
                    retorno = true;
                }                
            }
            return retorno;
        }
        #endregion
    }
}
