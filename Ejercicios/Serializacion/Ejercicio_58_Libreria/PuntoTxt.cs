using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ejercicio_58_Libreria
{    
    public class PuntoTxt : Archivo, IArchivos<string>
    {        
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


        public bool Guardar(string ruta)
        {            
            if(ValidarArchivo(ruta))
            {
                StreamWriter sw;
                sw = new StreamWriter(ruta, true);
                sw.Write(contenido);
                sw.Close();
                retorno = true;                
            }
            return retorno;
        }

        
        public string Leer(string ruta)
        {
            string retorno = "";
            StreamReader rw = new StreamReader(ruta);
            retorno = rw.ReadToEnd();
            return retorno;
        }

        protected override bool ValidarArchivo(string ruta)
        {            
            bool retorno = false;
            try
            {
              
                    if (ruta.Contains(".txt"))
                    {
                        retorno = true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un txt.");
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
