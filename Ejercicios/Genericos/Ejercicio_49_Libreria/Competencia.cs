﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_49_Libreria
{
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        private short cantidadCompetidores, cantidadVueltas;
        private List<T> competidores;
        private TipoCompetencia Tipo;


        public List<T> Competidores
        {
            get
            {
                return this.competidores;
            }
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public T this[int i]
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
            competidores = new List<T>();
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
            datosCompetencia.AppendFormat("\nCantidad de competidores: {0}", this.CantidadCompetidores);
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


        public static bool operator +(Competencia<T> c, T v)
        {
            bool retorno = false;
            try
            {
                if (c == v)
                {
                    if (c.competidores.Count < c.cantidadCompetidores)
                    {
                        if(!(c.competidores.Contains(v)))
                        {
                            AgregarCompetidor(c, v);
                            retorno = true;
                        }
                        else
                        {
                            throw new CompetenciaNoDisponibleException("Ya se encuentra en la lista", "Competencia", "operador +");
                        }
                    }
                }
            }
            catch(CompetenciaNoDisponibleException e)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta","Competencia","operador +",e);
            }
            return retorno;
        }

        public static bool operator -(Competencia<T> c, T v)
        {
            bool retorno = false;
            if (c == v)
            {
                c.competidores.Remove(v);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Competencia<T> c, VehiculoDeCarrera v)
        {
            bool retorno = false;

            if (c.Tipo == TipoCompetencia.AutoF1 && v is AutoF1)
            {
                retorno = true;
            }
            else if (c.Tipo == TipoCompetencia.MotoCross && v is MotoCross)
            {
                retorno = true;
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "metodo ==");
            }
            return retorno;
        }

        public static bool operator !=(Competencia<T> c, VehiculoDeCarrera v)
        {
            return (!(c == v));
        }


        private static void AgregarCompetidor(Competencia<T> c, T v)
        {            
            v.VueltasRestantes = c.cantidadVueltas;
            v.EnCompetencia = true;
            Thread.Sleep(500);
            Random combustible = new Random();
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
