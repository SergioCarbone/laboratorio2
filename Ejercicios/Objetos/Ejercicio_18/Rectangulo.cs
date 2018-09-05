using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area, perimetro;
        private Punto vertice1, vertice2, vertice3, vertice4;

        public float GetArea
        {
            get
            {
                return this.area;
            }
        }

        public float GetPerimetro
        {
            get
            {
                return this.perimetro;
            }
        }


        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            Math.Abs(vertice1.GetX);
        }

        public float Area()
        {

            return 0;
        }

        public float Perimetro()
        {
            return 0;
        }


    }
}
