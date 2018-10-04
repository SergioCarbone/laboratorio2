using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        #region Propiedades

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        #endregion

        #region Metodos
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            : base(nombre,apellido,edad,dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }


        /// <summary>
        /// Muestra los datos Completos del jugador
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder(base.Mostrar());
            datos.AppendFormat("\nAltura: {0}", this.Altura);
            datos.AppendFormat("\nPeso: {0}", this.Peso);
            datos.AppendFormat("\nPosicion: {0}", this.Posicion);
            return datos.ToString();
        }

        /// <summary>
        /// Valida que el estado fisico del jugador este dentro del rango pedido
        /// </summary>
        /// <returns></returns>
        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            double IMC = Peso / (Math.Pow(this.Altura, 2));
            if(IMC >= 18.5 && IMC <= 25)
            {
                retorno = true;
            }
            
            return retorno;
        }

        /// <summary>
        /// Valida que la edad del jugador no supere los 40 años
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(this.Edad < 40 && ValidarEstadoFisico())
            {
                retorno = true;
            }
            return retorno;
        }

        #endregion
    }
}
