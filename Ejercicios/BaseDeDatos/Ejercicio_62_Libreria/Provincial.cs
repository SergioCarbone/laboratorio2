using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_62_Libreria
{
    public class Provincial : Llamada//, IGuardar<string>
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
        protected string ruta;

        #region Propiedades

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
            set
            {
                this.CalcularCosto();
            }
         
        }

        public string RutaDeArchivo
        {
            get
            {
                return this.ruta;
            }
            set
            {
                this.ruta = value;
            }
        }

        #endregion

        #region Metodos

        public Provincial()
        {

        }

        public Provincial(Franja franjaHoraria, Llamada llamada)
            : this(llamada.NroOrigen, franjaHoraria, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja franjaHoraria, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = franjaHoraria;
            this.RutaDeArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public bool Guardar()
        {
            bool retorno = false;
            XmlTextWriter writer;
            XmlSerializer ser;
            string ruta = RutaDeArchivo + "/" + "pruebaProvincial.xml";
            try
            {
                writer = new XmlTextWriter(ruta, Encoding.UTF8);
                ser = new XmlSerializer(typeof(Provincial));
                ser.Serialize(writer, this);
                writer.Close();
                retorno = true;
            }
            catch (InvalidCastException e)
            {
                throw new InvalidCastException(e.Message);
            }
            return retorno;
        }

        public string Leer()
        {
            Provincial p = new Provincial();                      
            string ruta = RutaDeArchivo + "/" + "pruebaProvincial.xml";
            try
            {
                XmlTextReader reader = new XmlTextReader(ruta);
                XmlSerializer ser = new XmlSerializer(typeof(Provincial));
                p = (Provincial)ser.Deserialize(reader);
                reader.Close();
            }
            catch(InvalidCastException w)
            {
                throw new InvalidCastException(w.Message);
            }
            return p.ToString();
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
