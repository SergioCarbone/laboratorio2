using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37_libreria
{
    public class Provincial : Llamada
    {
       public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }

        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }



        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja,llamada.Duracion, llamada.NroDestino)
        {

        }


        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            :base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }



        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = this.duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    retorno = this.duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    retorno = this.duracion * (float)0.66;
                    break;               
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder(base.Mostrar());
            datos.AppendLine();
            datos.AppendFormat("El Costo es :{0}", this.CostoLlamada);

            return datos.ToString();
        }
    }
}
