using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37_libreria
{
    public class Local : Llamada
    {
        protected float costo;

        #region Propiedades

        public float Costo { get { return CalcularCosto(); } }

        #endregion

        #region Metodos

        public Local(Llamada llamada, float costo) 
            : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo) 
            :base(duracion,destino,origen)
        {
            this.costo = costo;
        }


        public string Mostrar()
        {
            StringBuilder datosLlamada = new StringBuilder(base.Mostrar());
            datosLlamada.AppendLine();
            datosLlamada.AppendFormat("Costo llamada: {0}", this.Costo);
            return datosLlamada.ToString();
        }


        private float CalcularCosto()
        {
            return (this.duracion * this.costo);
        }
        #endregion
    }
}
