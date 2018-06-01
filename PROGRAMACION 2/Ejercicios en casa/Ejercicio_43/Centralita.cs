using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaAbstracta
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamada;
        protected string razonSocial;


        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamada;
            }
        }

        private Centralita()
        {
            listaDeLlamada = new List<Llamada>();
        }

        public Centralita(string nombreDeEmpresa)
            : this()
        {
            this.razonSocial = nombreDeEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipoLlamada)
        {
            float contLocal = 0, contProvincial = 0;
            int retorno;
            foreach (Llamada llamada in listaDeLlamada)
            {

                if (llamada is Local)
                {
                    contLocal += llamada.Duracion;
                }
                else if (llamada is Provincial)
                {
                    contProvincial += llamada.Duracion;
                }
            }

            if (tipoLlamada == Llamada.TipoLlamada.Local)
            {
                retorno = (int)contLocal;
            }
            else if (tipoLlamada == Llamada.TipoLlamada.Provincial)
            {
                retorno = (int)contProvincial;
            }
            else
            {
                retorno = (int)contProvincial + (int)contLocal;
            }
            return retorno;
        }

        private string Mostrar()
        {
            StringBuilder datosLlamada = new StringBuilder();
            datosLlamada.AppendFormat("Razon social: {0}", this.razonSocial);
            datosLlamada.AppendFormat("\n");
            datosLlamada.AppendFormat("Ganancia total: {0}", this.GananciasPorTotal);
            datosLlamada.AppendFormat("\n");
            datosLlamada.AppendFormat("Ganancia llamadas locales: {0}", this.GananciasPorLocal);
            datosLlamada.AppendFormat("\n");
            datosLlamada.AppendFormat("Ganancia llamadas provinciales: {0}", this.GananciasPorProvincial);
            datosLlamada.AppendFormat("\n");
            foreach (Llamada llamada in listaDeLlamada)
            {
                Console.WriteLine(llamada.ToString());
                datosLlamada.AppendFormat("\n");
            }
            datosLlamada.AppendFormat("---------------------------------------------------\n");

            return datosLlamada.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


        public void OrdenarLlamadas()
        {
            listaDeLlamada.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nvaLlamada)
        {
            listaDeLlamada.Add(nvaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada l1 in c.listaDeLlamada)
            {
                if (l1 == llamada)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada l1 in c.listaDeLlamada)
            {
                if (l1 != llamada)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static Centralita operator +(Centralita c, Llamada nvaLlamada)
        {
            if (!(c == nvaLlamada))
            {
                c.AgregarLlamada(nvaLlamada);
            }
            else
            {
                throw new CentralitaException("La llamada ya existe \n\n", "centralita", "Sobrecarca");
            }
            return c;
        }
    }
}
