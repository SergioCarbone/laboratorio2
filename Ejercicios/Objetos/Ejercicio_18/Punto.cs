using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private int x,y;

        public int GetX
        {
            get
            {
                return this.x;
            }
        }

        public int GetY
        {
            get
            {
                return this.y;
            }
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
