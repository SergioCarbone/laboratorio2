﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    public class Class1
    {    
        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            return base.GetType() == obj.GetType();
        }


       
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
