using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Threading;

namespace _20180626_SP_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Copa Mundial Rusia 2018";
            Console.ForegroundColor = ConsoleColor.Green;

            Torneo t = new Torneo("Rusia 2018");
            Torneo c = new Torneo("Copa America");
            
            Thread hilo1;
            Thread hilo2;

            Grupo grupoA = new Grupo(Letras.A, Torneo.MAX_EQUIPOS_GRUPO);
            Grupo grupoB = new Grupo(Letras.B, Torneo.MAX_EQUIPOS_GRUPO);
            Grupo grupoC = new Grupo(Letras.C, Torneo.MAX_EQUIPOS_GRUPO);
            Grupo grupoD = new Grupo(Letras.D, Torneo.MAX_EQUIPOS_GRUPO);

            
            grupoA.Leer();
            grupoB.Leer();
            grupoC.Leer();
            grupoD.Leer();
            t.Grupos.Add(grupoA);
            t.Grupos.Add(grupoB);
            t.Grupos.Add(grupoC);
            t.Grupos.Add(grupoD);

            t.eventoResultados += ImprimirResultados;
            c.eventoResultados += ImprimirResultados;

            // Agregar Thread
            hilo1 = new Thread(t.SimularGrupos);
            hilo1.Start();
            // **************
            hilo1.Join();
            hilo1.Abort();
            t.Guardar();
            Console.Title = "Copa America";
            c.Leer();
            hilo2 = new Thread(c.SimularGrupos);
            hilo2.Start();
            hilo2.Join();
            Console.ReadKey();
            hilo2.Abort();
        }


        public static void ImprimirResultados(Grupo grupo)
        {
            Console.WriteLine(grupo.MostrarTabla());
            Console.WriteLine("Precione una tecla para continuar..");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
