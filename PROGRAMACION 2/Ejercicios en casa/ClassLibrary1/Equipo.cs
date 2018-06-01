using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;


        public Equipo() { }

        public Equipo(string nombre, DateTime fecha) : this()
        {
            this.nombre = nombre;
            fechaCreacion = fecha;
        }

        public static bool operator ==(Equipo a, Equipo b)
        {
            bool retorno = false;

            if (a.fechaCreacion == b.fechaCreacion && a.nombre == b.nombre)
            {
                retorno = true;
            }
            return retorno;
        }


        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a == b);
        }


        public string Ficha()
        {
            StringBuilder datosEquipo = new StringBuilder();
            datosEquipo.AppendFormat("{0} formado el {1}", this.nombre, this.fechaCreacion);            
            return datosEquipo.ToString();
        }


    }
}
