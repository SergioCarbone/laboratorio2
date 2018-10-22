using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_44_Libreria;

namespace Ejercicio_44_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInicializacionLista()
        {
            Centralita a = new Centralita("Sergio");
            Assert.AreNotEqual(a.Llamadas, null);
            //Assert.AreEqual(a.Llamadas, null);
        }

        [TestMethod]
        //[ExpectedException(typeof(CentralitaException))]
        public void TestLlamadaExistente()
        {
            Centralita a = new Centralita("Sergio");
            Local l1 = new Local("Capital", 3, "Quilmes", 2.9f);
            Local l2 = new Local("Capital", 5, "Quilmes", 2.6f);
            
            a += l1;
            try
            {
                a += l2;
            }
            catch(CentralitaException w)
            {
                Assert.IsInstanceOfType(w,typeof(CentralitaException) );
            }     
            
        }

        [TestMethod]
        public void TestLlamadaProvincialExistente()
        {
            Centralita a = new Centralita("Sergio");
            Provincial p1 = new Provincial("Argentina", Provincial.Franja.Franja_1, 15, "Brasil");
            Provincial p2 = new Provincial("Argentina", Provincial.Franja.Franja_3, 11, "Brasil");

            a += p1;
            try
            {
                a += p2;
            }
            catch(CentralitaException w)
            {
                Assert.IsInstanceOfType(w, typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void TestLlamadas()
        {            
            Provincial p1 = new Provincial("Capital", Provincial.Franja.Franja_1, 15, "Quilmes");
            Provincial p2 = new Provincial("Capital", Provincial.Franja.Franja_3, 11, "Quilmes");
            Local l1 = new Local("Capital", 3, "Quilmes", 2.9f);
            Local l2 = new Local("Capital", 5, "Quilmes", 2.6f);

            try
            {
                Assert.IsFalse(p1 == l1);
                Assert.IsFalse(p1 == l2);
                Assert.IsTrue(p1 == p2);

                Assert.IsFalse(p2 == l1);
                Assert.IsFalse(p2 == l2);

                Assert.IsTrue(l1 == l2);
            }
            catch(CentralitaException a)
            {
                Assert.IsInstanceOfType(a, typeof(CentralitaException));
            }            
        }
    }
}
