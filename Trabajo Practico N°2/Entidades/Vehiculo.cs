using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        private string chasis;
        private EMarca marca;
        private ConsoleColor color;

        /// <summary>
        /// Enumerador de marcas de Vehiculos.
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }

        /// <summary>
        /// Enumerador de tamaños de Vehiculos.
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        /// <summary>
        /// Constructor publico que inicializa los atributos chasis, motor y color del Vehiculo.
        /// </summary>
        /// <param name="chasis">Chasis a asignar al Vehiculo.</param>
        /// <param name="marca">Marca a asignar al Vehiculo.</param>
        /// <param name="color">Color a asignar al Vehiculo.</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>Retorna un string con los datos del Vehiculo.</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Operador de devuelve los datos del vehiculo brindado por parametro.
        /// </summary>
        /// <param name="p">Vehiculo del cual mostrar datos.</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            //sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis.
        /// </summary>
        /// <param name="v1">Primer Vehiculo a comparar.</param>
        /// <param name="v2">Segundo Vehiculo a comparar.</param>
        /// <returns>Retorna TRUE, si los Vehiculos tienen el mismo chasis.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto.
        /// </summary>
        /// <param name="v1">Primer Vehiculo a comparar.</param>
        /// <param name="v2">Segundo Vehiculo a comparar.</param>
        /// <returns>Retorna TRUE, si los Vehiculos tienen distintos chasis.</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
    }


}
