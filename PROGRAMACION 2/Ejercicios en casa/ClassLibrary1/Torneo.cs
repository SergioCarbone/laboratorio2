using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Torneo <T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;


        public Torneo() { equipos = new List<T>(); }


        public Torneo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                int a,b;
                Random indice1 = new Random();
                a = indice1.Next(0, equipos.Count);
                do
                {
                    System.Threading.Thread.Sleep(10);
                    Random indice2 = new Random();
                    b = indice2.Next(0, equipos.Count);

                } while (a == b);               
                
                return CalcularPartido(equipos[a],equipos[b]);
            }
        }

        
        public static bool operator ==(Torneo<T> torneo, Equipo a)
        {
            bool retorno = false;
            foreach (Equipo aux in torneo.equipos)
            {
                if (aux == a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo a)
        {
            return !(torneo == a);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T a)
        {
            if (torneo != a)
            {
                torneo.equipos.Add(a);
            }
            
            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder datosTorneo = new StringBuilder();
            datosTorneo.AppendFormat("Torneo: {0}\n", this.nombre);
            datosTorneo.AppendFormat("\n");

            foreach (Equipo item in equipos)
            {                
                datosTorneo.AppendLine(item.Ficha());                
            }
            return datosTorneo.ToString();
        }


        private string CalcularPartido(T equipoA, T equipoB)
        {
            string retorno = "Error";
            if (equipoA is Equipo && equipoB is Equipo)
            {
                StringBuilder datosResultado = new StringBuilder();
                Random resultado1 = new Random();
                System.Threading.Thread.Sleep(10);
                Random resultado2 = new Random();

                datosResultado.AppendFormat("{0}: {1} - {2}: {3}\n", equipoA.nombre, resultado1.Next(0,10), 
                    equipoB.nombre, resultado2.Next(0,10));

                retorno = datosResultado.ToString();
            }

            return retorno;
        }
    }
}
