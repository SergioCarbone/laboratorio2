using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   //Crear un constructor que reciba y asigne el/los atributos de la misma.
   //La clase debe ser abstracta.
   //Crear un método abstracto llamado MostrarArchivos que retorne void.
    public abstract class Almacenador
    {
        private int capacidad;

        public int Capacidad
        {
            get
            {
                return this.capacidad;
            }
            set
            {
                this.capacidad = value;
            }
        }

        public Almacenador()
        {

        }

        public Almacenador(int capacidad)
        {
            this.Capacidad = capacidad;
        }


        public abstract void MostrarArchivos();
    }
}
