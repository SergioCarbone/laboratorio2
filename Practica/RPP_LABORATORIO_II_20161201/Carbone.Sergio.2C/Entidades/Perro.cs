using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Animal
    {
        private static int patas;
        private Razas raza;

        #region Enumerado
        public enum Razas
        {
            Galgo,
            OvejeroAleman,
        }
        #endregion

        #region Metodos
        static Perro()
        {
            patas = 4;
        }

        public Perro(int velocidadMaxima)
            : base(patas, velocidadMaxima)
        {

        }

        public Perro(Razas raza, int velocidadMaxima)
            : this(velocidadMaxima)
        {
            this.raza = raza;
        }


        public static bool operator ==(Perro p1, Perro p2)
        {
            bool retorno = false;
            if(p1.raza == p2.raza && p1.VelocidadMaxima == p2.VelocidadMaxima)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(Perro p1, Perro p2)
        {
            return (!(p1 == p2));
        }


        public string MostrarPerro()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());
            datos.AppendFormat("\nRaza: {0}", this.raza);
            return datos.ToString();
        }
        #endregion
    }
}
