using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    [Serializable]
    public class Silla : Muebles
    {
        private int consumoMadera = 2;
        private ColorTapizado tapizado;
        private static double precioUnitario = 3200.00;

        /// <summary>
        /// Propiedad de lectura que indica el consumo de madera de la Silla.
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
        /// Propiedad de lectura/escritura que indica el precio unitario de la Silla.
        /// </summary>
        public static double PrecioUnitario
        {
            get
            {
                return Silla.precioUnitario;
            }
            set
            {
                Silla.precioUnitario = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que indica el color de tapizado de la Silla.
        /// </summary>
        public ColorTapizado Tapizado
        {
            get
            {
                return this.tapizado;
            }
            set
            {
                this.tapizado = value;
            }
        }

        /// <summary>
        /// Constructor publico y sin argumentos de Silla para serializar.
        /// </summary>
        public Silla()
        {

        }

        /// <summary>
        /// Constructor publico que inicializa los atributos de la Silla.
        /// </summary>
        public Silla(Terminacion terminacion, ColorMadera color, ColorTapizado tapizado)
            : base(terminacion, color, Silla.PrecioUnitario)
        {
            this.Tapizado = tapizado;
        }

        /// <summary>
        /// Metodo que retorna la informacion de la Silla.
        /// </summary>
        /// <returns>Retorna un string con toda la informacion de la Silla.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Color Tapizado: {this.Tapizado}");
            return sb.ToString();
        }

        /// <summary>
        /// Enumerado de colores de tapizados para Silla.
        /// </summary>
        public enum ColorTapizado
        {
            Blanco,
            Gris,
            Negro
        }
    }
}