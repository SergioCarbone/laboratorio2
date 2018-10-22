using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48_Libreria
{
    public class Contabilidad<T,U> where T : Documento where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }


        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }


        public string MostrarEgresos()
        {
            StringBuilder datos = new StringBuilder();
            foreach (T aux in this.egresos)
            {
                datos.AppendFormat("\nEgreso: ${0}",aux);
            }
            return datos.ToString();
        }

        public string MostrarIngresos()
        {
            StringBuilder datos = new StringBuilder();
            foreach (U aux in this.ingresos)
            {
                datos.AppendFormat("\nIngreso: ${0}", aux);
            }
            return datos.ToString();
        }
    }
}
