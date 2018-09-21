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


                       
                }
            }
            return resultado;
        }

        public string mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("La razon social es:{0}", this.razonSocial);
            datos.AppendLine();
            datos.AppendFormat("Ganancia Total :{0}", this.CalcularGanancia(Llamada.TipoLlamada.Todas));
            datos.AppendFormat("Ganancia Local :{0}", this.CalcularGanancia(Llamada.TipoLlamada.Local));
            datos.AppendFormat("Ganancia Provincial :{0}", this.CalcularGanancia(Llamada.TipoLlamada.Provincial));

            foreach (Llamada llamada in this.listaLlamadas)
            {
                datos.AppendFormat("Numero destino :{0}", llamada.NroDestino);
                datos.AppendLine();
                datos.AppendFormat("Numero Origen  :{0}", llamada.NroOrigen);
                datos.AppendLine();
                datos.AppendFormat("Numero Duracion :{0}", llamada.Duracion);
                datos.AppendLine();

            }

            return datos.ToString();

        }


    }
}
