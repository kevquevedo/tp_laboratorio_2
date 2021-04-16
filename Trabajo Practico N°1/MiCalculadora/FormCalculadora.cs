using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra en pantalla los datos asignados por defecto al ComboBox y al Resultado.
        /// Tambien asigna las opciones del desplegable ComboBox.
        /// </summary>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
            cmbOperador.Text = "+";
        }

        /// <summary>
        /// Limpia los datos de la aplicacion.
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
            cmbOperador.Text = "+";
            lblResultado.Text = "0";
        }

        /// <summary>
        /// Metodo que realiza la operacion entre ambos numeros seleccionados por el usuario.n.
        /// </summary>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }

        /// <summary>
        /// Botón que realiza la operacion entre ambos números. 
        /// </summary>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            lblResultado.Text = resultado.ToString();
        }

        /// <summary>
        /// Cierra la aplicación de escritorio.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Realiza la conversion del numero Decimal a Binario.
        /// </summary>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            lblResultado.Text = numero.DecimalBinario(lblResultado.Text);
        }

        /// <summary>
        /// Realiza la conversion del numero Binario a Decimal, siempre que el numero del lblResultado sea binario.
        /// </summary>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (EsBinario(lblResultado.Text))
            {
                Numero numero = new Numero();
                lblResultado.Text = numero.BinarioDecimal(lblResultado.Text);
            }
        }

        /// <summary>
        /// Valida que el string recibido sea un número binario.
        /// </summary>
        /// <param name="binario">string recibido a validar.</param>
        /// <returns>Retorna true si el string es un número binario.</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;
            foreach (char item in binario)
            {
                if (item != '1' && item != '0')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
    }
}
