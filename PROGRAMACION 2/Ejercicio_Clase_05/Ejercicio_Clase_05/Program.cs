using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Estante estante = new Estante(3, 1);

            Producto producto1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto producto2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto producto3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto producto4 = new Producto("Crush", "CRSDS54861", (float)10.75);

            if(estante + producto1)
            {
                Console.WriteLine("Agrego: Producto: {0} - Codigo de barra: {1} - Precio: {2}", 
                    producto1.GetMarca(), (string)producto1, producto1.GetPrecio());
            }
            else
            {
                Console.WriteLine("Error. No se agrego: Producto: {0} Codigo de barra: {1} Precio: {2}", 
                    producto1.GetMarca(), (string)producto1, producto1.GetPrecio());
            }
            if(estante + producto1)
            {
                Console.WriteLine("Agrego: Producto: {0} - Codigo de barra: {1} - Precio: {2}",
                    producto1.GetMarca(), (string)producto1, producto1.GetPrecio());
            }
            else
            {
                Console.WriteLine("Error. No se agrego: Producto: {0} Codigo de barra: {1} Precio: {2}",
                    producto1.GetMarca(), (string)producto1, producto1.GetPrecio());
            }
            if(estante + producto2)
            {
                Console.WriteLine("Agrego: Producto: {0} - Codigo de barra: {1} - Precio: {2}",
                    producto2.GetMarca(), (string)producto2, producto2.GetPrecio());
            }
            else
            {
                Console.WriteLine("Error. No se agrego: Producto: {0} Codigo de barra: {1} Precio: {2}",
                    producto2.GetMarca(), (string)producto2, producto2.GetPrecio());
            }
            if (estante + producto3)
            {
                Console.WriteLine("Agrego: Producto: {0} - Codigo de barra: {1} - Precio: {2}",
                    producto3.GetMarca(), (string)producto3, producto3.GetPrecio());
            }
            else
            {
                Console.WriteLine("Error. No se agrego: Producto: {0} Codigo de barra: {1} Precio: {2}",
                    producto3.GetMarca(), (string)producto3, producto3.GetPrecio());
            }
            if (estante + producto4)
            {
                Console.WriteLine("Agrego: Producto: {0} - Codigo de barra: {1} - Precio: {2}",
                    producto4.GetMarca(), (string)producto4, producto4.GetPrecio());
            }
            else
            {
                Console.WriteLine("Error. No se agrego: Producto: {0} Codigo de barra: {1} Precio: {2}",
                    producto4.GetMarca(), (string)producto4, producto4.GetPrecio());
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine(estante.MostrarEstante(estante));

            Console.ReadKey();
        }
    }
}
