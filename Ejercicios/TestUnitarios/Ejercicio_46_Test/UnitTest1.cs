using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_46_Libreria;

namespace Ejercicio_46_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLista()
        {
            Competencia a = new Competencia(5, 5, Competencia.TipoCompetencia.AutoF1);
            Assert.AreNotEqual(a.Competidores, null);
           // Assert.AreEqual(a.Competidores, null);
        }

        [TestMethod]
        public void TestLanzarExcepcion()
        {
            Competencia a = new Competencia(5, 5, Competencia.TipoCompetencia.MotoCross);
            AutoF1 p = new AutoF1(5, "Ford",350);

            try
            {
                if(a + p)
                {
                    Console.WriteLine("ok");
                }
            }
            catch(CompetenciaNoDisponibleException w)
            {
                Assert.IsInstanceOfType(w, typeof(CompetenciaNoDisponibleException));
            }
        }

        [TestMethod]
        public void TestNoLanzarExcepcion()
        {
            Competencia a = new Competencia(5, 1, Competencia.TipoCompetencia.AutoF1);
            AutoF1 p = new AutoF1(5, "Ford");
            AutoF1 p2 = new AutoF1(8, "Ford");

            try
            {
                if (a + p)
                {
                    Console.WriteLine("ok");
                }
                if(a + p2)
                {

                }
            }
            catch (CompetenciaNoDisponibleException w)
            {
                Assert.IsInstanceOfType(w, typeof(DivideByZeroException));
            }
        }


        [TestMethod]
        public void TestVerificarLista()
        {
            Competencia a = new Competencia(5, 5, Competencia.TipoCompetencia.AutoF1);
            AutoF1 p = new AutoF1(5, "Ford");
            AutoF1 p2 = new AutoF1(8, "Ford");

            try
            {
                if (a + p)
                {
                    
                }

                if(a + p2)
                {
                    
                }
            }
            catch(CompetenciaNoDisponibleException e)
            {
                Assert.IsInstanceOfType(e, typeof(DivideByZeroException));
            }
        }

    }
}
