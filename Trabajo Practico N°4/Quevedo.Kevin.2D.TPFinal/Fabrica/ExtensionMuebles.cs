using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;

namespace Fabrica
{
    ///METODO DE EXTENSION.
    public static class ExtensionMuebles
    {
        /// <summary>
        /// Metodo extensor de la clase Muebles.
        /// </summary>
        /// <param name="mueble"></param>
        /// <returns></returns>
        public static string InformacionPedidoExtendido(this Muebles mueble)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"El producto que usted recibió es una {mueble.GetType().Name}, la cual posee una terminacion de {mueble.Terminacion.ToString()}" +
                            $", y es de color {mueble.Color.ToString()}.");
            return sb.ToString();
        }
    }
}
