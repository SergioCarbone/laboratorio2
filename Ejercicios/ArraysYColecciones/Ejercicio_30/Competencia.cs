using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class Competencia
    {
        private short cantidadCompetidores, cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatosCompetencia()
        {            
            StringBuilder datosCompetencia = new StringBuilder();
            datosCompetencia.AppendFormat("Cantidad de competidores: {0}", this.cantidadCompetidores);
            datosCompetencia.AppendFormat("\nCantidad de vueltas: {0}", this.cantidadVueltas);
            datosCompetencia.AppendLine();
            datosCompetencia.AppendLine();
            foreach (AutoF1 auto in competidores)
            {
                datosCompetencia.Append(auto.MostrarDatos());
                datosCompetencia.AppendLine();
                datosCompetencia.AppendLine();
            }
            return datosCompetencia.ToString();
        }


        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if(c.competidores.Count < c.cantidadCompetidores)
            {
                if(c != a)
                {
                    AgregarCompetidor(c, a);                    
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if(c == a)
            {
                c.competidores.Remove(a);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if(c.competidores.Contains(a))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return (!(c == a));
        }


        private static void AgregarCompetidor(Competencia c,AutoF1 a)
        {
            Random combustible = new Random();
            a.SetVueltas(c.cantidadVueltas);
            a.SetEnCompetencia(true);
            a.SetCantidadCombustible((short)combustible.Next(15, 100));
            c.competidores.Add(a);            
        }

    }
}
