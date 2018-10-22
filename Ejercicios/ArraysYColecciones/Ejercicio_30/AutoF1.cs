using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class AutoF1
    {
        private short cantidadCombustible, numero, vueltasRestantes;
        private bool enCompetencia;
        private string escuderia;

        public AutoF1(short numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.enCompetencia = false;
            this.numero = numero;
            this.escuderia = escuderia;
        }

        /// <summary>
        /// Muestra los datos del auto
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder datosAuto = new StringBuilder();

            datosAuto.AppendFormat("Escuderia: {0}", this.escuderia);
            datosAuto.AppendFormat("\nNumero: {0}", this.numero);
            datosAuto.AppendFormat("\nEstado de competencia: {0}", this.enCompetencia);
            datosAuto.AppendFormat("\nCombustible: {0}", this.cantidadCombustible);
            datosAuto.AppendFormat("\nVueltas restantes: {0}", this.vueltasRestantes);

            return datosAuto.ToString();
        }

        /// <summary>
        /// Compara el numero y la escuderia de dos autos
        /// </summary>
        /// <param name="a1">auto a comparar</param>
        /// <param name="a2">auto a comparar</param>
        /// <returns>True si los autos son iguales, caso contrario false</returns>
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if(a1.escuderia == a2.escuderia && a1.numero == a2.numero)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Compara el numero y la escuderia de dos autos
        /// </summary>
        /// <param name="a1">auto a comparar</param>
        /// <param name="a2">auto a comparar</param>
        /// <returns>True si los autos son distintos, caso contrario false</returns>
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return (!(a1 == a2));
        }

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public void SetCantidadCombustible(short valor)
        {
            this.cantidadCombustible = valor;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetEnCompetencia(bool estado)
        {
            this.enCompetencia = estado;
        }
        
        public short GetVueltas()
        {
            return this.vueltasRestantes;
        }

        public void SetVueltas(short vueltas)
        {
            this.vueltasRestantes = vueltas;
        }
    }
}
