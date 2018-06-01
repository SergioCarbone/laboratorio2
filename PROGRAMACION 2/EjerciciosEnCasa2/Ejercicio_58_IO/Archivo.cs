using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Security;
using CentralitaAbstracta;

namespace Ejercicio_58_IO
{
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta)
        {
            bool retorno = false;
            try
            {
                XmlTextReader aux = new XmlTextReader(ruta);                
                aux.Close();
                retorno = true;
            }
            catch(FileNotFoundException)
            {
                string error = "El archivo no existe";
                throw new FileNotFoundException(error);
            }
            return retorno;
        }
    }
}
