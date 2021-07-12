using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Productos
{
    
    [XmlInclude(typeof(Mesa))]
    [XmlInclude(typeof(Silla))]
    [XmlInclude(typeof(Biblioteca))]
    [Serializable]
    public abstract class Muebles
    {
        private Terminacion terminacion;
        private ColorMadera color;
        private double precio;
        private string estado;

        /// <summary>
        /// Propiedad abstracta de lectura sobre el atributo consumo madera.
        /// </summary>
        public abstract int ConsumoMadera { get; set;  }

        /// <summary>
        /// Propiedad de lectura/escritura que indica el estado de un Mueble.
        /// </summary>
        public string Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que indica la terminacion que debe tener un Mueble.
        /// </summary>
        public Terminacion Terminacion
        {
            get
            {
                return this.terminacion;
            }
            set
            {
                this.terminacion = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que indica el color que debe tener un Mueble.
        /// </summary>
        public ColorMadera Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        /// <summary>
        /// Constructor publico y sin argumentos de Muebles para serializar.
        /// </summary>
        public Muebles()
        {

        }

        /// <summary>
        /// Constructor publico que inicializa los atributos del Mueble.
        /// </summary>
        public Muebles(Terminacion terminacion, ColorMadera color, double precio)
        {
            this.Terminacion = terminacion;
            this.Color = color;
            this.precio = precio;
            this.Estado = "Sin Tratamiento";
        }

        /// <summary>
        /// Metodo que retorna la informacion de un Mueble.
        /// </summary>
        /// <returns>Retorna un string con toda la informacion de un Mueble.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo de Producto: {this.GetType().Name}");
            sb.AppendLine($"Precio Unitario: {this.precio:#0.00}");
            sb.AppendLine($"Color de Madera: {this.Color}");
            sb.AppendLine($"Terminacion: {this.Terminacion}");
            sb.AppendLine($"Estado: {this.Estado}");
            
            return sb.ToString();
        }
    }

    /// <summary>
    /// Enumerado de terminaciones para Muebles.
    /// </summary>
    public enum Terminacion
    {
        Barnizado,
        Melamina,
        Laqueado
    }

    /// <summary>
    /// Enumerado de colores de madera para Muebles.
    /// </summary>
    public enum ColorMadera
    {
        Negro,
        Blanco,
        Nogal,
        Ebano,
        Roble,
        Wengue
    }
}