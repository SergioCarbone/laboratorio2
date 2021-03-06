﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        protected int cantidadPatas;
        protected static Random distanciaRecorrida;
        protected int velocidadMaxima;

        #region Propiedades

        public int CantidadPatas
        {
            get
            {
                return this.cantidadPatas;
            }
            set
            {
                if(value <= 4)
                {
                    this.cantidadPatas = value;
                }
                else
                {
                    this.cantidadPatas = 4;
                }
            }
        }

        public int VelocidadMaxima
        {
            get
            {
                return this.velocidadMaxima;
            }
            set
            {
                if(value <= 60)
                {
                    this.velocidadMaxima = value;
                }
                else
                {
                    this.velocidadMaxima = 60;
                }
            }
        }

        private int DistanciaRecorrida
        {
            get
            {
                
                return distanciaRecorrida.Next(1, 10);                 
            }
        }
        #endregion

        #region Metodos

        static Animal()
        {
            distanciaRecorrida = new Random();
        }

        public Animal(int cantPatas, int velocidadMaxima)
        {
            this.CantidadPatas = cantPatas;
            this.VelocidadMaxima = velocidadMaxima;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();            
            datos.AppendFormat("\nCantidad de patas: {0}", this.CantidadPatas);
            datos.AppendFormat("\nVelocidad maxima: {0}", this.VelocidadMaxima);
            datos.AppendFormat("\nDistancia recorrida: {0}", this.DistanciaRecorrida);
            return datos.ToString();
        }
        #endregion
    }
}
