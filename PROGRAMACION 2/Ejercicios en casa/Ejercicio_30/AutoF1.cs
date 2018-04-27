using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;


        private AutoF1()
        {
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public AutoF1(short numero, string escuderia) : this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public void SetCantidadCombustible(short combustible)
        {
            this.cantidadCombustible = combustible;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetEnCompetencia()
        {
            this.enCompetencia = true;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public void SetVueltasRestantes(short vueltas)
        {
            this.vueltasRestantes = vueltas;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if(a1.escuderia == a2.escuderia)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if (a1.escuderia != a2.escuderia)
            {
                retorno = true;
            }
            return retorno;
        }

        public string MostrarDatos()
        {
            StringBuilder datosAuto = new StringBuilder();
            datosAuto.AppendFormat("Escuderia: {0}", this.escuderia);
            datosAuto.AppendFormat("Numero: {0}", this.numero);
            datosAuto.AppendFormat("Estado {0}", this.enCompetencia);
            return datosAuto.ToString();
        }
    }
}
