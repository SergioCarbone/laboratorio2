using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Camion : Cualidades
    {
        protected short cantidadMarchas;
        protected int pesoCarga;

        public Camion(short cantMarchas, int pesoCarga, short cantRuedas, short cantPuertas,
            Colores color) : base(cantRuedas,cantPuertas,color)
        {
            this.pesoCarga = pesoCarga;
            this.cantidadMarchas = cantMarchas;
        }

    }
}
