using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergio.Carbone._2C
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        {
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            bool retorno = false;
            if(g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            bool retorno = false;
            if (g1.Nombre != g2.Nombre || g1.Raza != g2.Raza)
            {
                retorno = true;
            }
            return retorno;
        }

        protected override string Ficha()
        {
            StringBuilder datosPerro = new StringBuilder();
            
            datosPerro.AppendFormat("{0} {1}",this.Nombre, this.Raza);
            return datosPerro.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Gato;
        }

        public override string ToString()
        {
            return base.DatosCompletos();
        }

    }
}
