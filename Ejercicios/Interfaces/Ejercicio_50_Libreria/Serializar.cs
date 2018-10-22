using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_51_Libreria
{
    public class Serializar<S,V> : IGuardar<S,V>
    {
        public V Leer()
        {
            return (V)Convert.ChangeType("Objeto leido", typeof(V));
        }

        public bool Guardar(S obj)
        {
            return true;
        }
    }
}
