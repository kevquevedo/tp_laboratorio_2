using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class PedidoNoAgregadoException : Exception
    {
        /// <summary>
        /// Constructor publico sin parametros, el cual posee un mensaje por defecto.
        /// </summary>
        public PedidoNoAgregadoException()
            : base("El numero de pedido ya existe.")
        {

        }

        /// <summary>
        /// Constructor publico, que recibe un mensaje personalizado por parametro.
        /// </summary>
        /// <param name="mensaje">Mensaje personalizado.</param>
        public PedidoNoAgregadoException(string mensaje)
            : this(mensaje, null)
        {

        }

        /// <summary>
        /// Constructor publico, que recibe un mensaje personalizado y una innerException.
        /// </summary>
        /// <param name="mensaje">Mensaje personalizado.</param>
        /// <param name="innerException">InnerException a mostrar.</param>
        public PedidoNoAgregadoException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }
    }
}
