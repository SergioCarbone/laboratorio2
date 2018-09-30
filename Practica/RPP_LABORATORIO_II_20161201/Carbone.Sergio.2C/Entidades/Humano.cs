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

        #region Metodos

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


        public static bool operator ==(Humano h1, Humano h2)
        {
            bool retorno = false;
            if(h1.nombre == h2.nombre && h1.apellido == h2.apellido)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Humano h1, Humano h2)
        {
            return (!(h1 == h2));
        }


        public string MostrarHumano()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());
            datos.AppendFormat("\nNombre y Apellido: {0} {1}", this.nombre, this.apellido);
            return datos.ToString();
        }
        #endregion
    }
}
