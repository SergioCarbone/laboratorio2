﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31_AtencionAlCliente
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;

            if(n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }


        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                bool retorno = this + value;
            }
        }


        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach (Cliente cli in n.clientes)
            {
                if (cli == c)
                {
                    retorno = true;
                }
            }
            return retorno;
        }


        public static bool operator !=(Negocio n, Cliente c)
        {
            return (!(n == c));
        }


        public static bool operator ~(Negocio n)
        {            
            return n.caja.Atender(n.Cliente);            
        }

    }
}
