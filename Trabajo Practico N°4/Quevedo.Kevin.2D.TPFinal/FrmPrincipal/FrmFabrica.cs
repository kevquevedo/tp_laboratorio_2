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
using System.Threading;

namespace Formularios
{
    ///DELEGADOS
    public delegate void ActualizacionPedido(Pedidos pedido);
    public delegate void AvanceConstruccion(object objeto);

    public partial class FrmFabrica : Form
    {
        private FabricaDeMuebles<Muebles, Pedidos> fabrica2;
        private AccesoBD baseDatos;
        public event ActualizacionPedido ActPedido;
        private List<Thread> hilosConstruccion;

        /// <summary>
        /// Propiedad de lectura, que retorna la fabrica de produccion.
        /// </summary>
        public FabricaDeMuebles<Muebles, Pedidos> MostrarFabrica
        {
            get
            {
                return this.fabrica2;
            }
        }


        /// <summary>
        /// Constructor publico del formulario de producción.
        /// </summary>
        public FrmFabrica()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor publico del formulario de producción, que recibe una fabrica como parametro.
        /// </summary>
        /// <param name="fabrica">Fabrica a asignar al formulario.</param>
        public FrmFabrica(FabricaDeMuebles<Muebles, Pedidos> fabrica) : this()
        {
            this.fabrica2 = fabrica;
        }

        /// <summary>
        /// Metodo que carga atributos del formulario de producción.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFabrica_Load(object sender, EventArgs e)
        {
            this.baseDatos = new AccesoBD();
            this.hilosConstruccion = new List<Thread>();
            this.ActPedido += baseDatos.Actualizar;
            this.ActualizarEstados();
        }

