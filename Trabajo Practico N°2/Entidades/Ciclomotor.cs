using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {

        /// <summary>
        /// Constructor publico que inicializa los atributos, marca, chasis, color de Ciclomotor.
        /// </summary>
        /// <param name="marca">Marca a asignar al Ciclomotor.</param>
        /// <param name="chasis">Chasis a asignar al Ciclomotor.</param>
        /// <param name="color">Color a asignar al Ciclomotor.</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) 
            : base(chasis, marca, color)
        {
        }
        
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        /// <summary>
        /// Metodo que muestra la informacion de un Ciclomotor.
        /// </summary>
        /// <returns>Retorna un string con la informacion del Ciclomotor.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.Append(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
