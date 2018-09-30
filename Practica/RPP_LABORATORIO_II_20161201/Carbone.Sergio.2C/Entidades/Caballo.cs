using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo : Animal
    {
        private string nombre;
        private static int patas;

        #region Metodos

        static Caballo()
        {
            patas = 4;
        }

        public Caballo(string nombre, int velocidadMaxima)
            : base(patas, velocidadMaxima)
        {
            this.nombre = nombre;
        }

        public string MostrarCaballo()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());
            datos.AppendFormat("\nNombre: {0}", this.nombre);
            return datos.ToString();
        }

        public static bool operator ==(Caballo c1, Caballo c2)
        {
            bool retorno = false;
            if(c1.nombre == c2.nombre)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(Caballo c1, Caballo c2)
        {
            return (!(c1 == c2));
        }


        #endregion
    }
}
