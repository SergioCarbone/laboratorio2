using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34_Libreria
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantRuedas, short cantPuertas, Colores color,
            short cantMarchas, int pesoCarga) : base(cantRuedas,cantPuertas,color)
        {
            this.cantidadMarchas = cantMarchas;
            this.pesoCarga = pesoCarga;
        }

        public string Imprimir()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Peso: {0}", this.pesoCarga);
            return datos.ToString();
        }
    }

    
}
