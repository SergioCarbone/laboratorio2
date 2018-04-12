using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    public class FechaNacimiento
    {
        public int anio;
        public int mes;
        public int dia;

        public int contarDias()
        {
            StringBuilder fecha = new StringBuilder();
            DateTime fechaActual = DateTime.Now;
            int acumulador = DiasPorMes.CalcularDias(this.mes, this.anio) - (this.dia); 


            for(int i = this.mes + 1; i <= 12; i++)
            {
                acumulador += DiasPorMes.CalcularDias(i, fechaActual.Year);
            }

            for (int i = this.anio + 1; i < fechaActual.Year; i++)
            {
                
                if(AnioBisiesto.BuscarAnioBisiesto(i))
                {
                    acumulador += 366;
                }
                else
                {
                    acumulador += 365;
                }
            }
            for(int i = 1; i < fechaActual.Month; i++)
            {
                acumulador += DiasPorMes.CalcularDias(i, fechaActual.Year);
            }
            for(int i = 1; i <= fechaActual.Day; i++)
            {
                acumulador += 1;
            }
            
            return acumulador;
          
        }

    }
}
 