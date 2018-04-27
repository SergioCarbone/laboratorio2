using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {   
                return this.costo * this.duracion;
            }
        }

        private float CalcularCosto()
        {
            return 0;
        }

        public Local(Llamada llamada, float costo) 
            : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) 
            : base(duracion,destino,origen)
        {
            this.costo = costo;
        }


        public string MostrarDatos()
        {
            StringBuilder datosLlamadaLocal = new StringBuilder();
            datosLlamadaLocal.AppendFormat("Nro origen: {0}", this.nroOrigen);
            datosLlamadaLocal.AppendFormat("\n");
            datosLlamadaLocal.AppendFormat("Nro destino: {0}", this.nroDestino);
            datosLlamadaLocal.AppendFormat("\n");
            datosLlamadaLocal.AppendFormat("Duracion llamada: {0}", this.duracion);
            datosLlamadaLocal.AppendFormat("\n");
            datosLlamadaLocal.AppendFormat("Costo llamada: {0}", this.CostoLlamada);
            return datosLlamadaLocal.ToString();
        }
    }
}
