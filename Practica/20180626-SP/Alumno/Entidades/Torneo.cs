using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class Torneo : IEntradaSalida<bool>
    {
        public delegate void MiDelegado(Grupo grupo);
        public event MiDelegado eventoResultados;

        public const int MAX_EQUIPOS_GRUPO = 4;

        private List<Grupo> grupos;
        private string nombre;
        
        public List<Grupo> Grupos
        {
            get
            {
                return this.grupos;
            }
            set
            {
                this.grupos = value;
            }
        }

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

        public Torneo(string nombre)
        {
            this.Grupos = new List<Grupo>();
            this.Nombre = nombre;
        }

        public bool Guardar()
        {
            XmlTextWriter writer;
            XmlSerializer ser;
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            foreach (Grupo grupo in this.Grupos)
            {
                string finalPath = ruta + @"\grupo-"+grupo.Grupos.ToString()+".xml";
                writer = new XmlTextWriter(finalPath, System.Text.Encoding.Default);
                ser = new XmlSerializer(typeof(Grupo));                
                //string nombre = string.Format("Grupo-{0}.xml", grupo.Grupos);
                
                ser.Serialize(writer, grupo);
                writer.Close();
            }            
            return true;
        }


        public bool Leer()
        {
            Letras letra = Letras.A;
            do
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string finalPath = ruta + @"\grupo-" + letra + ".xml";
                //string ruta = string.Format("Grupo-{0}.xml", letra);
                if (File.Exists(finalPath))
                {                    
                    XmlTextReader reader = new XmlTextReader(finalPath);
                    XmlSerializer ser = new XmlSerializer(typeof(Grupo));
                    Grupo aux = (Grupo)ser.Deserialize(reader);
                    reader.Close();
                    this.Grupos.Add(aux);                    
                }
                letra++;
            } while (letra < Letras.H);
                
                      
            return true;
        }


        public void SimularGrupos()
        {
            foreach (Grupo grupo in this.Grupos)
            {
                grupo.Simular();
                eventoResultados.Invoke(grupo);                
            }
        }
    }
}
