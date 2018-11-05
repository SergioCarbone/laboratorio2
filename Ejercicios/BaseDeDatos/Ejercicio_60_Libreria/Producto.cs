using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_60_Libreria
{
    public class Producto
    {
        private int id;
        private string name;
        private string productNumber;
        
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string ProductNumber
        {
            get
            {
                return this.productNumber;
            }
            set
            {
                this.productNumber = value;
            }
        }

        public Producto()
        {

        }

        public Producto(int id, string name, string productNumber)
        {
            this.Id = id;
            this.Name = name;
            this.ProductNumber = productNumber;
        }


    }
}
