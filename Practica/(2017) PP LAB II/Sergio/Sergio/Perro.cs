using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergio
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        #region Propiedades

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa = value;
            }
        }
        #endregion

        #region Metodos

        public Perro(string nombre, string raza)
            : base(nombre, raza)
        {
            this.Edad = 0;
            this.esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : this(nombre, raza)
        {
            this.Edad = edad;
            this.EsAlfa = esAlfa;            
        }

        protected override string Ficha()
        {
            StringBuilder datos = new StringBuilder();
            if(EsAlfa == true)
            {
                datos.AppendFormat("{0}, es alfa de la manada, edad {1}", this.Nombre, this.Edad);
            }
            else
            {
                datos.AppendFormat("{0} cruza edad {1}", this.Nombre, this.Edad);
            }
            return datos.ToString();
        }


        public static bool operator ==(Perro p1, Perro p2)
        {
            bool retorno = false;
            if(p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1.Edad == p2.Edad)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return (!(p1 == p2));
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Perro)
            {
                if(this == (Perro)obj)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Ficha();
        }


        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }
        #endregion
    }
}
