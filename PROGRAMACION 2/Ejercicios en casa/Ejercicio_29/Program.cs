using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            short cantidad = 3;
            string nombre, nombreEquipo;
            int dni, goles, partidos;

            Jugador hombre;
            Equipo equipo;

            Console.Write("Nombre del equipo: ");
            nombreEquipo = Console.ReadLine();

            Console.Write("Ingrese el nombre del jugador: ");
            nombre = Console.ReadLine();

            Console.Write("ingrese el dni: ");
            if(int.TryParse(Console.ReadLine(), out dni))
            {
                Console.Write("Ingrese los goles: ");
                if(int.TryParse(Console.ReadLine(), out goles))
                {
                    Console.Write("Ingrese los partidos: ");
                    if(int.TryParse(Console.ReadLine(), out partidos))
                    {
                            
                        hombre = new Jugador(dni, nombre, goles, partidos);
                        equipo = new Equipo(cantidad, nombreEquipo);
                        Console.Write(hombre.MostrarDatos());
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
