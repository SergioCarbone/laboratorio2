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
    public class Sql : IArchivos<Patente>
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;

        public Sql()
        {
            string conectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=final-20180802;Integrated Security=True";
            conexion = new SqlConnection(conectionStr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tabla"></param>
        /// <param name="datos"></param>
        public void Guardar(string tabla, Queue<Patente> datos)
        {
            try
            {
                foreach (Patente p in datos)
                {
                    string query = string.Format("INSERT INTO '{0}' (patente,tipo) VALUES ('{1}','{2}')",
                        tabla,p.CodigoPatente, p.TipoCodigo);
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
                string query = string.Format("SELECT * FROM '{0}'", tabla);
                comando = new SqlCommand(query, conexion);
                conexion.Open();
                dataReader = comando.ExecuteReader();
                string patente;
                Patente.Tipo tipo;
                
                while (dataReader.Read())
                {
                    patente = dataReader["patente"].ToString();
                    tipo = (Patente.Tipo)dataReader["tipo"];
                    Patente p = new Patente(patente, tipo);
                    
                }
                
                dataReader.Close();               
            }
            catch (Exception e)
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
        
    }
}
