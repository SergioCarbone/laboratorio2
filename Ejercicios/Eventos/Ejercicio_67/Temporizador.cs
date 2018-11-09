using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_67
{
    sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get
            {
                return this.hilo.IsAlive;
            }
            set
            {
                if(this.hilo.IsAlive == false || hilo != null)
                {
                    this.hilo.Abort();
                }
                else
                {
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                }
            }
        }

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
        }

        private void Corriendo()
        {

        }
    }
}
