using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto<T> : IArchivos<T>
    {
        public void Leer(string archivo, out T datos)
        {
            string info = "";
            StreamReader dato = null;
            try
            {   
                dato = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + archivo);
                if (dato != null)
                {
                    info = dato.ReadToEnd();
                }                
            }
            catch (FileNotFoundException w)
            {
                Console.WriteLine(w.Message);
            }
            finally
            {
                dato.Close();
            }
        }

        public void Guardar(string archivo, T datos)
        {
            string info = "";
            StreamReader dato = null;

            try
            {
                dato = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + archivo);
                if (dato != null)
                {
                    info = dato.ReadToEnd();
                }
            }
            catch (FileNotFoundException w)
            {
                Console.WriteLine(w.Message);
            }
            finally
            {
                dato.Close();
            }
        }
    }
}
