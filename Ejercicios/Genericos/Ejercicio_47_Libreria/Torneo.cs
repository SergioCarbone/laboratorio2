using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47_Libreria
{
    public class Torneo<T> where T : Equipo
    {
        public List<T> equipos;
        public string nombre;

        public static bool operator ==(Torneo<T> a, string nombre)
        {
            bool retorno = false;
            foreach (Equipo aux in a.equipos)
            {
                if(aux.nombre == nombre)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Torneo<T> a, string nombre)
        {
            return (!(a == nombre));
        }
        

        public static Torneo<T> operator +(Torneo<T> a, T e)
        {            
            foreach (Equipo aux in a.equipos)
            {
                if(!(aux.nombre == e.nombre))
                {
                    a.equipos.Add(e);
                }
            }
            return a;
        }

        private string CalcularPartido(T t1, T t2)
        {
            Random resultado1 = new Random();
            Random resultado2 = new Random();
            string retorno = "";

            if((t1 is EquipoFutbol) && (t2 is EquipoFutbol))
            {
                retorno = string.Format("{0} {1} - {2} {3}", t1.nombre, resultado1.Next(0, 10),
                    t2.nombre, resultado2.Next(0, 10));
            }
            else
            {
                retorno = string.Format("{0} {1} - {2} {3}", t1.nombre, resultado1.Next(0, 100),
                    t2.nombre, resultado2.Next(0, 100));
            }

            return retorno;
        }
    }
}
