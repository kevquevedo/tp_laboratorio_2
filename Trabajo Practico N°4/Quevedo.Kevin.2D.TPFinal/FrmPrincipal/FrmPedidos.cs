using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabrica;
using Productos;
using Excepciones;
using Archivos;
using System.IO;
using System.Security;

namespace Formularios
{
    public partial class FrmPedidos : Form
    {
        private FabricaDeMuebles<Muebles, Pedidos> fabrica1;
        private AccesoBD guardarBD;
        public event ActualizacionPedido ActPedido;

        /// <summary>
        /// Propiedad de lectura, que retorna la fabrica de pedidos.
        /// </summary>
        public FabricaDeMuebles<Muebles, Pedidos> MostrarFabrica
        {
            get
            {
                return this.fabrica1;
            }
        }



        /// <summary>
        /// Constructor publico del formulario de pedidos.
        /// </summary>
        public FrmPedidos()
        {
            InitializeComponent();
            cmbTipoMueble.SelectedIndex = 0;
            cmbNumeroEstantes.SelectedIndex = 0;
            cmbColorMueble.DataSource = Enum.GetValues(typeof(ColorMadera));
            cmbTerminacionMueble.DataSource = Enum.GetValues(typeof(Terminacion));
            cmbColorTapizado.DataSource = Enum.GetValues(typeof(Silla.ColorTapizado));
        }



        /// <summary>
        /// Constructor publico del formulario de pedidos, que recibe una fabrica como parametro.
        /// </summary>
        /// <param name="fabrica">Fabrica a asignar al formulario.</param>
        public FrmPedidos(FabricaDeMuebles<Muebles, Pedidos> fabrica) : this()
        {
            this.fabrica1 = fabrica;
        }

        /// <summary>
        /// Metodo que carga atributos del formulario de pedidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            guardarBD = new AccesoBD();
            this.ActPedido += guardarBD.Actualizar;
            foreach (Pedidos item in this.fabrica1.ListaPedidos)
            {
                lstPedidosGenerados.Items.Add(item);
            }
        }



