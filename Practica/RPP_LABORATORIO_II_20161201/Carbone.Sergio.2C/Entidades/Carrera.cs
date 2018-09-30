using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera
    {
        private List<Animal> animales;
        private int corredoresMax;

        private Carrera()
        {
            animales = new List<Animal>();
        }

        public Carrera(int corredoresMax)
            : this()
        {
            this.corredoresMax = corredoresMax;
        }

        public static bool operator ==(Carrera c, Animal a)
        {
            bool retorno = false;

            foreach (Animal aux in c.animales)
            {
                if(aux == a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }


        public static bool operator !=(Carrera c, Animal a)
        {
            return (!(c == a));
        }


        public static Carrera operator +(Carrera c, Animal a)
        {
            if(c.animales.Count < c.corredoresMax)
            {
                if(c != a)
                {
                    c.animales.Add(a);
                }
            }
            return c;
        }
             

        public string MostrarCarrera()
        {
            StringBuilder datos = new StringBuilder();
            Perro p;
            Caballo c;
            Humano h;
            for (int i = 0; i < animales.Count; i++)
            {                
                if(animales[i] is Perro)
                {
                    p = (Perro)animales[i];
                    datos.AppendLine();                    
                    datos.AppendFormat("{0}", p.MostrarPerro());
                    datos.AppendFormat("\nPerro");
                }
                else if(animales[i] is Caballo)
                {
                    c = (Caballo)animales[i];
                    datos.AppendLine();                    
                    datos.AppendFormat("{0}", c.MostrarCaballo());
                    datos.AppendFormat("\nCaballo");
                }
                else
                {
                    h = (Humano)animales[i];
                    datos.AppendLine();                    
                    datos.AppendFormat("{0}", h.MostrarHumano());
                    datos.AppendFormat("\nHumano");
                }               
            }
            return datos.ToString();
        }
    }
}
