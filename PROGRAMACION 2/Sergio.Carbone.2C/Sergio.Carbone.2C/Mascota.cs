using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergio.Carbone._2C
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

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

        protected virtual string DatosCompletos()
        {
            StringBuilder datosMascotas = new StringBuilder();
            datosMascotas.AppendFormat("Nombre: {0}", this.nombre);
            datosMascotas.AppendFormat("\n");
            datosMascotas.AppendFormat("Raza: {0}", this.raza);
           
            return datosMascotas.ToString();
        }

        protected virtual string Ficha()
        {
            return this.DatosCompletos();
        }

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
    }
}
