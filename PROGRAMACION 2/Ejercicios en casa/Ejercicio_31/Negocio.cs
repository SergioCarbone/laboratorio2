using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        
        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                bool respuesta = this + value;
            }
        }
        

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio negocio, Cliente cliente)
        {
            bool retorno = false;
            foreach (Cliente cte in negocio.clientes)
            {                
                if (cte == cliente)
                {                    
                    retorno = true;
                    break;
                }
            }

            if (retorno == true)
            {
                negocio.clientes.Enqueue(cliente);
            }
            return retorno;
        }

        public static bool operator ==(Negocio negocio, Cliente cliente)
        {
            bool retorno = false;
            foreach (Cliente cte in negocio.clientes)
            {
                if (cte == cliente)
                {
                    retorno = true;
                    break;
                }
            }
            
            return retorno;
        }

        public static bool operator !=(Negocio negocio, Cliente cliente)
        {
            bool retorno = false;
            int flag = 0;
            foreach (Cliente cte in negocio.clientes)
            {
                if (cte == cliente)
                {
                    flag = 1;
                    break;
                }
                if (flag == 0)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator ~(Negocio negocio)
        {
            bool retorno = retorno = negocio.caja.Atender(negocio.Cliente);


            return retorno;
        }
    }
}
