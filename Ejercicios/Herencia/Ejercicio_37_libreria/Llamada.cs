using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37_libreria
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino, nroOrigen;

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

        public string Mostrar()
        {
            StringBuilder datosLlamada = new StringBuilder();
            datosLlamada.AppendFormat("Nro origen: {0}", this.nroOrigen);
            datosLlamada.AppendLine();
            datosLlamada.AppendFormat("Nro destino: {0}", this.nroDestino);
            datosLlamada.AppendLine();
            datosLlamada.AppendFormat("Duracion: {0}", this.duracion);
            return datosLlamada.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (llamada1.duracion.CompareTo(llamada2.duracion));
        }


        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas,
        }
    }
}
