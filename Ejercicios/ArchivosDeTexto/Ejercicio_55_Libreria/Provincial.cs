using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_55_Libreria
{
    public class Provincial : Llamada, IGuardar<string>
    {
        #region Enumerado
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }
        #endregion

        protected Franja franjaHoraria;

        #region Propiedades

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string RutaDeArchivo
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Metodos

        public Provincial(Franja franjaHoraria, Llamada llamada)
            : this(llamada.NroOrigen, franjaHoraria, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja franjaHoraria, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public bool Guardar()
        {            
            throw new NotImplementedException();
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }


        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder(base.Mostrar());
            datos.AppendFormat("\nFranja horaria: {0}", this.franjaHoraria);
            return datos.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Provincial)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = this.Duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    retorno = this.Duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    retorno = this.Duracion * (float)0.66;
                    break;
            }
            return retorno;
        }


        #endregion
    }
}
