using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52_ClassLibrary1
{
    public class Lapiz : IAcciones 
    {
        private float tamañoMina;

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamañoMina;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            EscrituraWrapper auxiliar = new EscrituraWrapper();
            int cantCaracteres = texto.Length;
            this.tamañoMina = this.tamañoMina - (float)(cantCaracteres * 0.1);
            return auxiliar;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Lapiz - {0} - {1}", ((IAcciones)this).Color, ((IAcciones)this).UnidadesDeEscritura); 
            return datos.ToString();
        }

        public Lapiz(int unidades)
        {
            this.tamañoMina = unidades;
        }
    }
}
