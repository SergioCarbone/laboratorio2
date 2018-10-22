using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_53_Libreria
{
    public class Cartuchera1 
    {
        public List<IAcciones> miCartuchera;


        public bool ProbarElementos()
        {
            bool retorno = false;
            int cont = 0;

            foreach (IAcciones aux in miCartuchera)
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
            if(cont == miCartuchera.Count)
            {
                retorno = true;
            }
            
            return retorno;
        }
    }
}
