using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Cualidades
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        public enum Colores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro,
        }

        public Cualidades(short cantRuedas, short cantPuertas, Colores color)
        {
            this.cantidadRuedas = cantRuedas;
            this.cantidadPuertas = cantPuertas;
            this.color = color;
        }
    }
}
