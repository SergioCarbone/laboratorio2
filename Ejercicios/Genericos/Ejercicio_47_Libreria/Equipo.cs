using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47_Libreria
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public static bool operator ==(Equipo a, Equipo b)
        {
            bool retorno = false;
            if(a.nombre == b.nombre && a.fechaCreacion == b.fechaCreacion)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Equipo a, Equipo b)
        {
            return (!(a == b));
        }


        public string Ficha()
        {
            return string.Format("{0} fundado el {1}", this.nombre, this.fechaCreacion);
        }
    }
}
