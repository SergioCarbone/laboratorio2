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

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.area = float.MinValue;
            this.perimetro = float.MinValue;
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
        }

       public float GetArea()
        {
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }


        public float Area()
        {
            if(this.area <= 0)
            {
                float b = Math.Abs(this.vertice2.GetX() - this.vertice3.GetX());
                float a = Math.Abs(this.vertice1.GetY() - this.vertice2.GetY());
                this.area = (a * b);
            }

            return this.area;
        }

        public float Perimetro()
        {
            if(this.perimetro <= 0)
            {
                float b = Math.Abs(this.vertice2.GetX() - this.vertice3.GetX());
                float a = Math.Abs(this.vertice1.GetY() - this.vertice4.GetY());
                this.perimetro = ((b + a) * 2);
            }
            return this.perimetro;
        }


    }
}
