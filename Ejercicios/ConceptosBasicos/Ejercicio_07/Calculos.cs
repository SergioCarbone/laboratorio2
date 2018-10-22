using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculos
    {
        /// <summary>
        /// Calcula cuantos dias tiene el mes
        /// </summary>
        /// <param name="mes">Recibe el mes en numero</param>
        /// <param name="ano">Recibe el año en numero</param>
        /// <returns>Retorna la cantidad de dias que contiene el mes</returns>
        public static int CalcularDiasPorMes(int mes, int ano)
        {
            int retorno;
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                retorno = 30;
            }
            else if (mes == 2)
            {
                if (VerificarAnoBisiesto(ano))
                {
                    retorno = 29;
                }
                else
                {
                    retorno = 28;
                }
            }
            else
            {
                retorno = 31;
            }
            return retorno;
        }

        /// <summary>
        /// Verifica que si un año es bisiesto o no
        /// </summary>
        /// <param name="ano">Recibe el año a verificar</param>
        /// <returns>Retorna true si el año es bisiesto</returns>
        public static bool VerificarAnoBisiesto(int ano)
        {
            bool retorno = false;
            if ((ano % 4) == 0)                
            {
                if ((ano % 100) == 0 && (ano % 400) == 0)
                {
                    retorno = true;
                }
                else if ((ano % 4) == 0 && (ano % 100) != 0)
                {
                    retorno = true;
                }                
            }
            return retorno;
        }

        /// <summary>
        /// Calcula la cantidad de dias que tiene el año
        /// </summary>
        /// <param name="ano">Recibe el año que se desea calcular</param>
        /// <returns>Devuelve la cantidad de dias de dicho año</returns>
        public static int CalcularDiasPorAno(int ano)
        {
            int retorno = 0;
            for (int i = ano; i <= DateTime.Now.Year; i++)
            {
                if (i < DateTime.Now.Year)
                {
                    if (VerificarAnoBisiesto(i))
                    {
                        retorno += 366;
                    }
                    else
                    {
                        retorno += 365;
                    }
                }
                else
                {
                    retorno += Calculos.CalcularDiasAnoActual();
                }
            }
            return retorno;
        }


        public static int CalcularDiasAnoActual()
        {
            int retorno = 0, mes = DateTime.Now.Month;

            for (int i = 1; i <= mes; i++)
            {
                if (i < mes)
                {
                    retorno += Calculos.CalcularDiasPorMes(i, DateTime.Now.Year);
                }
                else
                {
                    retorno += DateTime.Now.Day;
                }
            }
            return retorno;
        }


        public static int CalcularDias(int mes)
        {
            int retorno = 0, mesActual = DateTime.Now.Month;

            for (int i = mes; i <= mesActual ; i++)
            {
                if (i < mesActual)
                {
                    retorno += Calculos.CalcularDiasPorMes(i, DateTime.Now.Year);
                }
                else
                {
                    retorno += DateTime.Now.Day;
                }
            }
            return retorno;
        }



    }
}

