using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }


        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }


        private float CalcularCosto()
        {
            float valorFranja = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    valorFranja = 0.99f;
                    break;
                case Franja.Franja_2:
                    valorFranja = 1.25f;
                    break;
                case Franja.Franja_3:
                    valorFranja = 0.66f;
                    break;
            }

            return valorFranja * (float)this.duracion;
        }


        protected override string Mostrar()
        {
            StringBuilder datosLlamadaProvincial = new StringBuilder(base.Mostrar());
            datosLlamadaProvincial.AppendFormat("Costo llamada: {0}", this.CostoLlamada);
            datosLlamadaProvincial.AppendFormat("\n");
            datosLlamadaProvincial.AppendFormat("Franja horaria: {0}", franjaHoraria);
            return datosLlamadaProvincial.ToString();
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
