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
using Archivos;
using System.IO;
using System.Security;
using System.Threading;

namespace Formularios
{
    public partial class FrmMenu : Form
    {
        private FabricaDeMuebles<Muebles,Pedidos> fabricaKevin;
        private AccesoBD baseDatos;

        /// <summary>
        /// Constructor publico del formulario principal.
        /// </summary>
        public FrmMenu()
        {
            InitializeComponent();
            Bitmap fondo = new Bitmap(Application.StartupPath + @"\img\fabrica2.jpg");
            this.BackgroundImage = fondo;
            fabricaKevin = new FabricaDeMuebles<Muebles, Pedidos>();
        }

        /// <summary>
        /// Metodo que carga atributos del formulario principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.baseDatos = new AccesoBD();
            Mesa mesa = new Mesa(Terminacion.Barnizado, ColorMadera.Nogal);
            Silla silla = new Silla(Terminacion.Barnizado, ColorMadera.Nogal, Silla.ColorTapizado.Gris);
            Biblioteca biblioteca = new Biblioteca(Terminacion.Barnizado, ColorMadera.Nogal, 3);
            Pedidos pedido1 = new Pedidos(4, mesa);
            Pedidos pedido2 = new Pedidos(12, silla);
            Pedidos pedido3 = new Pedidos(25, biblioteca);
            fabricaKevin.ListaPedidos.Add(pedido1);
            fabricaKevin.ListaPedidos.Add(pedido2);
            fabricaKevin.ListaPedidos.Add(pedido3);
            baseDatos.Guardar(pedido1);
            baseDatos.Guardar(pedido2);
            baseDatos.Guardar(pedido3);
        }

        /// <summary>
        /// Boton que cierra el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo que solicita la confirmacion del cierre del programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Boton que inicia el formulario de pedidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos(fabricaKevin);
            frmPedidos.ShowDialog();
            this.fabricaKevin = frmPedidos.MostrarFabrica;
        }

        /// <summary>
        /// Boton que inicia el formulario de producción.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProduccion_Click(object sender, EventArgs e)
        {
            FrmFabrica frmFabrica = new FrmFabrica(fabricaKevin);
            frmFabrica.ShowDialog();
            this.fabricaKevin = frmFabrica.MostrarFabrica;
        }


    }
}
