using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using Entidades;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Serializar()
        {
            Agencia a = new Agencia("Sergio");

            Xml<Agencia> xml = new Xml<Agencia>();
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "Agencia.xml";
            xml.Guardar(ruta, a);

            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void Deserializar()
        {
            Agencia a = new Agencia("Sergio");
            string info = null;

            Xml<Agencia> xml = new Xml<Agencia>();
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "Agencia.xml";
            info = xml.Leer(ruta).ToString();

            Assert.IsNotNull(a);
        }
    }
}
