using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agencia
    {
        private string nombre;
        private List<Pasaje> pasajesVendidos;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Pasaje> PasajesVendidos { get => pasajesVendidos; set => pasajesVendidos = value; }

        private Agencia()
        {

        }

        public Agencia(string nombre)
        {
            this.Nombre = nombre;
        }

        public static bool operator ==(Agencia a, Pasaje p)
        {
            return true;
        }

        public static bool operator !=(Agencia a, Pasaje p)
        {
            return true;
        }

        public static Agencia operator +(Agencia a, Pasaje p)
        {
            return a;
        }

        public float CalcularGanancia()
        {
            return 0;
        }

        public static explicit operator string(Agencia a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Agencia: " + a.Nombre);
            sb.AppendLine("Pasajes vendidos:");
            foreach (Pasaje p in a.PasajesVendidos)
            {
                sb.AppendLine(p.Mostrar());
            }
            sb.AppendLine("Ganancia: " + a.CalcularGanancia());

            return sb.ToString();
        }
    }
}
