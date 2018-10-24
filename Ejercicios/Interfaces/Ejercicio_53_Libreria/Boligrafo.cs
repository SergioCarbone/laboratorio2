using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53_Libreria
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        #region Propiedades

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }
        #endregion

        #region Metodos

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.Color = color;
            this.UnidadesDeEscritura = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper retorno = new EscrituraWrapper(texto, this.Color);
            double tamaño = this.tinta;
            double aux = 0.3;
            this.tinta = this.tinta - ((float)tamaño * (float)aux);
            return retorno;
        }


        bool IAcciones.Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder dato = new StringBuilder();
            dato.AppendFormat("Color de tinta: {0}", this.colorTinta);
            dato.AppendFormat("\nTinta: {0}", this.tinta);
            return dato.ToString();
        }

        #endregion
    }
}
