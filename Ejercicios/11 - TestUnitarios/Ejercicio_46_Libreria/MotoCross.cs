using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_46_Libreria
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada { get { return this.cilindrada; } set { this.cilindrada = value; } }


        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }


        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());
            datos.AppendFormat("Cilindrada: {0}", this.Cilindrada);
            return datos.ToString();
        }


        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool retorno = false;
            if (m1.Escuderia == m2.Escuderia && m1.Numero == m1.Numero)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return (!(m1 == m2));
        }
    }
}
