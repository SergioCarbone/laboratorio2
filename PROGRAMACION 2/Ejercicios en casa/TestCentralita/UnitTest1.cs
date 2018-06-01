using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaAbstracta;

namespace TestCentralita
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInicializacionLista()
        {
            Centralita cent = new Centralita("sergio");
            Assert.AreNotEqual(cent.Llamadas, null);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestExisteLlamadaLocal()
        {
            Centralita cent = new Centralita("sergio");
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Bernal", 10, "Rosario", 3.65f);

            cent += l1;
            cent += l2;                     
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestExisteLlamadaProvincial()
        {
            Centralita cent = new Centralita("sergio");
            Provincial l3 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Provincial l4 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");

            cent += l3;
            cent += l4;
        }



        [TestMethod]       
        public void TestIgualdadDeTipos()
        {
            Provincial l3 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Provincial l4 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l1 = new Local("Morón", 30, "Bernal", 2.65f);
            Local l2 = new Local("Morón", 10, "Bernal", 3.65f);

            Assert.IsFalse(l1 == l3);
            Assert.IsTrue(l1 == l2);
            Assert.IsFalse(l1 == l4);

            Assert.IsFalse(l2 == l3);
            Assert.IsFalse(l2 == l4);

            Assert.IsTrue(l3 == l4);
        }
            
    }
}
