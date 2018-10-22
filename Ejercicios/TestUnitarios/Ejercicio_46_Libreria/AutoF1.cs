using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_46_Libreria
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

        #region Metodos

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        /// <summary>
        /// Muestra los datos del auto
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder datosAuto = new StringBuilder(base.MostrarDatos());
            datosAuto.AppendLine();
            datosAuto.AppendFormat("Caballos de fuerza: {0}", this.CaballosDeFuerza);

            return datosAuto.ToString();
        }

        /// <summary>
        /// Compara el numero y la escuderia de dos autos
        /// </summary>
        /// <param name="a1">auto a comparar</param>
        /// <param name="a2">auto a comparar</param>
        /// <returns>True si los autos son iguales, caso contrario false</returns>
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if (a1.Escuderia == a2.Escuderia && a1.Numero == a2.Numero)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara el numero y la escuderia de dos autos
        /// </summary>
        /// <param name="a1">auto a comparar</param>
        /// <param name="a2">auto a comparar</param>
        /// <returns>True si los autos son distintos, caso contrario false</returns>
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return (!(a1 == a2));
        }

        #endregion
    }
}
