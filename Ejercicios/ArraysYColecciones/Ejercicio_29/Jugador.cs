using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados, totalGoles;
        private float promedioGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
            this.promedioGoles = 0;
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

        public float GetPromedioGoles()
        {
            return this.promedioGoles = (this.totalGoles / (float)this.partidosJugados);            
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Nombre: {0}", this.nombre);
            datos.AppendLine();
            datos.AppendFormat("Dni: {0}", this.dni);
            datos.AppendLine();
            datos.AppendFormat("Total de partidos: {0}", this.partidosJugados);
            datos.AppendLine();
            datos.AppendFormat("Goles: {0}", this.totalGoles);
            datos.AppendLine();
            datos.AppendFormat("Promedio: {0}", this.GetPromedioGoles());

            return datos.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if(j1.dni == j2.dni)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return (!(j1 == j2));
        }

    }
}
