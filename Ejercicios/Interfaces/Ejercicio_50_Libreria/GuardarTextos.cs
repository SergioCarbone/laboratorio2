using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_51_Libreria
{
    public class GuardarTextos<T,V> : IGuardar<T,V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Objeto leido", typeof(V));
        }
    }
}
