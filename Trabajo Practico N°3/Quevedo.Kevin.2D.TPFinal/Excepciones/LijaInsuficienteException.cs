using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class LijaInsuficienteException : Exception
    {
        /// <summary>
        /// Constructor publico sin parametros, el cual posee un mensaje por defecto.
        /// </summary>
        public LijaInsuficienteException()
            : base("No existe lija suficiente para lijar el mueble requerido.")
        {

        }

        /// <summary>
        /// Constructor publico, que recibe un mensaje personalizado por parametro.
        /// </summary>
        /// <param name="mensaje">Mensaje personalizado.</param>
        public LijaInsuficienteException(string mensaje)
            : this(mensaje, null)
        {

        }

        /// <summary>
        /// Constructor publico, que recibe un mensaje personalizado y una innerException.
        /// </summary>
        /// <param name="mensaje">Mensaje personalizado.</param>
        /// <param name="innerException">InnerException a mostrar.</param>
        public LijaInsuficienteException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }
    }
}
