using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergio
{
    public class Gato : Mascota
    {      
        #region Metodos

        protected override string Ficha()
        {
            StringBuilder datos = new StringBuilder(base.DatosCompletos());                    
            return datos.ToString();
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
            return (!(g1 == g2));
        }

        public Gato(string nombre, string raza) : base(nombre, raza)
        {

        }

        public override string ToString()
        {
            return this.Ficha();
        }

        //public override bool Equals(object obj)
        //{

        //}
        #endregion
    }
}
