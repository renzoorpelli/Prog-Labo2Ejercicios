using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO;
using IO.Excepciones;
namespace PruebasExtensionesArchivo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarExtensionJson_DeberiaDevolverTrue()
        {
            PuntoJson<string> json = new PuntoJson<string>();
            string test = ".json";

            bool expected = true;
            Assert.AreEqual(expected, json.ValidarExtension(test));
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtensionJsonConArchivoIncorrecto_DeberiaDevolverArchivoIncorrectoException()
        {
            PuntoJson<string> json = new PuntoJson<string>();
            string test = ".ss";

            bool expected = json.ValidarExtension(test);
        }

        [TestMethod]
        public void ValidarExtensionXml_DeberiaDevolverTrue()
        {
            PuntoXml<string> xml = new PuntoXml<string>();
            string test = ".xml";

            bool expected = true;
            Assert.AreEqual(expected, xml.ValidarExtension(test));
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtensionXmlConArchivoIncorrecto_DeberiaDevolverArchivoIncorrectoException()
        {
            PuntoXml<string> xml = new PuntoXml<string>();
            string test = ".ss";

            bool expected = xml.ValidarExtension(test);
        }


        [TestMethod]
        public void ValidarExtensionTxt_DeberiaDevolverTrue()
        {
            PuntoTxt txt = new PuntoTxt();
            string test = ".txt";

            bool expected = true;
            Assert.AreEqual(expected, txt.ValidarExtension(test));
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtensionTxtConArchivoIncorrecto_DeberiaDevolverArchivoIncorrectoException()
        {
            PuntoTxt txt = new PuntoTxt();
            string test = ".ss";

            bool expected = txt.ValidarExtension(test);
        }
    }
}
