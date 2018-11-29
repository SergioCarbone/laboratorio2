using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivos<T>
    {        

        public void Guardar(string archivo, T datos)
        {
            XmlSerializer serializer;
            XmlTextWriter writer;

            writer = new XmlTextWriter(archivo, Encoding.UTF8);
            serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(writer, datos);
            writer.Close();
        }

        public void Leer(string archivo, out T datos)
        {
            XmlTextReader reader;
            XmlSerializer serializer;
            T aux;

            reader = new XmlTextReader(archivo);
            serializer = new XmlSerializer(typeof(T));
            aux = (T)serializer.Deserialize(reader);
            datos = aux;
            reader.Close();       
        }
    }
}
