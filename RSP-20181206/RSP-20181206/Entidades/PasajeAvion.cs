using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PasajeAvion : Pasaje
    {
        private int cantidadEscalas;

        public override float PrecioFinal
        {
            get
            {
                return CalcularPrecio(this.cantidadEscalas);
            }
        }


        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder(base.Mostrar());
            datos.AppendLine();
            datos.AppendFormat("Precio final: {0}", this.PrecioFinal);
            return datos.ToString();
        }

        public PasajeAvion()
        {

        }

        public PasajeAvion(string origen, string destino, Pasajero pasajero, float precio,
            DateTime fecha, int cantidadEscalas)
            : base(origen, destino, pasajero, precio, fecha)
        {
            this.cantidadEscalas = cantidadEscalas;
        }


        private float CalcularPrecio(int cantEscalas)
        {
            float retorno;
            if(cantidadEscalas == 1)
            {
                retorno = this.Precio * (float)0.9;
            }
            else if(cantidadEscalas == 2)
            {
                retorno = this.Precio * (float)0.8;
            }
            else
            {
                retorno = this.Precio * (float)0.7;
            }
            return retorno;
        }

    }
}
