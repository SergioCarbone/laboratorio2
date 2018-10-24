using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un numero binario a un numero decimal
        /// </summary>
        /// <param name="numero">valor que sera convertido</param>
        /// <returns>Retorna el valor convertido</returns>
        public static double BinarioDecimal(string numero)
        {
            int j = 0;
            double retorno = 1, aux;
            for (int i = 0; i < numero.Length; i++)
            {
                if(numero[i] != '0' && numero[i] != '1')
                {
                    retorno = -1;
                }               
            }

            if(retorno == 1)
            {
                retorno = 0;
                for (int i = numero.Length; i > 0; i--)
                {
                    if (numero[i - 1] == '1')
                    {
                        aux = Math.Pow(2, j);
                        retorno += aux;
                    }
                    j++;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Convierte un numero decimal a un numero binario
        /// </summary>
        /// <param name="numero">valor que sera convertido</param>
        /// <returns>Retorna el valor convertido</returns>
        public static string DecimalBinario(double numero)
        {
            int resto, resultado, auxiliar = (int)numero;
            string binario = "", auxBinario, retorno = "";

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

            for (int i = binario.Length; i > 0; i--)
            {
                retorno += binario[i - 1];
            }
            return retorno;
        }
    }
}
