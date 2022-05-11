using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace PruebasUnitarias
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //Arrange
            PaqueteFragil paqueteFragil = new PaqueteFragil("aaa", 5000, "buenos aires", "china", 10);

            decimal expected = 6750;
            decimal actual;

            //act
            actual = paqueteFragil.AplicarImpuestos();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoDeEnvio()
        {
            //Arrange
            PaqueteFragil paqueteFragil = new PaqueteFragil("aaa", 5000, "buenos aires", "china", 10);

            decimal expected = 1750;
            decimal actual;

            //act
            actual = paqueteFragil.Impuestos;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange
            PaqueteFragil paqueteFragil = new PaqueteFragil("aaa", 5000, "buenos aires", "china", 10);

            bool expected = true;
            bool actual;

            //act
            actual = paqueteFragil.TieneProbiedad;

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
