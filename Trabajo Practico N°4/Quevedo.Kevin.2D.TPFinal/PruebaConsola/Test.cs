using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica;
using Productos;
using Excepciones;
  

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {

            FabricaDeMuebles<Muebles, Pedidos> fabricaKevin = new FabricaDeMuebles<Muebles, Pedidos>();

            Mesa mesa = new Mesa(Terminacion.Laqueado, ColorMadera.Nogal);
            Silla silla = new Silla(Terminacion.Melamina, ColorMadera.Roble, Silla.ColorTapizado.Blanco);
            Biblioteca biblioteca = new Biblioteca(Terminacion.Barnizado, ColorMadera.Negro, 3);

            Pedidos pedido1 = new Pedidos(23, mesa);
            Pedidos pedido2 = new Pedidos(45, silla);
            Pedidos pedido3 = new Pedidos(67, biblioteca);

             /// TEST: AGREGAR PEDIDO / EXCEPCIONES / ELIMINAR PEDIDO DE FABRICA

            try
            {
                bool resultado1 = fabricaKevin + pedido1;
                bool resultado2 = fabricaKevin + pedido2;
                bool resultado3 = fabricaKevin - pedido1;
                fabricaKevin.Recortar(pedido1.DetallePedido);
                //fabricaKevin.Recortar(pedido3.DetallePedido); //Descomentar para que se produzca MaderaInsuficienteException.
            }
            catch (MaderaInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PedidoNoAgregadoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PedidoNoEliminadoException ex)
            {
                Console.WriteLine(ex.Message);
            }


            /// TEST: SALIDA POR CONSOLA DE LOS DATOS DEL MUEBLE / POLIMORFISMO
            
            Console.Write(pedido1.DetallePedido.ToString());
            Console.WriteLine("----------------------------------");
            Console.Write(pedido2.DetallePedido.ToString());
            Console.WriteLine("----------------------------------");
            Console.Write(pedido3.DetallePedido.ToString());

            /// TEST: PROCESO DE FABRICACION / EXCEPCIONES
            /// 

            try
            {
                fabricaKevin.Recortar(pedido3.DetallePedido);
                fabricaKevin.Lijar(pedido3.DetallePedido);
                fabricaKevin.PintarYArmar(pedido3.DetallePedido);
                fabricaKevin.TerminarTratamiento(pedido3.DetallePedido);
            }
            catch(MaderaInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (LijaInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PinturaYArmardoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TratamientoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----------------------------------");
            Console.Write(pedido3.DetallePedido.ToString());

            Console.WriteLine("----------------------------------");

            /// TEST: METODO DE EXTENSION

            Muebles mueble = new Mesa(Terminacion.Laqueado, ColorMadera.Ebano);
            Console.WriteLine(mueble.InformacionPedidoExtendido());

            Console.ReadKey();
        }
    }
}
