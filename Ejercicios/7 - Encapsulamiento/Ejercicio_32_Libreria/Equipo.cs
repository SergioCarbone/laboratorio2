using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_32_Libreria
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        #region Constructores

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadJugadores = cantidad;
            this.nombre = nombre;
        }

        #endregion

        #region Operadores

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;
            if (e.jugadores.Count < e.cantidadJugadores)
            {
                if (!(e.jugadores.Contains(j)))
                {
                    e.jugadores.Add(j);
                    retorno = true;
                }
            }

            return retorno;
        }

        #endregion
    }
}
