using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class SerializarXML : IArchivos<Votacion>
    {
        XmlTextReader reader;
        XmlTextWriter writer;
        XmlSerializer ser;
        Votacion voto;

        public Votacion Leer(string rutaArchivo)
        {
            try
            {
                reader = new XmlTextReader(rutaArchivo);
                ser = new XmlSerializer(typeof(Votacion));
                voto = (Votacion)ser.Deserialize(reader);
                return voto;
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException("Error al leer el archivo XML", e);
            }
            finally
            {
                reader.Close();
            }

        }

        public bool Guardar(string rutaArchivo, Votacion votacion)
        {
            try
            {
                writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(Votacion));
                ser.Serialize(writer, votacion);
                return true;
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException("Error al guardar el archivo XML", e);
            }
            finally
            {
                writer.Close();
            }                        
        }
    }
}
