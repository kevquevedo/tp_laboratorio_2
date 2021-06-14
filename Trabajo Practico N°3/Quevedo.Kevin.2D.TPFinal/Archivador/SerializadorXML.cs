using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Productos;

namespace Archivos
{
    ///MARCADOR SERIALIZACION
    public class SerializadorXML<T> : IFiles<List<T>>
    {
        private string ruta;

        /// <summary>
        /// Propiedad de lectura/escritura que obtiene la ruta del archivo.
        /// </summary>
        public string Ruta
        {
            get
            {
                return this.ruta;
            }
            set
            {
                this.ruta = value;
            }
        }

        /// <summary>
        /// Constructor publico que inicializa el atributo del SerializadorXML.
        /// </summary>
        /// <param name="ruta">Ruta a asignar a SerializadorXML.</param>
        public SerializadorXML(string ruta)
        {
            this.Ruta = ruta;
        }

        /// <summary>
        /// Metodo que deserealiza un archivo XML.
        /// </summary>
        public void Guardar(List<T> objeto)
        {
            using (XmlTextWriter xml = new XmlTextWriter(this.ruta, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(xml, objeto);
            }
        }

        /// <summary>
        /// Metodo que guarda la lista de objetos y lo serializa a XML.
        /// </summary>
        /// <param name="objeto">Lista de objetos a serializar.</param>
        public List<T> Leer()
        {
            using (XmlTextReader xml = new XmlTextReader(this.Ruta))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                return (List<T>) serializer.Deserialize(xml);
            }
        }
    }
}
