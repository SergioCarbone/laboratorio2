using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    //Deberá heredar de Almacenador e implementar IAlmacenable.
    //Crear un constructor que reciba y asigne el/los atributos de la misma.
    //El método MostrarArchivos lanzará una excepción del tipo NotImplementedException.
    //El método Guardar deberá guardar un objeto de tipo archivo en un archivo de texto en la ubicación definida en el atributo pathArchivos.
    //El método Leer recibirá el nombre de un archivo y deberá retornar su contenido.
    //Tanto en Leer como en Guardar capturar y relanzar las excepciones.
    public class ArchiveroFisico : Almacenador, IAlmacenable<string,Archivo>
    {
        private string pathArchivos;

        public string PathArchivos
        {
            get
            {
                return this.pathArchivos;
            }
            set
            {
                this.pathArchivos = value;
            }
        }

        public ArchiveroFisico(int capacidad)
            : base(capacidad)
        {

        }

        public ArchiveroFisico(string path)
        {
            this.PathArchivos = path;
        }


        public bool Guardar(Archivo a)
        {
            bool retorno = false;
            StreamWriter dato = null;

            try
            {
                dato = new StreamWriter(PathArchivos,true);
                if (dato != null)
                {
                    dato.WriteLine(a.Contenido);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                dato.Close();
            }
            return retorno;
        }


        public string Leer(string path)
        {            
            string info = "";
            StreamReader dato = null;

            try
            {
                dato = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + path);
                if (dato != null)
                {
                    info = dato.ReadToEnd();
                }
            }
            catch (FileNotFoundException w)
            {
                throw w;
            }
            finally
            {
                dato.Close();
            }
            return info;
        }


        public override void MostrarArchivos()
        {
            throw new NotImplementedException();
        }
    }
}
