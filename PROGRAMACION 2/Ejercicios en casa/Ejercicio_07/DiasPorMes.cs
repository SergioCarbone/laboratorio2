using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    public class DiasPorMes
    {
        public static int CalcularDias (int mes, int anio)
        {
            int numero = 0;
            if ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))
            {
                numero = 30;   
            }
            else if (mes == 2)
            {
                if(AnioBisiesto.BuscarAnioBisiesto(anio))
                {
                    numero = 29;
                }
                else
                {
                    numero = 28;
                }
            }
            else
            {
                numero = 31;
            }

            return numero;
        }
            
            
    }
}
