using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productos;
using Excepciones;


namespace Fabrica
{
    ///MARCADOR TIPO GENERICO
    public class FabricaDeMuebles<T, U>
        where T : Muebles
        where U : Pedidos
    {
        private const int gastoDeLijaPorMueble = 2;
        private List<T> muebles;
        private List<U> pedidos;
        private int planchasDeMadera;
        private int hojasDeLija;

        #region PROPIEDADES

        /// <summary>
        /// Propiedad de lectura que devuelve la lista de Muebles.
        /// </summary>
        public List<T> ListaMuebles
        {
            get
            {
                return this.muebles;
            }
        }

        /// <summary>
        /// Propiedad de lectura que devuelve la lista de Pedidos.
        /// </summary>
        public List<U> ListaPedidos
        {
            get
            {
                return this.pedidos;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que retorna y asigna la cantidad de planchas de madera.
        /// </summary>
        public int PlanchasMadera
        {
            get
            {
                return this.planchasDeMadera;
            }
            set
            {
                this.planchasDeMadera = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura/escritura que retorna y asigna la cantidad de hojas de lija.
        /// </summary>
        public int HojasLija
        {
            get
            {
                return this.hojasDeLija;
            }
            set
            {
                this.hojasDeLija = value;
            }
        }

        #endregion

        #region CONSTRUCTOR

        /// <summary>
        /// Constructor publico que inicializa los atributos de FabricaDeMuebles.
        /// </summary>
        public FabricaDeMuebles()
        {
            this.muebles = new List<T>();
            this.pedidos = new List<U>();
            this.PlanchasMadera = 8;
            this.HojasLija = 4;
        }

        #endregion

        #region METODOS Y OPERADORES


        /// <summary>
        /// Metodo que recorta la madera para producir el Mueble.
        /// </summary>
        /// <param name="mueble">Mueble a producir.</param>
        /// <returns>Retorna TRUE si existe stock de Madera suficiente y pudo procesarlo, caso contrario, retorna FALSE.</returns>
        public bool Recortar(T mueble)
        {
            bool retorno = false;
            if ((this.PlanchasMadera - mueble.ConsumoMadera) >= 0)
            {
                this.PlanchasMadera -= mueble.ConsumoMadera;
                retorno = true;
            }
            else
            {
                throw new MaderaInsuficienteException();
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que lija la madera para de Mueble.
        /// </summary>
        /// <param name="mueble">Mueble a lijar.</param>
        /// <returns>Retorna TRUE si existe stock de Lija suficiente y pudo procesarlo, caso contrario, retorna FALSE.</returns>
        public bool Lijar(T mueble)
        {
            bool retorno = false;
            if ((this.hojasDeLija - FabricaDeMuebles<Muebles, Pedidos>.gastoDeLijaPorMueble) >= 0)
            {
                this.HojasLija -= FabricaDeMuebles<Muebles, Pedidos>.gastoDeLijaPorMueble;
                mueble.EstaLijado = true;
                retorno = true;
            }
            else
            {
                throw new LijaInsuficienteException();
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que pinta y arma el Mueble.
        /// </summary>
        /// <param name="mueble">Mueble a pintar y armar.</param>
        /// <returns>Retorna TRUE si pudo pintarlo y armarlo, caso contrario, retorna FALSE.</returns>
        public bool PintarYArmar(T mueble)
        {
            bool retorno = false;
            if(mueble.EstaLijado)
            {
                mueble.EstaPintado = true;
                retorno = true;
            }
            else
            {
                throw new PinturaYArmardoException();
            }

            return retorno;
        }

        /// <summary>
        /// Metodo realiza la terminacion del Mueble.
        /// </summary>
        /// <param name="mueble">Mueble a terminar.</param>
        /// <returns>Retorna TRUE si pudo terminarlo correctamente, caso contrario, retorna FALSE.</returns>
        public bool TerminarTratamiento(T mueble)
        {
            bool retorno = false;   
            if (mueble.EstaLijado &&
                mueble.EstaPintado)
            {
                mueble.Estado = true;
                retorno = true;
            }
            else
            {
                throw new TratamientoException();
            }
            return retorno;
        }

        /// <summary>
        /// Operador que incorpora un Pedido a la Fabrica.
        /// </summary>
        /// <param name="fabrica">Fabrica a la cual se incorpora el Pedido.</param>
        /// <param name="pedido">Pedido a agregar en la Fabrica.</param>
        /// <returns>Retorna TRUE, si el Pedido fue agregada a la Fabrica.</returns>
        public static bool operator +(FabricaDeMuebles<T, U> fabrica, U pedido)
        {
            bool retorno = true;

            foreach (Pedidos item in fabrica.ListaPedidos)
            {
                if (item == pedido)
                {
                    retorno = false;
                    break;
                }
            }
            if (retorno)
            {
                fabrica.ListaPedidos.Add(pedido);
            }
            else
            {
                throw new PedidoNoAgregadoException();
            }
            return retorno;
        }

        /// <summary>
        /// Operador que elimina un Pedido a la Fabrica.
        /// </summary>
        /// <param name="fabrica">Fabrica de la cual eliminar el Pedido.</param>
        /// <param name="pedido">Pedido a eliminar en la Fabrica.</param>
        /// <returns>Retorna TRUE, si el Pedido fue eliminado de la Fabrica.</returns>
        public static bool operator -(FabricaDeMuebles<T,U> fabrica, U pedido)
        {
            bool retorno = false;
            foreach (Pedidos item in fabrica.ListaPedidos)
            {
                if (item == pedido)
                {
                    fabrica.ListaPedidos.Remove(pedido);
                    retorno = true;
                    break;
                }
            }
            if (!retorno)
            {
                throw new PedidoNoEliminadoException();
            }
            return retorno;
        }

        #endregion





    }
}
