using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52_ClassLibrary1
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;


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

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper auxiliar = new EscrituraWrapper();
            int cantCaracteres = texto.Length;
            this.tinta = this.tinta - ((float)cantCaracteres * 0.3f);
            return auxiliar;
        }

        public bool Recargar(int unidades)
        {
            this.tinta += (float)unidades;
            return true;
        }
      

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            Recargar(unidades);
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Boligrafo - {0} - {1}",this.colorTinta, this.tinta);
            return datos.ToString();
        }
    }
}
