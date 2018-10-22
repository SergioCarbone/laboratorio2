using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36_libreria
{
    public class Competencia
    {
        private short cantidadCompetidores, cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia Tipo;


        public short CantidadCompetidores { get { return this.cantidadCompetidores; } set { this.cantidadCompetidores = value; } }

        public short CantidadVueltas { get { return this.cantidadVueltas; } set { this.cantidadVueltas = value; } }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return competidores[i];
            }
            set
            {
                if (competidores[i] == value)
                {
                    competidores.Add(value);
                }
            }
        }


        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.CantidadCompetidores = cantidadCompetidores;
            this.CantidadVueltas = cantidadVueltas;
            this.Tipo = tipo;
        }


        public string MostrarDatos()
        {
            StringBuilder datosCompetencia = new StringBuilder();
            datosCompetencia.AppendFormat("Tipo de competencia: {0}", this.Tipo);
            datosCompetencia.AppendFormat("Cantidad de competidores: {0}", this.CantidadCompetidores);
            datosCompetencia.AppendFormat("\nCantidad de vueltas: {0}", this.CantidadVueltas);
            datosCompetencia.AppendLine();
            datosCompetencia.AppendLine();
            foreach (VehiculoDeCarrera vehiculo in competidores)
            {
                datosCompetencia.Append(vehiculo.MostrarDatos());
                datosCompetencia.AppendLine();
                datosCompetencia.AppendLine();
            }
            return datosCompetencia.ToString();
        }


        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            if(c == v)
            {
                if (c.competidores.Count < c.cantidadCompetidores)
                {
                    AgregarCompetidor(c, v);
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            if (c == v)
            {
                c.competidores.Remove(v);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool retorno = false;
            
            if(c.Tipo == TipoCompetencia.AutoF1 && v is AutoF1)
            {
                retorno = true;
            }
            else if(c.Tipo == TipoCompetencia.MotoCross && v is AutoF1)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return (!(c == v));
        }


        private static void AgregarCompetidor(Competencia c, VehiculoDeCarrera v)
        {
            Random combustible = new Random();            
            v.VueltasRestantes = c.cantidadVueltas;
            v.EnCompetencia = true;
            v.CantidadCombustible = ((short)combustible.Next(15, 100));
            c.competidores.Add(v);
        }


        public enum TipoCompetencia
        {
            AutoF1,
            MotoCross,
        }
    }
}
