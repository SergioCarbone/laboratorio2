using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Cliente
    {
        private string nombre;
        private int numero;


        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        public int Numero
        {
            get
            {
                return this.numero;
            }
        }


        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }


        public static bool operator == (Cliente cte1, Cliente cte2)
        {
            bool retorno = false;
            if (cte1.Numero == cte2.Numero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Cliente cte1, Cliente cte2)
        {
            bool retorno = false;
            if (cte1.Numero != cte2.Numero)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
