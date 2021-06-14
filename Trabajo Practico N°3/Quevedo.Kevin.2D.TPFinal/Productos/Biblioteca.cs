using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    [Serializable]
    public class Biblioteca : Muebles
    {
        private int consumoMadera = 5;
        private int cantidadEstantes;
        private static double precioUnitario = 5500.50;

        /// <summary>
        /// Propiedad de lectura que indica el consumo de madera de la Biblioteca.
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
                return Biblioteca.precioUnitario;
            }
            set
            {
                Biblioteca.precioUnitario = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que indica la cantidad de estantes de la Biblioteca.
        /// </summary>
        public int CantidadEstantes
        {
            get
            {
                return this.cantidadEstantes;
            }
            set
            {
                this.cantidadEstantes = value;
            }
        }

        /// <summary>
        /// Constructor publico y sin argumentos de Biblioteca para serializar.
        /// </summary>
        public Biblioteca()
        {

        }

        /// <summary>
        /// Constructor publico que inicializa los atributos de la Biblioteca.
        /// </summary>
        public Biblioteca(Terminacion terminacion, ColorMadera color, int cantidadEstantes)
            : base(terminacion, color, Biblioteca.PrecioUnitario)
        {
            this.CantidadEstantes = cantidadEstantes;
        }

        /// <summary>
        /// Metodo que retorna la informacion de la Biblioteca.
        /// </summary>
        /// <returns>Retorna un string con toda la informacion de la Biblioteca.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Cantidad de Estantes: {this.CantidadEstantes}");
            return sb.ToString();
        }
    }
}