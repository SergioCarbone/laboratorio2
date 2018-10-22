using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_46_Libreria
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible, numero, vueltasRestantes;
        private bool enCompetencia;
        private string escuderia;

        #region Propiedades

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public string Escuderia { get { return this.escuderia; } set { this.escuderia = value; } }

        public short Numero { get { return this.numero; } set { this.numero = value; } }

        public short VueltasRestantes { get { return this.vueltasRestantes; } set { this.vueltasRestantes = value; } }

        #endregion

        #region Metodos

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("Escuderia: {0}", this.escuderia);
            datos.AppendFormat("\nNumero: {0}", this.numero);
            datos.AppendFormat("\nEstado de competencia: {0}", this.enCompetencia);
            datos.AppendFormat("\nCombustible: {0}", this.cantidadCombustible);
            datos.AppendFormat("\nVueltas restantes: {0}", this.vueltasRestantes);

            return datos.ToString();
        }


        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }
        #endregion
    }
}
