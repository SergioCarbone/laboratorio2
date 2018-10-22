using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_41_Libreria;

namespace Ejercicio_40_libreria
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Propiedades

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

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
                        if (llamada is Local)
                        {
                            retorno += llamada.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            retorno += llamada.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            retorno += llamada.CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            retorno += llamada.CostoLlamada;
                        }
                        break;
                }
            }
            return retorno;
        }


        private string Mostrar()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Razon social: {0}", this.razonSocial);
            datos.AppendFormat("\nGanancias locales: {0}", this.GananciasPorLocal);
            datos.AppendFormat("\nGanancias provinciales: {0}", this.GananciasPorProvincial);
            datos.AppendFormat("\nGanancias totales: {0}", this.GananciasPorTotal);
            foreach (Llamada llamada in listaDeLlamadas)
            {
                datos.AppendLine();
                datos.AppendFormat("\n{0}", llamada.ToString());
            }
            return datos.ToString();
        }


        public override string ToString()
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }


        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada aux in c.listaDeLlamadas)
            {
                if (llamada == aux)
                {
                    if (llamada.NroDestino == aux.NroDestino && llamada.NroOrigen == aux.NroOrigen)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }


        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return (!(c == llamada));
        }


        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (!(c == nuevaLlamada))
            {
                c.listaDeLlamadas.Add(nuevaLlamada);
            }
            else
            {
                throw new CentralitaException("La llamada ya se encuentra registrada", "Centralita", "Operador +");
            }
            return c;
        }

        #endregion
    }
}
