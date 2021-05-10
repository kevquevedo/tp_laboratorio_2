using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        
        private ETipo tipo;

        /// <summary>
        /// Enumerador de tipos de Sedan.
        /// </summary>
        public enum ETipo 
        { 
            CuatroPuertas, 
            CincoPuertas 
        }

        /// <summary>
        /// Constructor publico que inicializa los atributos, marca, chasis, color y tipo (Por defecto cuatro puertas) de Sedan.
        /// </summary>
        /// <param name="marca">Marca a asignar al Sedan.</param>
        /// <param name="chasis">Chasis a asignar al Sedan.</param>
        /// <param name="color">Color a asignar al Sedan.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Constructor publico que inicializa los atributos, marca, chasis, color y tipo de Sedan.
        /// </summary>
        /// <param name="marca">Marca a asignar al Sedan.</param>
        /// <param name="chasis">Chasis a asignar al Sedan.</param>
        /// <param name="color">Color a asignar al Sedan.</param>
        /// <param name="tipo">Tipo a asignar al Sedan.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) 
            : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Metodo que muestra la informacion de un Sedan.
        /// </summary>
        /// <returns>Retorna un string con la informacion del Sedan.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.Append(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
