using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    //a.Deberá heredar de Almacenador e implementar IAlmacenable.
    //b.El método Guardar deberá insertar un archivo en la base de datos.
    //c.El método Leer recibirá el nombre de la tabla a consultar. Deberá leer y retornar todos los archivos de la base de datos.
    //d.Tanto en Leer como en Guardar capturar y relanzar las excepciones.
    //e.El método MostrarArchivos por el momento sólo deberá recorrer la lista de archivos y por cada uno simular un retardo de 5 segundos.
    //f.Agregar un constructor en el cual se deberá cargar la lista a partir de los datos guardados en la base.
    //g.Sobrecargar el operador + para agregar un archivo a la lista siempre y cuando no supere la capacidad, caso contrario lanzará una excepción con el mensaje "El disco está lleno!".
    public class DiscoElectronico : Almacenador, IAlmacenable<List<Archivo>,Archivo>
    {
        public delegate void MiDelegado(string info);
        public event MiDelegado MostrarInfo;

        private List<Archivo> archivosGuardados;
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;

        public List<Archivo> ArchivosGuardados
        {
            get
            {
                return this.archivosGuardados;
            }
            set
            {
                this.archivosGuardados = value;
            }
        }

       
        private DiscoElectronico()            
            : this(5)
        {
            archivosGuardados = new List<Archivo>();            
            string conectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=final-20180802;Integrated Security=True";
            conexion = new SqlConnection(conectionStr);
        }


        public DiscoElectronico(int capacidad)
            : base(capacidad)
        {
            archivosGuardados = new List<Archivo>();
            string conectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=final-20180802;Integrated Security=True";
            conexion = new SqlConnection(conectionStr);
        }

        public bool Guardar(Archivo a)
        {
            try
            {
                string query = string.Format("INSERT INTO Archivo (nombre,contenido) VALUES ('{0}','{1}')",a.Nombre,a.Contenido);
                Operar(query);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public List<Archivo> Leer(string path)
        {
            try
            {
                string query = string.Format("SELECT * FROM '{0}'", path);
                comando = new SqlCommand(query, conexion);
                conexion.Open();
                dataReader = comando.ExecuteReader();
                string nombre;
                string contenido;
                Archivo archivo;


                while (dataReader.Read())
                {
                    nombre = dataReader["nombre"].ToString();
                    contenido = dataReader["contenido"].ToString();
                    archivo = new Archivo(nombre, contenido);                    
                    bool aux = this + archivo;
                }
                dataReader.Close();                
                return this.ArchivosGuardados;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }


        private void Operar(string query)
        {
            comando = new SqlCommand(query, conexion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        public override void MostrarArchivos()
        {
            string info = "";
            foreach (Archivo aux in archivosGuardados)
            {
                info = string.Format("Nombre: {0} \nContenido: {1}", aux.Nombre, aux.Contenido);
                MostrarInfo.Invoke(info);
                System.Threading.Thread.Sleep(5000);
            }
        }


        public static bool operator +(DiscoElectronico disco, Archivo a)
        {
            try
            {
                if(disco.Capacidad > disco.ArchivosGuardados.Count)
                {
                    disco.ArchivosGuardados.Add(a);
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return true;
        }

    }
}
