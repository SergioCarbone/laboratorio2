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
    public class SqlPrueba
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader dataReader;
        public List<Producto> lista;

        public SqlPrueba()
        {                      
            try
            {
                string conectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True";
                conexion = new SqlConnection(conectionStr);
                //conexion.Open();
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
            comando = new SqlCommand("SELECT * FROM Production.Product", conexion);
            conexion.Open();
            dataReader = comando.ExecuteReader();

            while (dataReader.Read())
            {
                ProductID = dataReader["ProductID"].ToString();                
                Name = dataReader["Name"].ToString();                
                ProductNumber = dataReader["ProductNumber"].ToString();
                p = new Producto(Convert.ToInt32(ProductID), Name, ProductNumber);
                lista.Add(p);
            }            
            dataReader.Close();
            conexion.Close();
        }


        public void Modificar(Producto p)
        {
            string query = string.Format("UPDATE Production.Product SET Name = '{0}', ProductNumber = '{1}' WHERE ProductID = {2}", p.Name, p.ProductNumber, p.Id);
            Operar(query);
        }


        public void Insertar(Producto p)
        {
            string query = string.Format("INSERT INTO Sergio (Nombre,Apellido) VALUES ('{0}','{1}')", p.Name, p.ProductNumber);
            Operar(query);
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
