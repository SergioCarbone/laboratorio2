using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_45;

namespace Ejercicio_45_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOperar()
        {
            try
            {
                Class1.Operar(5, 0);
            }
            catch(DivideByZeroException e)
            {
                Console.Write(e.Message);
            }           
        }

        [TestMethod]
        public void TestClase2AClase1()
        {                        
        }
    }
}
