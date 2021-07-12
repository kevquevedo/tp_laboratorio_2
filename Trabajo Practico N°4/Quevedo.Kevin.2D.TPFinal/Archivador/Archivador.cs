using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    ///MARCADOR ARCHIVOS
    public class Archivador : IFiles<string> 
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
        /// Constructor publico que inicializa el atributo de Archivador.
        /// </summary>
        /// <param name="ruta">Ruta a asignar a Archivador.</param>
        public Archivador(string ruta)
        {
            this.Ruta = ruta;
        }

        /// <summary>
        /// Metodo que escribe determinado texto en un archivo.
        /// </summary>
        /// <param name="texto">Texto a escribir en el archivo.</param>
        public void Guardar(string texto)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(this.Ruta);
                sw.WriteLine(texto);
            }
            finally
            {
                if(!(sw is null))
                {
                    sw.Close();
                }
            }
        }

        /// <summary>
        /// Metodo que lee determinado texto de un archivo.
        /// </summary>
        /// <returns>Retorna un string, con lo que pudo leer del archivo.</returns>
        public string Leer()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(this.Ruta);
                return sr.ReadToEnd();
            }
            finally
            {
                if (!(sr is null))
                {
                    sr.Close();
                }
            }
        }


    }
}
