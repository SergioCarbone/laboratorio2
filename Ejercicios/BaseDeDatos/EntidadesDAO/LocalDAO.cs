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
    public class LocalDAO
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;
        Local p1;
        public LocalDAO()
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


        public void Guardar(Local local)
        {
            string query = string.Format("INSERT INTO CentralitaTabla (Duracion,Origen,Destino,Costo,Tipo) VALUES ({0},'{1}','{2}',{3})",
                local.Duracion, local.NroOrigen, local.NroDestino, local.CostoLlamada, 0);
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
            float costo;

            while (dataReader.Read())
            {
                origen = dataReader["Origen"].ToString();
                destino = dataReader["Destino"].ToString();
                duracion = Convert.ToInt32(dataReader["Duracion"]);
                costo = (float)dataReader["Costo"];
                p1 = new Local(origen, duracion, destino, costo);
            }
            dataReader.Close();
            conexion.Close();
        }
    }
}
