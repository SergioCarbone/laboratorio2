using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sergio
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private TipoManada tipo;

        #region Enumerado

        public enum TipoManada
        {
            Unica,
            Mixta,
        }
        #endregion

        #region Propiedad

        public TipoManada Tipo
        {
            set
            {
                this.tipo = value;
            }
        }
        #endregion

        #region Metodos

        private Grupo()
        {
            Tipo = TipoManada.Unica;
            manada = new List<Mascota>();
        }


        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo) : this(nombre)
        {            
            this.Tipo = tipo;
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            bool retorno = false;
            if(g.manada.Contains(m))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return (!(g == m));
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if(!(g == m))
            {
                g.manada.Add(m);
            }
            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if(g == m)
            {
                g.manada.Remove(m);
            }
            return g;
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("**{0} {1}**", g.nombre,g.tipo);
            datos.AppendFormat("\nIntegrantes: ");
            foreach (Mascota aux in g.manada)
            {
                datos.AppendLine();
                datos.AppendFormat(aux.ToString());                
            }
            return datos.ToString();
        }
        #endregion
    }
}
