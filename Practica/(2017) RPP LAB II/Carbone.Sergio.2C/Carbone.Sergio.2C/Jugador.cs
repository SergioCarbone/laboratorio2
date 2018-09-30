using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbone.Sergio._2C
{
    public class Jugador : Persona
    {
        private bool esCapitan;
        private int numero;

        #region Propiedades

        public bool EsCapitan
        {
            get
            {
                return this.esCapitan;
            }
            set
            {
                this.esCapitan = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        #endregion

        #region Metodos

        public Jugador(string nombre, string apellido)
            : base(nombre, apellido)
        {
            this.Numero = 0;
            this.EsCapitan = false;
        }

        public Jugador(string nombre, string apellido, int numero, bool capitan)
            : this(nombre,apellido)
        {
            this.Numero = numero;
            this.EsCapitan = capitan;
        }


        protected override string FichaTecnica()
        {
            string retorno;
            if(EsCapitan == true)
            {
                retorno = string.Format("{0}, capitan del equipo, camiseta número {1}", this.NombreCompteto(), this.Numero);
            }
            else
            {
                retorno = string.Format("{0} camiseta número {1}", this.NombreCompteto(), this.Numero);
            }
            return retorno;
        }


        public override string ToString()
        {
            return this.FichaTecnica();
        }


        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;
            if(j1.Numero == j2.Numero && j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return (!(j1 == j2));
        }


        //public override bool Equals(object obj)
        //{
        //    return base.GetType() == obj.GetType();
        //}


        public static explicit operator int(Jugador jugador)
        {
            return jugador.Numero;
        }
        #endregion
    }
}
