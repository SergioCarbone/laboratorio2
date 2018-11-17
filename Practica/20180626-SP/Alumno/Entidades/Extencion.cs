using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extencion
    {
        public static string FormatoTabla(this String texto, int cantidad)
        {
            string formato = "{0," + cantidad + "}";
            return String.Format(formato, texto);
        }
    }
}
