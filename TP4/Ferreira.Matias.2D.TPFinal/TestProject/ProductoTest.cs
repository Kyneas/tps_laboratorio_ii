using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaTP4;

namespace TestProject
{
    [TestClass]
    public class ProductoTest
    {
        //[TestMethod]
        //public void AumentarId_VerificaQueSeAumenteElIdLuegoDeCrearOtroProducto_DeberiaIncrmentarEnUnoElValorDelUltimoIdDelArchivoTxt()
        //{
        //    //Arrange
        //    Producto producto = new Producto("Test", 1, 1);
        //    int id = producto.IdProducto;
        //    int expected = id + 1;
        //    //Act
        //    Producto producto2 = new Producto("Test2", 1, 1);
        //    int actual = producto2.IdProducto;
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        [TestMethod]
        public void ValidarPrecio_VerificaQueArrojeLaExceptionDatoInvalidoAlIngresarUnPrecioErroneo_DeberiaArrojarLaExcepcionDatoInvalidoException()
        {
            //Arrange
            string precioInvalido = "3456f";
            //Act

            //Assert
            Assert.ThrowsException<DatoInvalidoException>(() => Producto.ValidarPrecio(precioInvalido));
        }
    }
}
