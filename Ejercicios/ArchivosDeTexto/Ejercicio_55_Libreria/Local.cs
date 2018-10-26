using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_55_Libreria
{
    public class Local : Llamada, IGuardar<string>
    {
        protected float costo;

        #region Propiedades

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
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

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
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
            StringBuilder datosLlamada = new StringBuilder(base.Mostrar());
            datosLlamada.AppendLine();
            datosLlamada.AppendFormat("Costo llamada: {0}", this.CostoLlamada);
            return datosLlamada.ToString();
        }


        private float CalcularCosto()
        {
            return (this.duracion * this.costo);
        }


        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Local)
            {
                retorno = true;
            }
            return retorno;
        }


        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
