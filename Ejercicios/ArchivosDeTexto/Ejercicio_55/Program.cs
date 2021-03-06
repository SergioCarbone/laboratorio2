﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_55_Libreria;

namespace Ejercicio_55
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Console.WriteLine(nombreArchivo);
            //Console.ReadKey();
            // Mi central            
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas 
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.             
            c.RutaDeArchivo = "Log de llamadas";
            try
            {
                c = c + l1;
                c = c + l2;
                c = c + l3;
                c = c + l4;
            }
            catch(CentralitaException e)
            {
                Console.WriteLine(e.Message);
            }


           // c.OrdenarLlamadas();


            Console.WriteLine(c.Leer());
            Console.ReadKey();
        }
    }
}
