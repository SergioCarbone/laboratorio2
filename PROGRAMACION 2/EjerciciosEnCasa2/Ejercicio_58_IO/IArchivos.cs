using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_58_IO
{
    public interface IArchivos <T>
    {
        private bool Guardar(string ruta);
        private T Leer(string ruta);
    }
}
