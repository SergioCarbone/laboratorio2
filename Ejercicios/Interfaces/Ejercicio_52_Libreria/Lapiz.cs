using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52_Libreria
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        #region Propiedades

        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        #endregion


        #region Metodos

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper retorno = new EscrituraWrapper(texto, this.Color);
            double aux = 0.1;
            int tamaño = texto.Length;
            this.tamanioMina -= (tamaño * (float)aux);
            return retorno;
        }


        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }


        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            StringBuilder dato = new StringBuilder();            
            dato.AppendFormat("Tamaño de mina: {0}", this.tamanioMina);
            return dato.ToString();
        }
        #endregion
    }
}
