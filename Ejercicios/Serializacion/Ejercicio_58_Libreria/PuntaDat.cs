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
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
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

        public PuntoDat()
        {

        }

        public PuntoDat Leer(string ruta)
        {
            PuntoDat aux = new PuntoDat();
            fs = new FileStream(ruta, FileMode.Open);
            bf = new BinaryFormatter();
            aux.Contenido = (string)bf.Deserialize(fs);
            fs.Close();
            return aux;
        }


        public bool Guardar(string ruta, PuntoDat objeto)
        {
            if (ValidarArchivo(ruta))
            {
                fs = new FileStream(ruta, FileMode.Append);
                bf = new BinaryFormatter();
                bf.Serialize(fs, objeto.Contenido);
                fs.Close();
                retorno = true;
            }
            return retorno;
        }

        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            fs = new FileStream(ruta, FileMode.Create);
            bf = new BinaryFormatter();
            bf.Serialize(fs, objeto.Contenido);
            fs.Close();
            return true;
        }

        protected override bool ValidarArchivo(string ruta)
        {
            bool retorno = false;
            try
            {
                if(File.Exists(ruta))
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
            }
            catch(FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", e);
            }            
            return retorno;
        }
    }
}
