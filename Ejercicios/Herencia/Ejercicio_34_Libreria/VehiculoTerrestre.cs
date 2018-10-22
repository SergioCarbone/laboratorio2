using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34_Libreria
{
    public class VehiculoTerrestre
    {
        protected short cantidadRuedas, cantidadPuertas;        
        protected Colores color;

        public VehiculoTerrestre(short cantRuedas, short cantPuertas, Colores color)
        {
            this.cantidadPuertas = cantRuedas;
            this.cantidadPuertas = cantPuertas;
            this.color = color;
        }
    }
}
