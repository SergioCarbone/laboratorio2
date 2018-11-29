using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Patente
    {
        public enum Tipo
        {
            Vieja, Mercosur
        }
        private Tipo tipoCodigo;
        private string codPatente;

        public Patente() { }

        public Patente(string codPatente, Tipo tipo)
        {
            this.CodigoPatente = codPatente;
            this.TipoCodigo = tipo;
        }

        public string CodigoPatente
        {
            get
            {
                return this.codPatente;
            }
            set
            {
                this.codPatente = value;
            }
        }

        public Tipo TipoCodigo
        {
            get
            {
                return this.tipoCodigo;
            }
            set
            {
                this.tipoCodigo = value;
            }
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("{0} {1}", this.CodigoPatente, this.tipoCodigo);
            //return this.CodigoPatente;
            return datos.ToString();
        }
    }
}
