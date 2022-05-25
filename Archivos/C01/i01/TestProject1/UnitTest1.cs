using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void AlLlamarAMiMetodoEstatico_DeberiaLanzarDivideByZeroException()
        {
            bool prueba = MiClase.MiMetodoEstatico();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void AlInstanciarUnObjetoDeTipoMiClaseSinParametros_DeberiaLanzarUnaException()
        {
            MiClase prueba = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void AlInstanciarUnObjetoDeTipoMiClaseConParametros_DeberiaLanzarUnaException()
        {
            MiClase prueba = new MiClase("sarasa");
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void AlLlamarAMiMetodoDeInstanciaDeOtraClase_DeberiaLanzarMiExcepcion()
        {
            OtraClase prueba = new OtraClase();
            prueba.MiMetodoInstancia();
        }

    }
}
