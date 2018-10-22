using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40_libreria
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino, nroOrigen;

        #region Propiedades        
        public abstract float CostoLlamada { get; }
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



        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;
            if(l1.Equals(l2))
            {
                if(l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen)
                {
                    retorno = true;
                }
            }
            return retorno;
        }


        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return (!(l1 == l2));
        }


        protected virtual string Mostrar()
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
