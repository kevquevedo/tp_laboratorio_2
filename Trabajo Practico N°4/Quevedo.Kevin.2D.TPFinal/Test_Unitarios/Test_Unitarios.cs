using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fabrica;
using Productos;
using Excepciones;
using Archivos;
using System.IO;

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

        /// <summary>
        /// Metodo que controla la excepcion Madera Insuficiente.
        /// </summary>
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

        /// <summary>
        /// Metodo que controla la excepcion Lija Insuficiente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(LijaInsuficienteException))]
        public void FabricaDeMuebles_ValidarLijar_Exception()
        {
            //Arrange
            FabricaDeMuebles<Muebles, Pedidos> fabricaTest = new FabricaDeMuebles<Muebles, Pedidos>();

            Mesa mesa1 = new Mesa(Terminacion.Barnizado, ColorMadera.Blanco);
            Mesa mesa2 = new Mesa(Terminacion.Barnizado, ColorMadera.Blanco);
            Mesa mesa3 = new Mesa(Terminacion.Barnizado, ColorMadera.Blanco);

            //Act
            fabricaTest.Lijar(mesa1);
            fabricaTest.Lijar(mesa2);
            fabricaTest.Lijar(mesa3);
        }

        /// <summary>
        /// Metodo que controla la excepcion Pintar y Armar.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(PinturaYArmardoException))]
        public void FabricaDeMuebles_ValidarPintarYArmar_Exception()
        {
            //Arrange
            FabricaDeMuebles<Muebles, Pedidos> fabricaTest = new FabricaDeMuebles<Muebles, Pedidos>();
            Mesa mesa1 = new Mesa(Terminacion.Barnizado, ColorMadera.Blanco);

            //Act
            fabricaTest.Recortar(mesa1);
            fabricaTest.PintarYArmar(mesa1);
        }

        /// <summary>
        /// Metodo que controla la excepcion de Tratamiento de Terminacion.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(TratamientoException))]
        public void FabricaDeMuebles_ValidarTerminacion_Exception()
        {
            //Arrange
            FabricaDeMuebles<Muebles, Pedidos> fabricaTest = new FabricaDeMuebles<Muebles, Pedidos>();
            Mesa mesa1 = new Mesa(Terminacion.Barnizado, ColorMadera.Blanco);

            //Act
            fabricaTest.Recortar(mesa1);
            fabricaTest.Lijar(mesa1);
            fabricaTest.TerminarTratamiento(mesa1);
        }

        /// <summary>
        /// Metodo que controla una excepcion de Archivos.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FabricaDeMuebles_ValidarArchivos_Exception()
        {
            //Arrange
            string ruta = null;
            string texto = "KEVIN QUEVEDO";
            Archivador archivador = new Archivador(ruta);

            //Act
            archivador.Guardar(texto);
        }

        /// <summary>
        /// Metodo que controla una excepcion de Serializacion.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FabricaDeMuebles_ValidarSerializacion_Exception()
        {
            //Arrange
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/ESTE ARCHIVO NO EXISTE.txt";
            SerializadorBinario<Pedidos> serializador = new SerializadorBinario<Pedidos>(ruta);

            //Act
            serializador.Leer();
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
