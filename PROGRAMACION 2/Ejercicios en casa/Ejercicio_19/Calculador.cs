using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Calculador
    {
        private int acumulador;

        public Calculador()
        {
            this.acumulador = 0;
        }

        public void Acumular(string binario)
        {

            this.acumulador += (int)Conversor.binarioEntero(binario);

        }


        public string GetResultadoBinario()
        {
            string numBinario;

            numBinario = Conversor.enteroBinario(this.acumulador);
            return numBinario;
        }


        public int GetResultadoEntero()
        {
            return this.acumulador;
        }
    }
}
