using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    [Serializable]
    public class Mesa : Muebles
    {
        private int consumoMadera = 4;
        private static double precioUnitario = 7600.00;

        /// <summary>
        /// Propiedad de lectura que indica el consumo de madera de la Mesa.
        /// </summary>
        public override int ConsumoMadera
        {
            get
            {
                return this.consumoMadera;
            }
            set
            {
                this.consumoMadera = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que indica el precio unitario de la Mesa.
        /// </summary>
        public static double PrecioUnitario
        {
            get
            {
                return Mesa.precioUnitario;
            }
            set
            {
                Mesa.precioUnitario = value;
            }
        }

        /// <summary>
        /// Constructor publico y sin argumentos de Mesa para serializar.
        /// </summary>
        public Mesa()
        {

        }

        /// <summary>
        /// Constructor publico que inicializa los atributos de la Mesa.
        /// </summary>
        public Mesa(Terminacion terminacion, ColorMadera color)
            : base(terminacion, color, Mesa.PrecioUnitario)
        {

        }

        /// <summary>
        /// Metodo que retorna la informacion de la Mesa.
        /// </summary>
        /// <returns>Retorna un string con toda la informacion de la Mesa.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }

    }
}