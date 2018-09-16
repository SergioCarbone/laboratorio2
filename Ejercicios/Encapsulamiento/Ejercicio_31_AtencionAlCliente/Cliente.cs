using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31_AtencionAlCliente
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
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
            Nombre = nombre;
        }


        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retorno = false;
            if(c1.numero == c2.numero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return (!(c1 == c2));
        }
    }
}
