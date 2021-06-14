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

namespace Formularios
{
    public partial class FrmFabrica : Form
    {
        private FabricaDeMuebles<Muebles, Pedidos> fabrica2;


        public FrmFabrica()
        {
            InitializeComponent();
        }

        private void FrmFabrica_Load(object sender, EventArgs e)
        {
            foreach (Pedidos item in this.fabrica2.ListaPedidos)
            {
                lstMueblesEspera.Items.Add(item);
            }
        }

        public FrmFabrica(FabricaDeMuebles<Muebles, Pedidos> fabrica) : this()
        {
            this.fabrica2 = fabrica;
        }

        public FabricaDeMuebles<Muebles, Pedidos> MostrarFabrica
        {
            get
            {
                return this.fabrica2;
            }
        }

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
        }

        private void btn_Recortar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstMueblesEspera.SelectedItem as Pedidos;
                if (auxPedido != null)
                {
                    lstMueblesEspera.Items.Remove(auxPedido);
                    lstMueblesProceso.Items.Add(auxPedido);
                    fabrica2.Recortar(auxPedido.DetallePedido);
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

        }

        private void btn_LijarMadera_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstMueblesProceso.SelectedItem as Pedidos;
                if (auxPedido != null)
                {
                    fabrica2.Lijar(auxPedido.DetallePedido);
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
        }


        private void btn_PintarYArmar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstMueblesProceso.SelectedItem as Pedidos;
                if (auxPedido != null)
                {
                    fabrica2.PintarYArmar(auxPedido.DetallePedido);
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
        }

        private void btn_Terminacion_Click(object sender, EventArgs e)
        {
            try
            {
                Pedidos auxPedido = lstMueblesProceso.SelectedItem as Pedidos;
                if (auxPedido != null)
                {
                    lstMueblesProceso.Items.Remove(auxPedido);
                    lstMueblesElaborados.Items.Add(auxPedido);
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
        }
    }
}
