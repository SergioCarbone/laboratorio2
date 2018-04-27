using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantVueltas, short cantCompetidores) : this()
        {
            this.cantidadCompetidores = cantCompetidores;
            this.cantidadVueltas = cantVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder datosCompetencia = new StringBuilder();
            datosCompetencia.AppendFormat("Cantidad de competidores: {0}", this.competidores);
            datosCompetencia.AppendFormat("Cantidad de vueltas: {0}", this.cantidadVueltas);

            return datosCompetencia.ToString();
        }

        public static bool operator -(Competencia c, AutoF1 auto)
        {
            bool retorno = false;
            foreach (AutoF1 a in c.competidores)
            {
                if(a == auto)
                {
                    c.competidores.Remove(a);
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator +(Competencia c, AutoF1 auto)
        {
            bool retorno = false;
            int flag = 0;
            Random r = new Random();
            foreach (AutoF1 a in c.competidores)
            {
                if (a == auto)
                {
                    flag = 1;
                    break;
                }
                if(flag == 0)
                {
                    c.competidores.Add(auto);
                    auto.SetEnCompetencia();
                    auto.SetVueltasRestantes(c.cantidadVueltas);
                    auto.SetCantidadCombustible((short)r.Next(15, 100));
                }
            }
            return retorno;
        }


    }
}
