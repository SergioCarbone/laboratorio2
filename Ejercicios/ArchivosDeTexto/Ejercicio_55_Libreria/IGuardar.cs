using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_55_Libreria
{
    public interface IGuardar<T>
    {
        string RutaDeArchivo { get; set; }

        bool Guardar();
        T Leer();
    }
}
