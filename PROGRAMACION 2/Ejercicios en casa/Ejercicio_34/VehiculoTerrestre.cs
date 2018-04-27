using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class VehiculoTerrestre : Moto
    {
        private string marca;
        private int modelo;

        public VehiculoTerrestre(short cilindrada, short puertas, short ruedas, Colores color,
            string marca, int modelo) : base(cilindrada,ruedas,puertas,color)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public string MostrarDatos()
        {
            StringBuilder datosVehiculo = new StringBuilder();
            datosVehiculo.AppendFormat("Marca: {0}", this.marca);
            datosVehiculo.AppendFormat("\n");
            datosVehiculo.AppendFormat("Modelo: {0}", this.modelo);


            return datosVehiculo.ToString();
        }
    }
}
