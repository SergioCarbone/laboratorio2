using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio_58_Libreria
{
    [Serializable]
    public class PuntaDat : Archivo, IArchivos<PuntaDat>
    {
        FileStream fs;
        BinaryFormatter bf;
        bool retorno = false;
        private string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }


        public string Leer(string ruta)
        {
            fs = new FileStream(ruta, FileMode.Open);
            bf = new BinaryFormatter();
            return (PuntaDat)bf.Deserialize(fs);
        }


        public bool Guardar(string ruta)
        {
            if (ValidarArchivo(ruta))
            {
                fs = new FileStream(ruta, FileMode.Create);
                bf = new BinaryFormatter();
                bf.Serialize(fs, contenido);
                retorno = true;
            }
            return retorno;
        }

        protected override bool ValidarArchivo(string ruta)
        {
            bool retorno = false;
            try
            {
                
                    if (ruta.Contains(".dat"))
                    {
                        retorno = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un dat.");
                    }
                
            }
            catch(FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", e);
            }            
            return retorno;
        }
    }
}
