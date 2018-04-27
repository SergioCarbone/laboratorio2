using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }


        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string MostrarDatos()
        {
            StringBuilder datosLlamada = new StringBuilder();
            datosLlamada.AppendFormat("Nro origen: {0}", this.nroOrigen);
            datosLlamada.AppendFormat("\n");
            datosLlamada.AppendFormat("Nro destino: {0}",this.nroDestino);
            datosLlamada.AppendFormat("\n");
            datosLlamada.AppendFormat("Duracion llamada: {0}", this.duracion);
            return datosLlamada.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
           int retorno = llamada1.duracion.CompareTo(llamada2.duracion);
           return retorno;
        }


        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas,
        }
    }
}
