using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_61_Libreria
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public int Id
        {
            get
            {
                return this.id;
            }
        }

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

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }


        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }


        public Persona(int id, string nombre, string apellido)
            : this(nombre,apellido)
        {
            this.id = id;
        }


        private string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Id: {0}  Nombre y Apellido: {1} {2}", this.Id, this.Nombre, this.Apellido);
            return datos.ToString();            
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

    }
}
