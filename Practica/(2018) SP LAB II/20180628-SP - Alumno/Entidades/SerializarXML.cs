using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class SerializarXML : IArchivos<Votacion>
    {
        XmlTextReader reader;
        XmlSerializer ser;
        XmlTextWriter writer;        
        Votacion v;
        public Votacion Leer(string rutaArchivo)
        {            
            try
            {               
                reader = new XmlTextReader(rutaArchivo);
                ser = new XmlSerializer(typeof(Votacion));
                v = (Votacion)ser.Deserialize(reader);                
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException("Error al leer el archivo",e);
            }
            finally
            {
                reader.Close();
            }
            return v;
        }

        public bool Guardar(string rutaArchivo, Votacion objeto)
        {            
            try
            {
                writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(Votacion));
                ser.Serialize(writer, objeto);                
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException("Error al guardar en el archivo",e);
            }
            finally
            {
                writer.Close();
            }
            return true;
        }


    }
}

