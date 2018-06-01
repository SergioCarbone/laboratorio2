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

        public override float CostoLlamada
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
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }


        protected override string Mostrar()
        {
            StringBuilder datosLlamadaLocal = new StringBuilder(base.Mostrar());
            datosLlamadaLocal.AppendFormat("Costo llamada: {0}", this.CostoLlamada);

            return datosLlamadaLocal.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
