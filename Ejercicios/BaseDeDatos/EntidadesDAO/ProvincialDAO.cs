using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using Ejercicio_62_Libreria;

namespace EntidadesDAO
{
    public class ProvincialDAO
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;
        Provincial p1;
        public ProvincialDAO()
        {
            try
            {
                string conectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Centralita;Integrated Security=True";
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


        public void Guardar(Provincial provincial)
        {
            string query = string.Format("INSERT INTO CentralitaTabla (Duracion,Origen,Destino,Costo,tipo) VALUES ({0},'{1}','{2}',{3},{4})",
                provincial.Duracion,provincial.NroOrigen,provincial.NroDestino,provincial.CostoLlamada,1);
            Operar(query);
        }


        public void Leer()
        {           
            comando = new SqlCommand("SELECT * FROM CentralitaTabla", conexion);
            conexion.Open();
            dataReader = comando.ExecuteReader();
            string origen;
            string destino;
            int duracion;
            double franja;

            while (dataReader.Read())
            {             
                origen = dataReader["Origen"].ToString();
                destino = dataReader["Destino"].ToString();
                duracion = Convert.ToInt32(dataReader["Duracion"]);
                franja = Convert.ToDouble(dataReader["Costo"]);
                p1 = new Provincial(origen, (Provincial.Franja)franja, duracion, destino);                
            }
            dataReader.Close();
            conexion.Close();            
        }

    }
}
