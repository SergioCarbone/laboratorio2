using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_54_IO
{
    public static class ArchivoTexto
    {
        public bool Guardar(string path, string informacion)
        {
            StreamWriter dato = new StreamWriter(path);
        }
    }
}
