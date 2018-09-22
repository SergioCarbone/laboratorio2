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

        #region Propiedades
        public float Duracion { get { return this.duracion; } }
        public string NroOrigen { get { return this.nroOrigen; } }
        public string NroDestino { get { return this.nroDestino; } }
        #endregion

        #region Metodos
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }


        public string Mostrar()
        {
            StringBuilder datosLlamada = new StringBuilder();
            datosLlamada.AppendFormat("Numero origen: {0}", this.NroOrigen);
            datosLlamada.AppendLine();
            datosLlamada.AppendFormat("Numero destino: {0}", this.NroDestino);
            datosLlamada.AppendLine();
            datosLlamada.AppendFormat("Duracion: {0}", this.Duracion);
            return datosLlamada.ToString();
        }

        public static int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            return l1.duracion.CompareTo(l2.duracion);
        }
        #endregion

        #region Enumerado
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas,
        }
        #endregion
    }
}
