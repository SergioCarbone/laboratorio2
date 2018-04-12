using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Conversor
    {
        static public string enteroBinario(int numero)
        {
            int resultado, resto;
            int auxiliar = numero;
            string binario = "", auxBinario;
            string resBinario = "";

            do
            {
                resultado = auxiliar / 2;
                resto = auxiliar % 2;
                auxiliar = resultado;
                auxBinario = Convert.ToString(resto);
                binario += auxBinario;

            } while (resultado != 1);
            auxBinario = Convert.ToString(resultado);
            binario += auxBinario;

            for (int i = binario.Length; i >= 0; i--)
            {
                if (i != 0)
                {
                    resBinario += binario[i - 1];
                }
            }
            return resBinario;
        }

        /*****************************************************************************************/

        static public double binarioEntero(string binario)
        {
            double numero = 0;
            double auxliliar;
            int j = 0, contador = 0;

            do
            {
                for (int i = binario.Length; i > 0; i--)
                {
                    if (binario[i - 1] == '0' || binario[i - 1] == '1')
                    {
                        if (binario[i - 1] == '1')
                        {
                            auxliliar = Math.Pow(2, j);
                            numero += auxliliar;
                        }
                        j++;
                    }
                    else
                    {
                        contador++;
                    }
                }
                if (contador != 0)
                {
                    numero = -1;
                }

            } while (j < binario.Length);

            return numero;
        }
    }
}
