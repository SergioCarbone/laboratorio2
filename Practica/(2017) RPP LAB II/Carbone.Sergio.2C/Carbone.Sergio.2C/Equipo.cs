using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbone.Sergio._2C
{
    public class Equipo
    {
        #region Enumerado
        public enum Deportes
        {
            Basquet,
            Futbol,
            Handball,
            Rugby,
        }
        #endregion

        private Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;

        #region Propiedad
        public Deportes Deporte
        {
            set
            {
                this.deporte = value;
            }
        }
        #endregion

        private Equipo()
        {
            this.deporte = Deportes.Futbol;
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt)
            : this()
        {
            this.nombre = nombre;
            this.dt = dt;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte)
            : this(nombre, dt)
        {
            this.deporte = deporte;
        }


        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;
            if(e.jugadores.Contains(j))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return (!(e == j));
        }


        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e != j)
            {
                e.jugadores.Add(j);
            }
            return e;
        }

        public static Equipo operator -(Equipo e, Jugador j)
        {
            if(e == j)
            {
                e.jugadores.Remove(j);
            }
            return e;
        }


        public static implicit operator string(Equipo e)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("**{0} {1}**", e.nombre, e.deporte);
            datos.AppendFormat("\nNomina de jugadores:");

            foreach (Jugador aux in e.jugadores)
            {
                datos.AppendLine();
                datos.AppendFormat(aux.ToString());
            }
            datos.AppendFormat("\nDirigidos por: {0}", e.dt.ToString());
            return datos.ToString();
        }
    }
}
