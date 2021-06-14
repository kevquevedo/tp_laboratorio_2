using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fabrica;
using Productos;
using Excepciones;

namespace Test_Unitarios
{
    [TestClass]
    public class Test_Unitarios
    {
        ///MARCADOR TEST UNITARIOS

        [TestMethod]
        public void FabricaDeMuebles_ValidarConstructor_NotNull()
        {
            //Arrange
            FabricaDeMuebles<Muebles, Pedidos> fabricaTest;

            //Act
            fabricaTest = new FabricaDeMuebles<Muebles, Pedidos>();

            //Assert
            Assert.IsNotNull(fabricaTest);
        }


        [TestMethod]
        [ExpectedException(typeof(MaderaInsuficienteException))]
        public void FabricaDeMuebles_ValidarRecortar_Exception()
        {
            //Arrange
            FabricaDeMuebles<Muebles, Pedidos> fabricaTest = new FabricaDeMuebles<Muebles, Pedidos>();

            Mesa mesa1 = new Mesa(Terminacion.Barnizado, ColorMadera.Blanco);
            Mesa mesa2 = new Mesa(Terminacion.Barnizado, ColorMadera.Blanco);
            Mesa mesa3 = new Mesa(Terminacion.Barnizado, ColorMadera.Blanco);

            //Act
            fabricaTest.Recortar(mesa1);
            fabricaTest.Recortar(mesa2);
            fabricaTest.Recortar(mesa3);
        }


        [TestMethod]
        public void Pedidos_ValidarNumeroPedido_AreEqual()
        {
            //Arrange
            Mesa mesa1 = new Mesa(Terminacion.Barnizado, ColorMadera.Blanco);
            Pedidos pedido = new Pedidos(45, mesa1);

            //Act
            double numeroObtenido = pedido.NumeroPedido;

            //Assert
            Assert.AreEqual(45, numeroObtenido);
        }

        [TestMethod]
        public void Pedidos_ValidarInformacionPedido_NotNull()
        {
            //Arrange
            Mesa mesa1 = new Mesa(Terminacion.Barnizado, ColorMadera.Blanco);
            Pedidos pedido = new Pedidos(45, mesa1);

            //Act
            string informe = pedido.InformacionPedido();

            //Assert
            Assert.IsNotNull(informe);
        }
    }
}
