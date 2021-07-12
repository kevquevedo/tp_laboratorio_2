using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;

namespace Fabrica
{
    [Serializable]
    public class Pedidos
    {
        private double numeroPedido;
        private Muebles detallePedido;

        #region PROPIEDADES

        /// <summary>
        /// Propiedad de lectura/escritura que retorna y asigna el numero de pedido.
        /// </summary>
        public double NumeroPedido
        {
            get
            {
                return this.numeroPedido;
            }
            set
            {
                this.numeroPedido = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura que devuelve la lista de Muebles del Pedido.
        /// </summary>
        public Muebles DetallePedido
        {
            get
            {
                return this.detallePedido;
            }
            set
            {
                this.detallePedido = value;
            }
        }

        #endregion


        #region CONSTRUCTORES

        /// <summary>
        /// Constructor publico y sin argumentos de Pedidos para serializar.
        /// </summary>
        public Pedidos()
        {

        }

        /// <summary>
        /// Constructor publico que inicializa los atributos del Pedido.
        /// </summary>
        /// <param name="numero">Numero de pedido a asignar.</param>
        /// <param name="mueble">Mueble  a asignar.</param>
        public Pedidos(double numero, Muebles mueble)
        {
            this.NumeroPedido = numero;
            this.DetallePedido = mueble;
        }

        #endregion


        #region METODOS

        /// <summary>
        /// Informe del pedido.
        /// </summary>
        /// <returns>Retorna un informe con la informacion del Pedido.</returns>
        public string InformacionPedido()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero de Pedido: {this.NumeroPedido}");
            sb.AppendLine($"Detalle:");
            sb.AppendLine();
            sb.AppendLine(detallePedido.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Operador de igualdad, que analiza si los pedidos son iguales.
        /// </summary>
        /// <param name="pedido1">Primer pedido a analizar.</param>
        /// <param name="pedido2">Segundo pedido a analizar.</param>
        /// <returns>Retorna TRUE, si los Pedidos poseen el mismo numero identificador.</returns>
        public static bool operator ==(Pedidos pedido1, Pedidos pedido2)
        {
            bool retorno = false;
            if(!(pedido1 is null || pedido2 is null))
            {
                if (pedido1.NumeroPedido == pedido2.NumeroPedido)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Operador de igualdad, que analiza si los pedidos son distintos.
        /// </summary>
        /// <param name="pedido1">Primer pedido a analizar.</param>
        /// <param name="pedido2">Segundo pedido a analizar.</param>
        /// <returns>Retorna TRUE, si los Pedidos poseen diferente numero identificador.</returns>
        public static bool operator !=(Pedidos pedido1, Pedidos pedido2)
        {
            return !(pedido1 == pedido2);
        }

        /// <summary>
        /// Metodo que indica el numero y el mueble del Pedido.
        /// </summary>
        /// <returns>Retorna el numero y el mueble del Pedido.</returns>
        public override string ToString()
        {
            return $"Numero de Pedido: {this.NumeroPedido.ToString()} - Producto: {this.DetallePedido.GetType().Name} - Estado: {this.DetallePedido.Estado}.";
        }

        #endregion

    }
}
