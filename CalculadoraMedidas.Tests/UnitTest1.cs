using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculadoraMedidas.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Operaciones_MetroToMi_Obtener62()
        {
            var operaciones = new Operaciones(10000);

            //Act
            var result = operaciones.MetroToMi();

            //Assert
            Assert.AreEqual("6.2", result.ToString());
        }
        [TestMethod]
        public void Operaciones_MetroToIn_ObtenerUnEnteroY2Decimales()
        {
            var operaciones = new Operaciones(1);

            //Act
            var result = operaciones.MetroToIn();

            //Assert
            Assert.AreEqual("39.37", result.ToString());
        }
        [TestMethod]
        public void Operaciones_MetroToKm_Obtener0()
        {
            var operaciones = new Operaciones(0);

            //Act
            var result = operaciones.MetroToKm();

            //Assert
            Assert.AreEqual("0", result.ToString());
        }
    }
}
