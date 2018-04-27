using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Moto : Cualidades
    {
        protected short cilindrada;

        public Moto(short cilindrada, short cantRuedas, short cantPuertas,
            Colores color) : base(cantRuedas, cantPuertas, color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
