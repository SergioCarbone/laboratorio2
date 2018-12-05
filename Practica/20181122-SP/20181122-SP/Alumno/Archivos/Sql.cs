using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivos<Queue<Patente>>
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;

        public Sql()
        {
            string conectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=patentes-sp-2018;Integrated Security=True";
            conexion = new SqlConnection(conectionStr);
        }


        public void Guardar(string tabla, Queue<Patente> datos)
        {
            try
            {
                foreach (Patente p in datos)
                {
                    string query = string.Format("INSERT INTO '{0}' (patente, tipo) VALUES ('{1}','{2}')", tabla, p.CodigoPatente, p.TipoCodigo);
                    Operar(query);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            try
            {
                string query = string.Format("SELECT * FROM {0}", tabla);
                comando = new SqlCommand(query, conexion);
                conexion.Open();
                dataReader = comando.ExecuteReader();
                //string codigo;
                //Patente.Tipo tipo;
                Patente p;
                datos = new Queue<Patente>();

                while (dataReader.Read())
                {
                    p = dataReader["patente"].ToString().ValidarPatente();                    
                    //codigo = dataReader["patente"].ToString();                   
                    //tipo = (Patente.Tipo)dataReader["tipo"];
                    //p = new Patente(codigo, tipo);
                    datos.Enqueue(p);
                }                
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
                dataReader.Close();
            }
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
