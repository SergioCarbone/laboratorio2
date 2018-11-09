using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64_Libreria
{
    public class Caja
    {
        private List<string> filaClientes;

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public void AtenderClientes()
        {            
            foreach (string aux in FilaClientes)
            {
                Console.WriteLine(string.Format("Atendiendo a: {0} en {1}", aux,Thread.CurrentThread.Name));
                Thread.Sleep(2000);
            }
        }
        
        public Caja()
        {
            filaClientes = new List<string>();
        }
    }
}
