using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergio.Carbone._2C
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;


        public Perro(string nombre, string raza)
            : base(nombre, raza)
        {
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : this(nombre, raza)
        {
            if (edad > 0)
            {
                this.edad = edad;
            }
            else
            {
                this.edad = 0;
            }
            if (esAlfa == true)
            {
                this.esAlfa = esAlfa;
            }
            else
            {
                this.esAlfa = false;
            }
        }

        protected override string Ficha()
        {
            StringBuilder datosPerro = new StringBuilder();
            if (this.esAlfa == true)
            {
                datosPerro.AppendFormat("{0} {1}, es alfa de la manada, edad {2}", base.Nombre,
                base.Raza, this.edad);
            }
            else
            {
                datosPerro.AppendFormat("{0} Cruza edad {1}", base.Nombre, this.edad);
            }
            return datosPerro.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool retorno = false;
            if (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.edad == p2.edad)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            bool retorno = false;
            if (p1.Nombre != p2.Nombre || p1.Raza != p2.Raza || p1.edad != p2.edad)
            {
                retorno = true;
            }
            return retorno;
        }

        public static explicit operator int(Perro perro)
        {
            return perro.edad;
        }

        public override bool Equals(object obj)
        {
            return obj is Perro;
        }

        public override string ToString()
        {
            return base.Ficha();
        }

    }
}
