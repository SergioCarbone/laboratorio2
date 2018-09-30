using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergio
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        #region Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }
        #endregion

        #region Metodos

        protected virtual string DatosCompletos()
        {
            StringBuilder datos = new StringBuilder();            
            datos.AppendFormat("{0} {1}", this.Nombre, this.Raza);            
            return datos.ToString();
        }

        protected abstract string Ficha();

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion
    }
}
