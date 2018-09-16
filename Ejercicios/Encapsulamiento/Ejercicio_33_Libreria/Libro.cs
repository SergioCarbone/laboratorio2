using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33_Libreria
{
    public class Libro
    {        
        private List<string> paginas = new List<string>();
        
        public string this[int i]
        {
            get
            {
                return paginas[i];
            }
            set
            {
                paginas[i] = value;
            }
        }
    }
}
