using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        private static long dni;
        private static string nombre;
        private static int partidosJugados;
        private static float promedioGoles;
        private static int totalGoles;

        private Jugador()
        {
            Jugador.dni = 0;
            Jugador.nombre = "";
            Jugador.partidosJugados = 0;
            Jugador.promedioGoles = 0;
            Jugador.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            Jugador.nombre = nombre;
            Jugador.dni = dni;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni,nombre)
        {
            Jugador.totalGoles = totalGoles;
            Jugador.partidosJugados = totalPartidos;
        }

        public int Dni
        {
            get
            {
                return (int)Jugador.dni;
            }
        }

        public static bool operator != (Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if(j1.Dni != j2.Dni)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if (j1.Dni == j2.Dni)
            {
                retorno = true;
            }
            return retorno;
        }

        public float GetPromedioGoles()
        {
            return Jugador.totalGoles / Jugador.partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder datosJugaror = new StringBuilder();
            datosJugaror.AppendFormat("Nombre: {0}", Jugador.nombre);
            datosJugaror.AppendFormat("\n");
            datosJugaror.AppendFormat("Dni: {0}", Jugador.dni);
            datosJugaror.AppendFormat("\n");
            datosJugaror.AppendFormat("Partidos jugados: {0}", Jugador.partidosJugados);
            datosJugaror.AppendFormat("\n");
            datosJugaror.AppendFormat("Cantidad de goles: {0}", Jugador.totalGoles);
            datosJugaror.AppendFormat("\n");
            datosJugaror.AppendFormat("Promedio de gol: {0}", GetPromedioGoles());

            return datosJugaror.ToString();
        }
    }
}
