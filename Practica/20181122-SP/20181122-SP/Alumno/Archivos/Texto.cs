using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivos<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter sw;
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + archivo;
            sw = new StreamWriter(ruta, true);
            sw.Write(datos);
            sw.Close();
        }


        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();                       
            StreamReader file = new StreamReader(archivo);
            while (!file.EndOfStream)
            {
                try
                {
                    datos.Enqueue(file.ReadLine().ValidarPatente());
                }
                catch (PatenteInvalidaException e)
                { }
            }
        }
    }
}
