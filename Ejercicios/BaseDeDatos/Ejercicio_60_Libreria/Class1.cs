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
        public List<Producto> lista;

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


        public void Mostrar()
        {
            Producto p = null;
            string ProductID;
            string Name;
            string ProductNumber;
            lista = new List<Producto>();

            //string dato = "SELECT Name FROM AdventureWorks2012.Production.Product"
            comando = new SqlCommand("SELECT * FROM AdventureWorks2012.Production.Product", conexion);
            //comando.CommandText = "SELECT nombre FROM Production.Product";
            //comando.CommandType = System.Data.CommandType.Text;
            //comando.Connection = conexion;

            
            dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                ProductID = dataReader["ProductID"].ToString();
                //aux += "\t";
                Name = dataReader["Name"].ToString();
                //aux += "\t";
                ProductNumber = dataReader["ProductNumber"].ToString();
                //aux += "\t";
                //aux += "\n";      
                p = new Producto(Convert.ToInt32(ProductID), Name, ProductNumber);
                lista.Add(p);
            }
            
            dataReader.Close();            
        }

        
    }
}
