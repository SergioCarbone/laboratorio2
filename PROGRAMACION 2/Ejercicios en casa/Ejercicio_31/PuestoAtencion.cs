using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_31
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }

        public enum Puesto
        {
            caja1,
            caja2,
        }


        public static int NumeroActual
        {
            get
            {
                return PuestoAtencion.numeroActual++;         
            }
        }

        public bool Atender(Cliente cliente)
        {
            Thread.Sleep(3000);
            return true;    
        }



    }
}
