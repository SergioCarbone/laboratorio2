using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PasajeMicro : Pasaje
    {
        private Servicio tipoServicio;

        public override float PrecioFinal
        {
            get
            {
                return CalcularPrecio(tipoServicio);
            }
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder(base.Mostrar());
            datos.AppendLine();
            datos.AppendFormat("Precio final: {0}", this.PrecioFinal);
            return datos.ToString();
        }

        public PasajeMicro()
        {

        }

        public PasajeMicro(string origen, string destino, Pasajero pasajero, float precio,
            DateTime fecha, Servicio tipoServicio)
            : base(origen, destino, pasajero, precio, fecha)
        {
            this.tipoServicio = tipoServicio;
        }


        private float CalcularPrecio(Servicio tipo)
        {
            float retorno = 0;
            if (this.tipoServicio == Servicio.SemiCama)
            {
                retorno = this.Precio * (float)1.1;
            }
            else if (this.tipoServicio == Servicio.Ejecutivo)
            {
                retorno = this.Precio * (float)1.2;
            }
            
            return retorno;
        }
    }
}
