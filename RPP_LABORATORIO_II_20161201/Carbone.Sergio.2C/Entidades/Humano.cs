using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Humano : Animal
    {
        private string nombre;
        private string apellido;
        private static int piernas;

        #region

        static Humano()
        {
            piernas = 2;
        }

        public Humano(int velocidadMaxima) : base(piernas, velocidadMaxima)
        {
            
        }

        public Humano(string nombre, string apellido, int velocidadMaxima)
            : this(velocidadMaxima) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion
    }
}
