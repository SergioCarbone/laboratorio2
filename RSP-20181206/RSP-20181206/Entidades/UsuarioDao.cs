using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace Entidades
{
    public class UsuarioDao
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;
        private string cadenaDeConexion;

        

        public UsuarioDao()
        {
            string conectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=final-20180802;Integrated Security=True";
            conexion = new SqlConnection(conectionStr);
        }

        public void Guardar(Usuario u)
        {
            string query = string.Format("INSERT INTO Usuarios (nombre,clave) VALUES ('{0}','{1}')", u.Nombre, u.Clave);
            Operar(query);
        }


        public Usuario Leer(string usuario, string clave)
        {
            string query = string.Format("SELECT * FROM Usuarios WHERE nombre = '{0}' and clave = '{1}'", usuario, clave);
            comando = new SqlCommand(query, conexion);
            conexion.Open();    
            dataReader = comando.ExecuteReader();
            string nombre;
            string contrasena;
            Usuario aux = null;

            while (dataReader.Read())
            {                
                nombre = dataReader["nombre"].ToString();
                contrasena = dataReader["clave"].ToString();
                aux = new Usuario(nombre, contrasena);
            }
            dataReader.Close();
            conexion.Close();
            return aux;
        }


        private void Operar(string query)
        {
            comando = new SqlCommand(query, conexion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
