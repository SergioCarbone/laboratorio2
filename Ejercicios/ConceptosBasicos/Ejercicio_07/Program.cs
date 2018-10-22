using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Practica";
            Console.ForegroundColor = ConsoleColor.Green;

            bool flag = false;
            int ano, mes, dia, cantDias = 0;
            
            Console.Write("Ingrese el año en que nacio: ");
            if (int.TryParse(Console.ReadLine(), out ano) && ano <= DateTime.Now.Year)
            {
                Console.Write("Ingrese el mes: ");
                if (int.TryParse(Console.ReadLine(), out mes) && mes >= 1 && mes <= 12)
                {
                    Console.Write("Ingrese el dia: ");
                    if (int.TryParse(Console.ReadLine(), out dia) && dia >= 1 && dia <= 31)
                    {
                        flag = true;
                        if(ano != DateTime.Now.Year)
                        {
                            cantDias += Calculos.CalcularDiasPorAno(ano + 1);
                            cantDias += (Calculos.CalcularDiasPorMes(mes, ano) - dia);
                        }
                        else
                        {
                            cantDias += (Calculos.CalcularDias(mes) - dia);                            
                        }                        
                    }
                    else
                    {
                        Console.WriteLine("Error, ingrese un dia valido");                        
                    }
                }
                else
                {
                    Console.WriteLine("Error, ingrese un mes valido");
                }
            }
            else
            {
                Console.WriteLine("Error, ingrese un año valido");
            }

            if(flag == true)
            {
                Console.Write("Usted vivio: {0} dias", cantDias);
            }
            
            Console.ReadKey();
        }
    }
}
