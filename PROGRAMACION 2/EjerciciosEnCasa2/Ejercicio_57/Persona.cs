using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Security;


namespace Ejercicio_57
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }


        public Persona() 
        {            
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(Persona p)
        {
            XmlSerializer aux;
            XmlTextWriter writer;

            try
            {
                writer = new XmlTextWriter("Archivo", Encoding.UTF8);
                aux = new XmlSerializer(typeof(Persona));
                aux.Serialize(writer, p);
                writer.Close();
            }
            catch (ArgumentException)
            {
                string error = "la ruta de acceso es invalida";
                throw new ArgumentException(error);
            }
            catch (FileLoadException)
            {
                string error = "la ruta de acceso no existe";
                throw new FileLoadException(error);
            }
            catch (IOException)
            {
                string error = "El archivo esta en uso";
                throw new IOException(error);
            }
            catch (NotSupportedException)
            {
                string error = "El nombre del archivo tiene formato no valido";
                throw new NotSupportedException(error);
            }
            catch (SecurityException)
            {
                string error = "El usuario no tiene los permisos necesarios";
                throw new SecurityException(error);
            }
            catch (InvalidOperationException)
            {
                string error = "nombre no encontrado";
                throw new InvalidOperationException(error);
            }
        }

        public static Persona Leer()
        {
            Persona aux = new Persona();
            XmlSerializer ser;
            XmlTextReader reader;

            try
            {
                reader = new XmlTextReader("Archivo");
                ser = new XmlSerializer(typeof(Persona));
                aux = (Persona)ser.Deserialize(reader);
                reader.Close();
                return aux;
            }
            catch (ArgumentException)
            {
                string error = "la ruta de acceso es invalida";
                throw new ArgumentException(error);
            }
            catch (FileLoadException)
            {
                string error = "la ruta de acceso no existe";
                throw new FileLoadException(error);
            }
            catch (IOException)
            {
                string error = "El archivo esta en uso";
                throw new IOException(error);
            }
            catch (NotSupportedException)
            {
                string error = "El nombre del archivo tiene formato no valido";
                throw new NotSupportedException(error);
            }
            catch (SecurityException)
            {
                string error = "El usuario no tiene los permisos necesarios";
                throw new SecurityException(error);
            }
            catch (InvalidOperationException)
            {
                string error = "nombre no encontrado";
                throw new InvalidOperationException(error);
            }
        }


        public override string ToString()
        {
            StringBuilder datosPersona = new StringBuilder();
            datosPersona.AppendFormat("Nombre: {0} - Apellido: {1}", this.nombre, this.apellido);
            return datosPersona.ToString();
        }


    }
}
