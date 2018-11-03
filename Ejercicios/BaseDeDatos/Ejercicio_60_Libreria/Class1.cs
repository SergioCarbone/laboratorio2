using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace Ejercicio_60_Libreria
{
    public class Class1
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;

        public Class1()
        {            
            try
            {
                string conectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True";
                conexion = new SqlConnection(conectionStr);
                conexion.Open();                                             
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public string Mostrar()
        {
            string aux = "";            
            comando = new SqlCommand("SELECT Name FROM AdventureWorks2012.Production.Product", conexion);
            //comando.CommandText = "SELECT nombre FROM Production.Product";
            //comando.CommandType = System.Data.CommandType.Text;
            //comando.Connection = conexion;

            
            dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                //aux += dataReader["ProductID"].ToString();
                aux += dataReader["Name"].ToString();                
            }
            dataReader.Close();
            return aux;
        }

        
    }
}
