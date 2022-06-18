using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaTP4;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class VentaTest
    {
        [TestMethod]
        public void AumentarId_VerificaQueSeAumenteElIdLuegoDeCrearOtroProducto_DeberiaIncrmentarEnUnoElValorDelUltimoIdDelArchivoTxt()
        {
            //Arrange
            List<Producto> lista = new List<Producto>();
            List<Producto> lista2 = new List<Producto>();
            lista.Add(new Producto(1, "Test", 1, 1));
            lista2.Add(new Producto(2, "Test2", 1, 1));
            Venta venta = new Venta(12, lista);
            int id = venta.IdVenta;
            int expected = id + 1;
            //Act
            Venta venta2 = new Venta(14, lista2);
            int actual = venta2.IdVenta;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}