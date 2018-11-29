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
            string info;
            Patente p;             
            StreamReader dato = new StreamReader(archivo);
            do
            {
                info = dato.ReadLine();
                p = info.ValidarPatente();
                datos.Enqueue(p);

            } while (dato != null);
            dato.Close();
        }
    }
}
