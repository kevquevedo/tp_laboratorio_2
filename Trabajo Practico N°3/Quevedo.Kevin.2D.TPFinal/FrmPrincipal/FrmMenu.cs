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

namespace Formularios
{
    public partial class FrmMenu : Form
    {
        private FabricaDeMuebles<Muebles,Pedidos> fabricaKevin;

        public FrmMenu()
        {
            InitializeComponent();
            fabricaKevin = new FabricaDeMuebles<Muebles, Pedidos>();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa(Terminacion.Barnizado, ColorMadera.Nogal);
            Silla silla = new Silla(Terminacion.Barnizado, ColorMadera.Nogal, Silla.ColorTapizado.Gris);
            Biblioteca biblioteca = new Biblioteca(Terminacion.Barnizado, ColorMadera.Nogal, 3);
            Pedidos pedido1 = new Pedidos(4, mesa);
            Pedidos pedido2 = new Pedidos(12, silla);
            Pedidos pedido3 = new Pedidos(25, biblioteca);
            fabricaKevin.ListaPedidos.Add(pedido1);
            fabricaKevin.ListaPedidos.Add(pedido2);
            fabricaKevin.ListaPedidos.Add(pedido3);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos(fabricaKevin);
            frmPedidos.ShowDialog();
            this.fabricaKevin = frmPedidos.MostrarFabrica;
        }


        private void btnProduccion_Click(object sender, EventArgs e)
        {
            FrmFabrica frmFabrica = new FrmFabrica(fabricaKevin);
            frmFabrica.ShowDialog();
            this.fabricaKevin = frmFabrica.MostrarFabrica;
        }
    }
}
