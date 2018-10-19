using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_47_Libreria
{
    public class Torneo<T> where T : Equipo
    {
        public List<T> equipos;
        public string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            equipos = new List<T>();
        }


        public string JugarPartido
        {
            get
            {
                int cantidad = equipos.Count;
                Random e1 = new Random();
                int a, b;

                a = e1.Next(0, cantidad);
                Thread.Sleep(500);
                Random e2 = new Random();
                                   
                b = e2.Next(0, cantidad);
                               
                return CalcularPartido(equipos[a], equipos[b]);
            }
        }


        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Nombre: {0}", this.nombre);
            foreach (Equipo aux in equipos)
            {
                datos.AppendFormat("\n{0}", aux.Ficha());
            }            
            return datos.ToString();
        }

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
            if (!(a.equipos.Contains(e)))
            {
                a.equipos.Add(e);
            }
            return a;
        }

        private string CalcularPartido(T t1, T t2)
        {
            Random resultado1 = new Random();
            string retorno = "";
            int r1, r2;
            r1 = resultado1.Next(0, 10);
            Thread.Sleep(2000);
            Random resultado2 = new Random();
            r2 = resultado2.Next(0, 10);

            retorno = string.Format("\n{0} {1} - {2} {3}", t1.nombre, r1, t2.nombre, r2);


            return retorno;
        }
    }
}
