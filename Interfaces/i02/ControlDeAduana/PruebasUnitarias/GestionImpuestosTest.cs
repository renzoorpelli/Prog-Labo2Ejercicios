using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
namespace PruebasUnitarias
{
    [TestClass]
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAdana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            //Arrange
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaqueteFragil("F01", 5000, "Buenos aires", "La rioja", 1.75));
            paquetes.Add(new PaquetePesado("F01", 5000, "Buenos aires", "La rioja", 1.75));



            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(paquetes);

            decimal expected = 3500;
            decimal actual;

            //act
            actual = gestionImpuestos.CalcularTotalImpuestosAduana();

            //assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            //Arrange
            List<Paquete> paquetes = new List<Paquete>();
            paquetes.Add(new PaquetePesado("F01", 5000, "Buenos aires", "La rioja", 1.75));
            paquetes.Add(new PaqueteFragil("F01", 5000, "Buenos aires", "La rioja", 1.75));



            GestionImpuestos gestionImpuestos = new GestionImpuestos();
            gestionImpuestos.RegistrarImpuestos(paquetes);

            decimal expected = 1250;
            decimal actual;

            //act
            actual = gestionImpuestos.CalcularTotalImpuestosAfip();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
