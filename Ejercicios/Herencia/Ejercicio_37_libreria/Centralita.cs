using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37_libreria
{
    public class Centralita
    {
        private List<Llamada> listaLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaLlamadas = new List<Llamada>();

        }
        public Centralita(string nombreEmpresa) :this()
        {
            this.razonSocial= nombreEmpresa;
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float resultado=0;
            foreach (Llamada llamada  in listaLlamadas)
            {
              

                switch (tipo)
                {


                    case Llamada.TipoLlamada.Local:
                        if(llamada is Local)
                        {
                            resultado += ((Local)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            resultado += ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            resultado += ((Local)llamada).CostoLlamada;
                        }
                        else
                        {
                            resultado += ((Provincial)llamada).CostoLlamada;
                        }

                        break;


                        return resultado;
                }
            }
        }

    }
}
