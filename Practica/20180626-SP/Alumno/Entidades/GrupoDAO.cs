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
    public class GrupoDAO
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;
        Grupo grupo;
        public GrupoDAO()
        {
            try
            {
                string conectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=mundial-sp-2018;Integrated Security=True";
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


        public void Guardar(Equipo equipo1, Equipo equipo2)
        {
            //string query = string.Format("INSERT INTO CentralitaTabla (Duracion,Origen,Destino,Costo,tipo) VALUES ({0},'{1}','{2}',{3},{4})",
            //    provincial.Duracion, provincial.NroOrigen, provincial.NroDestino, provincial.CostoLlamada, 1);
            //Operar(query);
            try
            {
                string query = string.Format("INSERT INTO Partidos (idEquipo1, golesEquipo1, idEquipo2, golesEquipo2) VALUES ({0},{1},{2},{3})",
                    equipo1.Id, equipo1.GolesHechos, equipo2.Id, equipo2.GolesHechos);
                Operar(query);
            }
            catch(Exception e)
            {
                throw e;
            }            
        }


        public List<Equipo> Leer(Letras letra)
        {
           try
            {
                string query = string.Format("SELECT * FROM Equipos WHERE grupo = '{0}'", letra);
                comando = new SqlCommand(query, conexion);
                conexion.Open();
                dataReader = comando.ExecuteReader();
                Equipo equipo;
                List<Equipo> listaEquipo = new List<Equipo>();
                string nombre;
                int id;

                while (dataReader.Read())
                {
                    nombre = dataReader["nombre"].ToString();
                    id = Convert.ToInt32(dataReader["id"]);
                    equipo = new Equipo(id, nombre);
                    listaEquipo.Add(equipo);
                }
                return listaEquipo;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
                dataReader.Close();
            }
        }
    }
}
