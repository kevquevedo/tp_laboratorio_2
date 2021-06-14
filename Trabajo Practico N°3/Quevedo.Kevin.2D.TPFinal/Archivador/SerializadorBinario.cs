using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Productos;
using System.Runtime.Serialization.Formatters.Binary;

namespace Archivos
{
    ///MARCADOR SERIALIZACION
    public class SerializadorBinario<T> : IFiles<List<T>>
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
        /// Constructor publico que inicializa el atributo del SerializadorBinario.
        /// </summary>
        /// <param name="ruta">Ruta a asignar a SerializadorBinario.</param>
        public SerializadorBinario(string ruta)
        {
            this.Ruta = ruta;
        }

        /// <summary>
        /// Metodo que guarda la lista de objetos y lo serializa a Binario.
        /// </summary>
        /// <param name="objeto">Lista de objetos a serializar.</param>
        public void Guardar(List<T> objeto)
        {
            using (Stream stream = new FileStream(this.Ruta, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, objeto);
            }
        }

        /// <summary>
        /// Metodo que deserealiza un archivo Binario.
        /// </summary>
        public List<T> Leer()
        {
            using (Stream stream = new FileStream(this.Ruta, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (List<T>)formatter.Deserialize(stream);
            }
        }
    }
}
