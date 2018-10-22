using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34_Libreria
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;        

        public Moto(short cantPuertas, short cantRuedas, Colores color, short cilindrada)
            : base(cantRuedas, cantPuertas,color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
