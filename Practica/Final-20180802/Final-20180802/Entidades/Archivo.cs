using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Sobreescribir el método ToString para mostrar los valores de sus atributos.Utilizar String.Format.
    //Agregar el operador explicit para retornar el contenido del archivo.
    public class Archivo
    {
        private string nombre;
        private string contenido;

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


        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }


        public Archivo(string nombre, string contenido)
        {
            this.Nombre = nombre;
            this.Contenido = contenido;
        }


        public override string ToString()
        {
            return this.Mostrar(this);
        }


        protected string Mostrar(Archivo archivo)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat(string.Format("Nombre: {0}  \nContenido: {1}", archivo.Nombre, archivo.Contenido));

            return datos.ToString();
        }


        public static explicit operator string(Archivo a)
        {
            return a.Contenido.ToString();
        }

    }
}
