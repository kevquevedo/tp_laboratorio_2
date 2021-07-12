using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Fabrica;


namespace Archivos
{
    ///MARCADOR SQLYBASESDEDATOS
    
    public class AccesoBD
    {

        private SqlConnection connection;
        private SqlCommand command;
        private static string connectionString = @" Server = .\SQLEXPRESS ; Database = TP4 ; Trusted_Connection = true ; ";

        /// <summary>
        /// Metodo que guarda en la base de datos el pedido recibido como parametro.
        /// </summary>
        /// <param name="pedido">Pedido a guardar en la base.</param>
        /// <returns>Retorna TRUE si lo pudo guardar correctamente, caso contrario retorna FALSE.</returns>
        public bool Guardar(Pedidos pedido)
        {
            bool retorno = false;
            try
            {
                connection = new SqlConnection(connectionString);
                
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                connection.Open();

                command.CommandText = "INSERT INTO pedidos (nro_pedido,tipo_mueble,color,terminacion,estado) VALUES (@nro_pedido,@tipo_mueble,@color,@terminacion,@estado);";
                command.Parameters.AddWithValue("@nro_pedido", pedido.NumeroPedido);
                command.Parameters.AddWithValue("@tipo_mueble", pedido.DetallePedido.GetType().Name);
                command.Parameters.AddWithValue("@color", pedido.DetallePedido.Color.ToString());
                command.Parameters.AddWithValue("@terminacion", pedido.DetallePedido.Terminacion.ToString());
                command.Parameters.AddWithValue("@estado", pedido.DetallePedido.Estado);

                command.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                } 
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que actualiza el estado del pedido que recibe como parametro.
        /// </summary>
        /// <param name="pedido">Pedido a actualizar el estado.</param>
        public void Actualizar(Pedidos pedido)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE pedidos SET estado = (@estado) WHERE nro_pedido = (@nro_pedido);";
                command.Parameters.AddWithValue("@nro_pedido", pedido.NumeroPedido);
                command.Parameters.AddWithValue("@estado", pedido.DetallePedido.Estado);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        /// <summary>
        /// Obtiene la informacion de todos los registros existentes en la base de datos.
        /// </summary>
        /// <returns>Retorna un string con la informacion de todos los pedidos de la base de datos.</returns>
        public string Cargar()
        {
            try
            {
                string rows = string.Empty;
                connection = new SqlConnection(connectionString);
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT nro_pedido,tipo_mueble,color,terminacion,estado FROM pedidos ORDER BY nro_pedido ASC;";
               
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    rows += $"Nro. Pedido = {dataReader["nro_pedido"].ToString()} / Tipo Mueble: {dataReader["tipo_mueble"].ToString()}" +
                            $" / Color = {dataReader["color"].ToString()} / Terminacion: {dataReader["terminacion"].ToString()}" + 
                            $" / Estado: {dataReader["estado"].ToString()}\n";
                }
                return rows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                } 
            }
        }
    }
}
