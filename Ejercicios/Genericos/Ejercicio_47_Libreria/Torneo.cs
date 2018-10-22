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
                int cantidad = equipos.Count, a, b;
                Random e1 = new Random();                
                a = e1.Next(0, cantidad);
                Thread.Sleep(500);                
                do
                {
                    Random e2 = new Random();
                    b = e2.Next(0, cantidad);
                } while (b == a);
                
                               
                return CalcularPartido(equipos[a], equipos[b]);
            }
        }


        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Nombre: {0}", this.nombre);
            datos.AppendLine();
            foreach (Equipo aux in equipos)
            {
                datos.AppendFormat("\n{0}", aux.Ficha());
            }
            datos.AppendLine();
            return datos.ToString();
        }

        public static bool operator ==(Torneo<T> a, Equipo b)
        {
            bool retorno = false;
            foreach (Equipo aux in a.equipos)
            {
                if(aux == b)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Torneo<T> a, Equipo b)
        {
            return (!(a == b));
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
            int r1, r2, marcador;
            if(t1 is EquipoFutbol)
            {
                marcador = 10;
            }
            else
            {
                marcador = 100;
            }

            Random resultado1 = new Random();                        
            r1 = resultado1.Next(0, marcador);
            Thread.Sleep(2000);
            Random resultado2 = new Random();
            r2 = resultado2.Next(0, marcador);

            return string.Format("{0} {1} - {2} {3}", t1.nombre, r1, t2.nombre, r2);            
        }

       
    }
}
