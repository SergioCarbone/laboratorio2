using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Boligrafo
    {
        const int cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo()
        {

        }

        public Boligrafo(short tinta, ConsoleColor color)
        {
            SetTinta(tinta);
        }

        private short SetTinta(short cargaTinta)
        {
            short retorno;
            if (this.tinta + cargaTinta <= 100 && this.tinta + cargaTinta >= 0)
            {
                this.tinta += cargaTinta;
                retorno = this.tinta;
            }
            else if(this.tinta + cargaTinta > 100)
            {
                this.tinta = cantidadTintaMaxima;
                retorno = this.tinta;
            }
            else
            {
                retorno = this.tinta;
                this.tinta = 0;
            }
            
            return retorno;
        }

        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }

        public void Recargar(short tinta)
        {
            SetTinta(tinta);
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public  short GetTinta()
        {
            return tinta;
        }


        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";
            int aux;

            if (gasto <= this.tinta)
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
                aux = SetTinta((short)(gasto * -1));
                for (int i = 0; i < aux; i++)
                {
                    dibujo += "*";
                }
                retorno = false;
            }
            return retorno;
        }
        
        

    }
}
