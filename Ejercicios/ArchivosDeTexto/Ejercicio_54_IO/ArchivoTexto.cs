using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_54_IO
{
    public static class ArchivoTexto
    {
        public static bool Guardar(string path, string informacion)
        {
            bool retorno = false;
            StreamWriter dato = null;

            try
            {
                dato = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "/" + path,true);
                if (dato != null)
                {                    
                    dato.WriteLine(informacion);
                    retorno = true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                dato.Close();                
            }
            return retorno;
        }

        public static string Leer(string path)
        {
            string info = "";
            StreamReader dato = null;

            try
            {
                dato = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + path);
                if(dato != null)
                {
                    info = dato.ReadToEnd();
                }               
            }
            catch(FileNotFoundException w)
            {
                Console.WriteLine(w.Message);
            }
            finally
            {
                dato.Close();
            }
            return info;
        }
        
    }
}
