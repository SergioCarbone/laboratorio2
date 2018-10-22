using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapicera
{
    public class Boligrafo
    {
        const short cantidadMaximaTinta = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo() { }

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if((this.tinta + tinta) > cantidadMaximaTinta)
            {
                this.tinta = cantidadMaximaTinta;
            }
            else if((this.tinta + tinta) < 0)
            {
                this.tinta = 0;
            }
            else
            {
                this.tinta += tinta;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadMaximaTinta);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";

            if((this.tinta - gasto) >= 0)
            {
                SetTinta((short)(gasto * -1));
                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
                retorno = true;
            }
            else
            {                
                for (int i = 0; i < this.tinta; i++)
                {
                    dibujo += "*";
                }
                SetTinta((short)(gasto * -1));
            }
            return retorno;
        }



    }
}
