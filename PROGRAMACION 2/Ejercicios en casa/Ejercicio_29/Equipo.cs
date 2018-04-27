using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo equipo, Jugador jugador)
        {
            bool retorno = false;
            int flag = 0;

            foreach (Jugador jug in equipo.jugadores)
            {
                if(jug == jugador)
                {
                    flag = 1;
                }
            }
            if(flag == 0 && equipo.jugadores.Capacity < equipo.cantidadJugadores )
            {
                equipo.jugadores.Add(jugador);
                retorno = true;
            }
            return retorno;
        }
    }
}
