using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_67
{
    public delegate void encargadoTiempo();
    public class Temporizador
    {
        private Thread hilo;
        private int intervalo;
        public event encargadoTiempo EventoTiempo;

        public bool Activo
        {
            get
            {
                return this.hilo.IsAlive;
            }
            set
            {
                hilo = new Thread(Corriendo);
                if (value == false && hilo != null && this.hilo.IsAlive == true)
                {
                    this.hilo.Abort();
                }
                else if (value == true && this.hilo.IsAlive == false && hilo != null)
                {                   
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
            set
            {
                this.intervalo = value;
            }
        }

        private void Corriendo()
        {
            do
            {                
                Thread.Sleep(this.intervalo);
                this.EventoTiempo();
            } while (this.Activo == true);
        }
    }
}
