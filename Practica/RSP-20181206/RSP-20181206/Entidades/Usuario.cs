using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombre;
        private string clave;

        public Usuario(string nombre, string clave)
        {
            this.nombre = nombre;
            this.Clave = clave;
        }

        public string Nombre { get => nombre; }
        public string Clave
        {
            get
            {
                return clave;
            }
            set
            {
                //ALUMNO
                clave = value;
            }
        }
    }
}
