using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_37_libreria
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Propiedades

        public float GananciasPorLocal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }
        #endregion

        #region Metodos

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }


        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;
            foreach (Llamada llamada in listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if(llamada is Local)
                        {
                            retorno += ((Local)llamada).Costo;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if(llamada is Provincial)
                        {
                            retorno += ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if(llamada is Local)
                        {
                            retorno += ((Local)llamada).Costo;
                        }
                        else if(llamada is Provincial)
                        {
                            retorno += ((Provincial)llamada).CostoLlamada;
                        }
                        break;                  
                }
            }
            return retorno;
        }


        public string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Razon social: {0}", this.razonSocial);            
            datos.AppendFormat("\nGanancias locales: {0}", this.GananciasPorLocal);
            datos.AppendFormat("\nGanancias provinciales: {0}", this.GananciasPorProvincial);
            datos.AppendFormat("\nGanancias totales: {0}", this.GananciasPorTotal);
            foreach (Llamada llamada in listaDeLlamadas)
            {
                datos.AppendLine();
                datos.AppendFormat("\n{0}", llamada.Mostrar());
            }
            return datos.ToString();
        }


        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion
    }
}
