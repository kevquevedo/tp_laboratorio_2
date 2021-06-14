using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    ///MARCADOR INTERFACES
    public interface IFiles<T>
    {
        /// <summary>
        /// Metodo que se utiliza para guardar archivos.
        /// </summary>
        /// <param name="objeto">Recibe un tipo generico de objeto.</param>
        void Guardar(T objeto);

        /// <summary>
        /// Metodo que se utiliza para leer archivos.
        /// </summary>
        /// <returns>Retorna la informacion ubicada en el archivo, y lo retorna del tipo generico.</returns>
        T Leer();
    }
}
