using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_57
{
    //[Serializable]
    public class Persona
    {
        private string nombre, apellido;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        //public static bool Guardar(Persona p)
        //{
        //    bool retorno = false;
        //    FileStream fs;
        //    BinaryFormatter bf;

        //    fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "ArchivoBinario", FileMode.Create);
        //    bf = new BinaryFormatter();

        //    bf.Serialize(fs, p);
        //    fs.Close();

        //    return retorno;
        //}

        public static void Guardar(Persona p)
        {
            XmlSerializer serializer;
            XmlTextWriter writer;
            
            try
            {
                writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "Prueba", Encoding.UTF8);
                serializer = new XmlSerializer(typeof(Persona));
                serializer.Serialize(writer, p);
                writer.Close();
            }
            catch(ArgumentException)
            {
                string error = "argumento no valido";
                throw new ArgumentException(error);
            }
            catch(UnauthorizedAccessException)
            {
                string error = "acceso denegado";
                throw new UnauthorizedAccessException(error);
            }            
            catch(InvalidOperationException)
            {
                string error = "Llamada invalida";
                throw new InvalidOperationException(error);
            }
        }


        public static Persona Leer()
        {
            XmlTextReader reader;
            XmlSerializer serializer;
            Persona p = new Persona();
            try
            {
                reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "Prueba");
                serializer = new XmlSerializer(typeof(Persona));
                p = (Persona)serializer.Deserialize(reader);
                reader.Close();
                return p;
            }
            catch(ArgumentException)
            {
                string error = "La ruta de acceso es invalida";
                throw new ArgumentException(error);
            }
        }

        //public static Persona Leer()
        //{
        //    Persona p = new Persona();
        //    FileStream fs;
        //    BinaryFormatter bf;

        //    fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "ArchivoBinario", FileMode.Open);
        //    bf = new BinaryFormatter();
        //    p = (Persona)bf.Deserialize(fs);

        //    return p;
        //}


        public override string ToString()
        {
            StringBuilder dato = new StringBuilder();
            dato.AppendFormat("Nombre: {0}", this.nombre);
            dato.AppendFormat("\nApellido: {0}", this.apellido);
            return dato.ToString();
        }
    }
}
