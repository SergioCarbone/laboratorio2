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
    public class Dao : IArchivos<Votacion>
    {
        SqlConnection conexion;
        SqlCommand comando;        

        public Dao()
        {
            string conectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=votacion-sp-2018;Integrated Security=True";
            conexion = new SqlConnection(conectionStr);
        }


        private void Operar(string query)
        {
            comando = new SqlCommand(query, conexion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public bool Guardar(string rutaArchivo, Votacion objeto)
        {
            try
            {
                string query = string.Format("INSERT INTO Votaciones (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES ('{0}',{1},{2},{3},'{4}')",
                objeto.NombreLey, objeto.ContadorAfirmativo, objeto.ContadorNegativo, objeto.ContadorAbstencion, "Sergio Carbone");
                Operar(query);
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }            
        }


        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }

    }
}