        /// <summary>
        /// Boton que cancela el pedido seleccionado en la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CancelarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstPedidosGenerados.SelectedItem as Pedidos;
                if (auxPedido != null &&
                    fabrica1 - auxPedido)
                {
                    lstPedidosGenerados.Items.Remove(auxPedido);
                    auxPedido.DetallePedido.Estado = "Cancelado";
                    this.ActPedido.Invoke(auxPedido);
                    MessageBox.Show("Se canceló el pedido.");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (PedidoNoEliminadoException ex)
            {
                MessageBox.Show(ex.Message, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        /// <summary>
        /// Boton que imprime la informacion de un pedido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InformacionPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstPedidosGenerados.SelectedItem as Pedidos;
                if (auxPedido != null)
                {
                    MessageBox.Show(auxPedido.InformacionPedido());
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        /// <summary>
        /// Boton para agregar un pedido a la fabrica.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AgregarPedido_Click(object sender, EventArgs e)
        {
            Pedidos pedido = null;
            if (double.TryParse(txtNumeroPedido.Text, out double numeroParseado))
            {
                switch (cmbTipoMueble.Text)
                {

                    case "Mesa":

                        Mesa mesa = new Mesa((Terminacion)cmbTerminacionMueble.SelectedItem, (ColorMadera)cmbColorMueble.SelectedItem);
                        pedido = new Pedidos(numeroParseado, mesa);
                        break;

                    case "Silla":

                        Silla silla = new Silla((Terminacion)cmbTerminacionMueble.SelectedItem, (ColorMadera)cmbColorMueble.SelectedItem, (Silla.ColorTapizado)cmbColorTapizado.SelectedItem);
                        pedido = new Pedidos(numeroParseado, silla);
                        break;

                    case "Biblioteca":

                        Biblioteca biblioteca = new Biblioteca((Terminacion)cmbTerminacionMueble.SelectedItem, (ColorMadera)cmbColorMueble.SelectedItem, 3);
                        pedido = new Pedidos(numeroParseado, biblioteca);
                        break;

                    default:
                        break;
                }
                
                try
                {
                    if (pedido != null &&
                        fabrica1 + pedido)
                    {
                        guardarBD.Guardar(pedido);
                        lstPedidosGenerados.Items.Add(pedido);
                        MessageBox.Show("Se agregó correctamente el pedido.");
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (PedidoNoAgregadoException ex)
                {
                    MessageBox.Show(ex.Message, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se ingresó un numero de pedido válido.");
            }

        }

        /// <summary>
        /// Boton que imprime el comprobante de un pedido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ImprimirComprobante_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstPedidosGenerados.SelectedItem as Pedidos;
                if (auxPedido != null)
                {
                    string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Comprobante-Kevin-Quevedo.txt";
                    Archivador archivador = new Archivador(ruta);
                    archivador.Guardar(auxPedido.InformacionPedido());
                    MessageBox.Show("Se guardó el archivo con exito!");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("La ruta de acceso es null.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Los caracteres de la ruta, no son validos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo no existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("El directorio no existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("La ruta supera la longitud maxima.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException)
            {
                MessageBox.Show("El archivo está en uso.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("La ruta contiene dos puntos o un formato invalido.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SecurityException)
            {
                MessageBox.Show("El usuario no posee permisos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Boton que imprime el registro historico de los pedidos existentes en la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LeerPedido_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\RegistroHistorico-Kevin-Quevedo.txt";
                Archivador archivador = new Archivador(ruta);
                archivador.Guardar(guardarBD.Cargar());
                MessageBox.Show("Se guardó el archivo con exito!");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("La ruta de acceso es null.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Los caracteres de la ruta, no son validos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("El archivo no existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("El directorio no existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("La ruta supera la longitud maxima.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException)
            {
                MessageBox.Show("El archivo está en uso.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NotSupportedException)
            {
                MessageBox.Show("La ruta contiene dos puntos o un formato invalido.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SecurityException)
            {
                MessageBox.Show("El usuario no posee permisos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Boton que guarda en un archivo una lista de pedidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarLista_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    SerializadorBinario<Pedidos> archivoSerializable = new SerializadorBinario<Pedidos>(saveFileDialog.FileName);
                    archivoSerializable.Guardar(fabrica1.ListaPedidos);
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("La ruta de acceso es null.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Los caracteres de la ruta, no son validos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("El archivo no existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("El directorio no existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show("La ruta supera la longitud maxima.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (IOException)
                {
                    MessageBox.Show("El archivo está en uso.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NotSupportedException)
                {
                    MessageBox.Show("La ruta contiene dos puntos o un formato invalido.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (SecurityException)
                {
                    MessageBox.Show("El usuario no posee permisos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Boton que carga una lista de pedidos existente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    SerializadorBinario<Pedidos> archivoSerializable = new SerializadorBinario<Pedidos>(openFileDialog.FileName);
                    List<Pedidos> pedidos = archivoSerializable.Leer();
                    if (pedidos != null)
                    {
                        fabrica1.ListaPedidos = pedidos;
                        foreach (Pedidos item in fabrica1.ListaPedidos)
                        {
                            lstPedidosGenerados.Items.Add(item);
                        }
                    }
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("La ruta de acceso es null.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Los caracteres de la ruta, no son validos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("El archivo no existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("El directorio no existe.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show("La ruta supera la longitud maxima.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (IOException)
                {
                    MessageBox.Show("El archivo está en uso.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NotSupportedException)
                {
                    MessageBox.Show("La ruta contiene dos puntos o un formato invalido.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (SecurityException)
                {
                    MessageBox.Show("El usuario no posee permisos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Combo box que asigna estados a los atributos del mismo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTipoMueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMueble.Text == "Silla")
            {
                cmbColorTapizado.Enabled = true;
                cmbColorTapizado.Visible = true;
                lbl_ColorTapizado.Visible = true;
            }
            else
            {
                cmbColorTapizado.Enabled = false;
                cmbColorTapizado.Visible = false;
                lbl_ColorTapizado.Visible = false;
            }

            if (cmbTipoMueble.Text == "Biblioteca")
            {
                cmbNumeroEstantes.Visible = true;
                lbl_NumeroEstantes.Visible = true;
                cmbNumeroEstantes.Enabled = true;
            }
            else
            {
                cmbNumeroEstantes.Visible = false;
                lbl_NumeroEstantes.Visible = false;
                cmbNumeroEstantes.Enabled = false;
            }

        }


    }
}
