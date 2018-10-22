using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53_Libreria
{
    public class Cartuchera2
    {
        public List<Lapiz> lapiz;
        public List<Boligrafo> boligrafo;

        public bool ProbarElementos()
        {
            bool retorno = false;
            int cont = 0, tamaño = lapiz.Count + boligrafo.Count;

            foreach (IAcciones aux in lapiz)
            {
                aux.Escribir("a");
                if (aux.UnidadesDeEscritura <= 0)
                {
                    aux.Recargar(2);
                }
                else
                {
                    cont++;
                }
            }

            foreach (IAcciones aux in boligrafo)
            {
                aux.Escribir("a");
                if (aux.UnidadesDeEscritura == 0)
                {
                    aux.Recargar(20);
                }
                cont++;
            }
            if (cont == tamaño)
            {
                retorno = true;
            }

            return retorno;
        }
                
    }
}
