using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ejercicio_59_Libreria
{
    public class Local : Llamada, IGuardar<string>
    {
        protected float costo;
        protected string ruta;
        #region Propiedades

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
            set
            {
                this.costo = value;
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
        public Local()
        {

        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
            this.RutaDeArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }


        public bool Guardar()
        {
            bool retorno = false;
            string ruta = RutaDeArchivo + "/" + "pruebaLocal.xml";
            
            try
            {
                XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(Local));
                ser.Serialize(writer, this);
                writer.Close();
            }
            catch(InvalidCastException w)
            {
                throw new InvalidCastException(w.Message);
            }
            return retorno;
        }


        public string Leer()
        {
            Local aux = new Local();
            string ruta = RutaDeArchivo + "/" + "pruebaLocal.xml";
            try
            {
                XmlTextReader reader = new XmlTextReader(ruta);
                XmlSerializer ser = new XmlSerializer(typeof(Local));
                aux = (Local)ser.Deserialize(reader);
                reader.Close();
            }
            catch(InvalidCastException w)
            {
                throw new InvalidCastException(w.Message);
            }
            return aux.ToString();
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
