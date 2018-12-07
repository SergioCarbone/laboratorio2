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
        public void Guardar(string destino, T dato)
        {
            XmlSerializer serializer;
            XmlTextWriter writer;


            writer = new XmlTextWriter(destino, Encoding.UTF8);
            serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(writer, dato);
            writer.Close();
        }

        public T Leer(string origen)
        {
            XmlTextReader reader;
            XmlSerializer serializer;
            T aux;

            reader = new XmlTextReader(origen);
            serializer = new XmlSerializer(typeof(T));
            aux = (T)serializer.Deserialize(reader);            
            reader.Close();
            return aux;
        }
    }
}
