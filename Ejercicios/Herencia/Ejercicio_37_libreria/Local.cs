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

        public float CostoLlamada
        {
            get
            {
                return this.costo;

            }


        }

        public Local(Llamada llamada,float costo)
            :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {


        }


        public Local(string origen,float duracion,string destino,float costo) 
            :base(duracion,destino,origen)
        {
            this.costo = costo;

        }

        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }
        public string  Mostrar()
        {
            StringBuilder datos = new StringBuilder(base.Mostrar());
            datos.AppendLine();
            datos.AppendFormat("El Costo es :{0}", this.costo);

            return datos.ToString();
        }

    }
}
