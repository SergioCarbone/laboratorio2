using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace Ejercicio_61_Libreria
{
    public class PersonaDAO
    {

        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;
        public List<Persona> lista;
        Persona p = null;
        string nombre;
        string apellido;
        int id;

        public PersonaDAO()
        {
            try
            {
                string conectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Sergio;Integrated Security=True";
                conexion = new SqlConnection(conectionStr);                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        private void Operar(string query)
        {
            comando = new SqlCommand(query, conexion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        public void Guardar(Persona p)
        {
            string query = string.Format("INSERT INTO TablaSergio (Nombre,Apellido) VALUES ('{0}','{1}')", p.Nombre, p.Apellido);
            Operar(query);
        }


        public List<Persona> Leer()
        {           
            lista = new List<Persona>();
            comando = new SqlCommand("SELECT * FROM TablaSergio", conexion);
            conexion.Open();
            dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader["ID"]);
                nombre = dataReader["Nombre"].ToString();
                apellido = dataReader["Apellido"].ToString();
                p = new Persona(id, nombre, apellido);
                lista.Add(p);
            }
            dataReader.Close();
            conexion.Close();
            return lista;
        }


        public Persona LeerPorId(int id)
        {
            string query = string.Format("SELECT * FROM TablaSergio WHERE ID = {0}", p.Id);
            conexion.Open();
            dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader["ID"]);
                nombre = dataReader["Nombre"].ToString();
                apellido = dataReader["Apellido"].ToString();
                p = new Persona(id, nombre, apellido);
                lista.Add(p);
            }
            dataReader.Close();
            conexion.Close();
            return p;

        }


        public void ModificarPorId(Persona p)
        {
            string query = string.Format("UPDATE TablaSergio SET Nombre = '{0}', Apellido = '{1}' WHERE ID = {2}", p.Nombre, p.Apellido, p.Id);
            Operar(query);
        }


        public void Borrar(int id)
        {
            string query = string.Format("DELETE FROM TablaSergio WHERE ID = {0}", id);
            Operar(query);
        }

    }
}
