using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Constructor que inicializa el atributo numero de Numero.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor que asigna el tipo de dato double al atributo numero.
        /// </summary>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que asigna el tipo de dato double al atributo numero.
        /// </summary>
        public Numero(string strNumero) : this()
        {
            this.SetNumero = strNumero;
        }

        /// <summary>
        /// Método que válida que un string sea un número.
        /// </summary>
        /// <param name="strNumero">string a validar.</param>
        /// <returns>Retorna el valor numerico del string es caso ser válido, caso contrario retorna 0.</returns>
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            if (double.TryParse(strNumero, out double esNumero))
            {
                retorno = esNumero;
            }
            return retorno;
        }

        /// <summary>
        /// Propiedas que setea el numero recibido como string al objeto Numero.
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Operador que realiza la suma entre dos números.
        /// </summary>
        /// <param name="num1">Primer numero para realizar la operación.</param>
        /// <param name="num2">Segundo numero para realizar la operación.</param>
        /// <returns>Retorna el valor de la suma entre los números.</returns>
        public static double operator +(Numero num1, Numero num2)
        {
            double resultado = num1.numero + num2.numero;
            return resultado;
        }

        /// <summary>
        /// Operador que realiza la resta entre dos números.
        /// </summary>
        /// <param name="num1">Primer numero para realizar la operación.</param>
        /// <param name="num2">Segundo numero para realizar la operación.</param>
        /// <returns>Retorna el valor de la resta entre los números.</returns>
        public static double operator -(Numero num1, Numero num2)
        {
            double resultado = num1.numero - num2.numero;
            return resultado;
        }

        /// <summary>
        /// Operador que realiza la multiplicación entre dos números.
        /// </summary>
        /// <param name="num1">Primer numero para realizar la operación.</param>
        /// <param name="num2">Segundo numero para realizar la operación.</param>
        /// <returns>Retorna el valor de la multiplicación entre los números.</returns>
        public static double operator *(Numero num1, Numero num2)
        {
            double resultado = num1.numero * num2.numero;
            return resultado;
        }

        /// <summary>
        /// Operador que realiza la división entre dos números.
        /// </summary>
        /// <param name="num1">Primer numero para realizar la operación.</param>
        /// <param name="num2">Segundo numero para realizar la operación.</param>
        /// <returns>Retorna el valor de la división entre los números.</returns>
        public static double operator /(Numero num1, Numero num2)
        {
            double resultado = double.MinValue;
            //Si el segundo numero no es cero realiza la operación,
            //Caso contrario, retorna MinValue.
            if (num2.numero != 0)
            {
                resultado = num1.numero / num2.numero;
            }
            return resultado;
        }

        /// <summary>
        /// Valida que el string recibido sea un número binario.
        /// </summary>
        /// <param name="binario">string recibido a validar.</param>
        /// <returns>Retorna true si el string es un número binario.</returns>
        private bool EsBinario(string binario)
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

        /// <summary>
        /// Convierte el string recibido como Binario a Decimal.
        /// </summary>
        /// <param name="binario"> Valor recibido como tipo de dato string a validar. </param>
        /// <returns> Retorna el string con el numero decimal, en caso de que el valor recibido sea binario. Caso contrario, devuelve "Valor inválido". </returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido.";
            double valorAbs = Math.Abs(ValidarNumero(binario));
            string numeroAbsBinario = valorAbs.ToString();

            foreach (char item in numeroAbsBinario)//Recorre el string recibido en tipo de dato char.
            {
                if (EsBinario(Convert.ToString(item)))//Convierte del tipo de dato char auxiliar a string, y valida si es binario utilizando metodo EsBinario.
                {
                    retorno = Convert.ToInt64(binario, 2).ToString();//Si pasa las validaciones del if, convierte el numero binario a decimal. A su vez, lo concatena en string.
                }
            }
            return retorno;
        }

        /// <summary>
        /// Convierte el numero recibido como Decimal a Binario.
        /// </summary>
        /// <param name="numero"> Valor recibido como tipo de dato string a validar. </param>
        /// <returns> Retorna el numero recibido, en formato string en caso de que se realice correctamente. En caso de no ser válido, retorna 0 (cero). </returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "Valor inválido";

            if (double.TryParse(numero, out double auxNumero))
            {
                retorno = DecimalBinario(auxNumero);//Si puede convertir el valor recibido al tipo de dato double, reutiliza la variable DecimalBinario(string).
            }

            return retorno;
        }

        /// <summary>
        /// Convierte el numero recibido como Decimal a Binario, validando que sea mayor a 0 (cero).
        /// </summary>
        /// <param name="numero"> Valor recibido como tipo de dato double a validar. </param>
        /// <returns> Retorna el string con el numero binario, en caso de que el valor recibido sea decimal. Caso contrario, devuelve "Valor inválido". </returns>
        public string DecimalBinario(double numero)
        {
            string retorno = "Valor inválido";
            long auxNumeroLong = Convert.ToInt64(Math.Abs(numero));//Obtiene el valor absoluto del numero brindado como parametro y lo convierte al tipo de dato long.

            if (numero > 0)
            {
                retorno = Convert.ToString(auxNumeroLong, 2);//Convierte el numero a binario y lo transforma el tipo de dato string.
            }

            return retorno;
        }
    }
}
