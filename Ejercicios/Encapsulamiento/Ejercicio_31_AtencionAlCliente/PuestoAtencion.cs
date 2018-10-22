using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31_AtencionAlCliente
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                return numeroActual++;                
            }
        }


        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }


        public bool Atender(Cliente cliente)
        {            
            Thread.Sleep(3000);         
            return true;
        }

        public enum Puesto
        {
            Caja1,
            Caja2,                
        }
    }
}
