using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entidades;

namespace Archivos
{
    public class Xml<T> : IArchivos<T>
    {
        XmlTextReader reader;
        XmlTextWriter writer;
        XmlSerializer ser;

        public void Guardar(string archivo, T datos )
        {
            try
            {
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, datos);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                writer.Close();
            }
        }

        public void Leer(string archivo, out T datos)
        {
            try
            {
                reader = new XmlTextReader(archivo);
                ser = new XmlSerializer(typeof(T));
                T a = (T)ser.Deserialize(reader);
                datos = a;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                reader.Close();
            }
        }


    }
}
