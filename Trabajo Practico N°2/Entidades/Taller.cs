using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;

        /// <summary>
        /// Enumerador de tipos de Vehiculos.
        /// </summary>
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        #region "Constructores"

        /// <summary>
        /// Constructor privado que inicializa la lista de Vehiculos del Taller. 
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Constructor publico que inicializa los atributos espacio disponible y la lista de vehiculos del Taller.
        /// </summary>
        /// <param name="espacioDisponible">Espacio a asignar al Taller.</param>
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos.
        /// </summary>
        /// <returns>Retorna un string con la informacion de todos los vehiculos del taller.</returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias).
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="tipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>Retorna la informacion de los vehiculos de la lista segun el tipo pasado como parametro.</returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles.\n", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.SUV:

                        Suv suv = v as Suv;
                        if(!(suv is null))
                        {
                            sb.AppendLine(suv.Mostrar());
                        }
                        break;

                    case ETipo.Ciclomotor:

                        Ciclomotor ciclo = v as Ciclomotor;
                        if (!(ciclo is null))
                        {
                            sb.AppendLine(ciclo.Mostrar());
                        }
                        break;

                    case ETipo.Sedan:

                        Sedan sedan = v as Sedan;
                        if (!(sedan is null))
                        {
                            sb.AppendLine(sedan.Mostrar());
                        }
                        break;

                    default:

                        //Aca ingresa cuando sea ETipo.Todos.
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }
            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista.
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento.</param>
        /// <param name="vehiculo">Objeto a agregar.</param>
        /// <returns>Retorna la lista con el Vehiculo nuevo si lo pudo agregar, caso contrario, retorna la lista original.</returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo ||
                    taller.vehiculos.Count >= taller.espacioDisponible )
                {
                    return taller;
                }  
            }
            taller.vehiculos.Add(vehiculo);
            return taller;
        }

        /// <summary>
        /// Quitará un elemento de la lista.
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento.</param>
        /// <param name="vehiculo">Objeto a quitar.</param>
        /// <returns>Retorna la lista sin el Vehiculo brindado por paramto en caso de que exista, caso contrario, retorna la lista original.</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(vehiculo);
                    break;
                }
            }
            return taller;
        }
        #endregion
    }
}
