using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace PruebasUnitarias
{

    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAfipYAduana()
        {
            //Arrange
            PaquetePesado paqueteFragil = new PaquetePesado("aaa", 5000, "buenos aires", "china", 10);

            decimal expected = 8000;
            decimal actual;

            //act
            actual = paqueteFragil.AplicarImpuestos();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoDeEnvio_CuandoEsImplementacionExplicitalAfip()
        {
            //Arrange
            PaquetePesado paqueteFragil = new PaquetePesado("aaa", 5000, "buenos aires", "china", 10);

            decimal expected = 1250;
            decimal actual;

            //act
            actual = ((IAfip)paqueteFragil).Impuestos;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoDeEnvio_CuandoEsImplementacionExplicita()
        {
            //Arrange
            PaquetePesado paqueteFragil = new PaquetePesado("aaa", 5000, "buenos aires", "china", 10);

            decimal expected = 1750;
            decimal actual;

            //act
            actual = paqueteFragil.Impuestos;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            PaquetePesado paquetePesado = new PaquetePesado("aaa", 5000, "buenos aires", "china", 10);

            bool expected = false;
            bool actual;

            //act
            actual = paquetePesado.TieneProbiedad;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
