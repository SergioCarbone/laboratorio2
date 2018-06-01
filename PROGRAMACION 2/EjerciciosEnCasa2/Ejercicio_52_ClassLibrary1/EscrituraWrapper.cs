using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52_ClassLibrary1
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public string texto;

        public EscrituraWrapper() { }

        public EscrituraWrapper(string texto, ConsoleColor color) : this()
        {
            this.color = color;
            this.texto = texto;
        }
    }
}
