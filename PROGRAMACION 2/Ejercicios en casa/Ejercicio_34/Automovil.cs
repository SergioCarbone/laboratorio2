using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Automovil : Cualidades
    {
        protected short cantidadMarchas;
        protected int cantidadPasajeros;

        public Automovil(short cantMarchas, int cantPasajeros, short cantRuedas, short cantPuertas,
            Colores color) : base(cantRuedas, cantPuertas, color)
        {
            this.cantidadPasajeros = cantPasajeros;
            this.cantidadMarchas = cantMarchas;
        }
    }
}