        /// <summary>
        /// Boton que detalla la informacion del Pedido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DetallePedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstMueblesEspera.SelectedItem as Pedidos;
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
        /// Boton que traslada el pedido desde la lista "En Espera" a "En Proceso".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarFabricacion_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstMueblesEspera.SelectedItem as Pedidos;
                if (!(auxPedido is null))
                {
                    lstMueblesEspera.Items.Remove(auxPedido);
                    lstMueblesProceso.Items.Add(auxPedido);
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
        /// Boton que realiza el recorte de la madera necesaria para cumplir con el Pedido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Recortar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstMueblesProceso.SelectedItem as Pedidos;
                if (auxPedido != null)
                {
                    ///MARCADOR HILOS
                    Thread hiloNuevo = new Thread(new ParameterizedThreadStart(this.Recortar_Method));
                    hiloNuevo.Start(auxPedido);
                    this.hilosConstruccion.Add(hiloNuevo);
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MaderaInsuficienteException ex)
            {
                MessageBox.Show(ex.Message, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Boton que realiza el lijado de la madera necesaria para cumplir con el Pedido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_LijarMadera_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstMueblesProceso.SelectedItem as Pedidos;
                if (auxPedido != null)
                {
                    Thread hiloNuevo = new Thread(new ParameterizedThreadStart(this.Lijar_Method));
                    hiloNuevo.Start(auxPedido);
                    this.hilosConstruccion.Add(hiloNuevo);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (LijaInsuficienteException ex)
            {
                MessageBox.Show(ex.Message, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Boton que realiza el pintado y armado sobre mueble del Pedido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PintarYArmar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstMueblesProceso.SelectedItem as Pedidos;
                if (auxPedido != null)
                {
                    Thread hiloNuevo = new Thread(new ParameterizedThreadStart(this.PintarYArmar_Method));
                    hiloNuevo.Start(auxPedido);
                    this.hilosConstruccion.Add(hiloNuevo);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (PinturaYArmardoException ex)
            {
                MessageBox.Show(ex.Message, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Boton que realiza el pintado y armado sobre mueble del Pedido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Terminacion_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstMueblesProceso.SelectedItem as Pedidos;
                if (!(auxPedido is null))
                { 
                    Thread hiloNuevo = new Thread(new ParameterizedThreadStart(this.Terminacion_Method));
                    hiloNuevo.Start(auxPedido);
                    this.hilosConstruccion.Add(hiloNuevo);
                    fabrica2.TerminarTratamiento(auxPedido.DetallePedido);
                    fabrica2.ListaMuebles.Add(auxPedido.DetallePedido);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (TratamientoException ex)
            {
                MessageBox.Show(ex.Message, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Metodo privado que realiza el corte de la madera.
        /// </summary>
        /// <param name="objeto">Objeto, para el cual cortar madera.</param>
        private void Recortar_Method(object objeto)
        {
            Pedidos auxPedido = (Pedidos)objeto;
            
            try
            {
                if (this.InvokeRequired)
                {
                    fabrica2.Recortar(auxPedido.DetallePedido);
                    AvanceConstruccion avance = new AvanceConstruccion(this.Recortar_Method);
                    this.Invoke(avance, new object[] { objeto });
                }
                else
                {
                    this.ActualizarEstados();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MaderaInsuficienteException ex)
            {
                MessageBox.Show(ex.Message, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Metodo privado que realiza el lijado de la madera.
        /// </summary>
        /// <param name="objeto">Objeto, para el cual realizar el lijado madera.</param>
        private void Lijar_Method(object objeto)
        {
            Pedidos auxPedido = (Pedidos)objeto;

            try
            {
                if (this.InvokeRequired)
                {
                    fabrica2.Lijar(auxPedido.DetallePedido);
                    AvanceConstruccion avance = new AvanceConstruccion(this.Lijar_Method);
                    this.Invoke(avance, new object[] { objeto });
                }
                else
                {
                    this.ActualizarEstados();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (LijaInsuficienteException ex)
            {
                MessageBox.Show(ex.Message, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Metodo privado que realiza el pintado y armado de la madera.
        /// </summary>
        /// <param name="objeto">Objeto, sobre el cual realizar el pintado y armado del mueble.</param>
        private void PintarYArmar_Method(object objeto)
        {
            Pedidos auxPedido = (Pedidos)objeto;

            try
            {
                if (this.InvokeRequired)
                {
                    fabrica2.PintarYArmar(auxPedido.DetallePedido);
                    AvanceConstruccion avance = new AvanceConstruccion(this.PintarYArmar_Method);
                    this.Invoke(avance, new object[] { objeto });
                }
                else
                {
                    this.ActualizarEstados();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (PinturaYArmardoException ex)
            {
                MessageBox.Show(ex.Message, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Metodo privado que realiza la terminacion del mueble.
        /// </summary>
        /// <param name="objeto">Objeto, sobre el cual realizar la terminacion del mueble.</param>
        private void Terminacion_Method(object objeto)
        {
            Pedidos auxPedido = (Pedidos)objeto;

            try
            {
                if (this.InvokeRequired)
                {
                    fabrica2.TerminarTratamiento(auxPedido.DetallePedido);
                    AvanceConstruccion avance = new AvanceConstruccion(this.Terminacion_Method);
                    this.Invoke(avance, new object[] { objeto });
                }
                else
                {
                    this.ActualizarEstados();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionó ningun item de la lista.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (TratamientoException ex)
            {
                MessageBox.Show(ex.Message, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// Metodo privado que actualiza el estado de los pedidos.
        /// </summary>
        private void ActualizarEstados()
        {
            this.lstMueblesProceso.Items.Clear();
            this.lstMueblesEspera.Items.Clear();
            this.lstMueblesElaborados.Items.Clear();

            foreach (Pedidos item in this.fabrica2.ListaPedidos)
            {
                if(item.DetallePedido.Estado != "Cancelado" &&
                   item.DetallePedido.Estado != "Sin Tratamiento" &&
                   item.DetallePedido.Estado != "Terminado")
                {
                    this.lstMueblesProceso.Items.Add(item);
                    this.ActPedido.Invoke(item); ///EVENTOS 
                }
                else if(item.DetallePedido.Estado == "Terminado")
                {
                    this.lstMueblesElaborados.Items.Add(item);
                }
                else
                {
                    this.lstMueblesEspera.Items.Add(item);
                }
                
            }
        }

        /// <summary>
        /// Metodo que finaliza todos los hilos creados.
        /// </summary>
        private void CerrarApp()
        {
            foreach (Thread item in this.hilosConstruccion)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }

        /// <summary>
        /// Metodo que solicita la confirmacion del cierre del formulario de produccion.En caso de confirmar, aborta los hilos en ejecucion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFabrica_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir de la seccion fabrica?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.CerrarApp();
            }
        }
    }
}
