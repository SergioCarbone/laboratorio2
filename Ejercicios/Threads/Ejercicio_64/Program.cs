using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Ejercicio_64_Libreria;

namespace Ejercicio_64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Caja c1 = new Caja();
            Caja c2 = new Caja();
            Negocio pepito = new Negocio(c1, c2);

            pepito.Clientes.Add("Sergio");
            pepito.Clientes.Add("Carlos");
            pepito.Clientes.Add("Nico");
            pepito.Clientes.Add("Diego");
            pepito.Clientes.Add("Luis");


            Thread t1 = new Thread(c1.AtenderClientes);
            Thread t2 = new Thread(c2.AtenderClientes);
            Thread t3 = new Thread(pepito.AsignarCaja);
            t1.Name = "Caja 1";
            t2.Name = "Caja 2";            
            t3.Start();
            t3.Join();
            t1.Start();
            t2.Start();



        }
    }
}
