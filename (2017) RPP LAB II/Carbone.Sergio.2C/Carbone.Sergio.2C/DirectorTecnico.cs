using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbone.Sergio._2C
{
    public class DirectorTecnico : Persona
    {
        public DirectorTecnico(string nombre, string apellido)
            : base(nombre,apellido)
        {

        }

        protected override string FichaTecnica()
        {
            return NombreCompteto();
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }
    }
}
