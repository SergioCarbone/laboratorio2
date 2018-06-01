using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergio.Carbone._2C
{
    public class Grupo
    {
        private List<Mascota> listaManada;
        private string nombre;
        private TipoManada tipo;

        public TipoManada Tipo
        {
            set
            {
                this.tipo = TipoManada.Unica;
            }
        }

        
        private Grupo()
        {
            listaManada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo) : this(nombre)
        {
            this.tipo = tipo;
        }

        
        /// <summary>
        /// Este lo agregue para que desde el program me permita ver a c.mascotas
        /// </summary>
        public List<Mascota> mascotas
        {
            get
            {
                return listaManada;
            }
        }
        
        public static bool operator ==(Grupo grupo, Mascota mascota)
        {
            bool retorno = false;
            foreach (Mascota aux in grupo.listaManada)
            {
                if(aux == mascota)
                {
                    retorno = true;
                }               
            }
            return retorno;
        }

        public static bool operator !=(Grupo grupo, Mascota mascota)
        {
            bool retorno = false;
            foreach (Mascota aux in grupo.listaManada)
            {
                if (aux != mascota)
                {
                    retorno = true;
                }                
            }
            return retorno;
        }

        public static Grupo operator +(Grupo grupo, Mascota mascota)
        {
            if(!(grupo == mascota))
            {
                grupo.listaManada.Add(mascota);
            }
            return grupo;
        }

        public static Grupo operator -(Grupo grupo, Mascota mascota)
        {
            if(grupo == mascota)
            {
                grupo.listaManada.Remove(mascota);
            }
            return grupo;
        }

        public static implicit operator string(Grupo grupo)
        {
            return grupo.listaManada.ToString();
        }


        public enum TipoManada
        {
            Unica,
            Mixta,
        }
    }
}
