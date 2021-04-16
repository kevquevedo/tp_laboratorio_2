using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Verifica que el operador recibido sea un operador válido ('+','-','*','/').
        /// </summary>
        /// <param name="operador">Caracter recibido a evaluar si es operador.</param>
        /// <returns>Retorna el operador recibido, en caso de no ser valido, retorna '+'</returns>
        private static string ValidarOperador(char operador)
        {
            string retorno = "+";
            if (operador == '/' || operador == '*' ||
                operador == '-' || operador == '+')
            {
                retorno = operador.ToString();
            }
            return retorno;
        }

        /// <summary>
        /// Realiza una operación suma, resta, multiplicación o división entre dos numeros.
        /// </summary>
        /// <param name="num1">Primer numero para operar.</param>
        /// <param name="num2">Segundo numero para operar.</param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operación.</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;
            char operadorRecibido = Convert.ToChar(operador);//Casteo a char, el operador recibido como String.
            switch (ValidarOperador(operadorRecibido))//Valido que tipo de operador es, y se lo paso al switch.
            {
                case "+":
                    retorno = num1 + num2;
                    break;
                case "-":
                    retorno = num1 - num2;
                    break;
                case "*":
                    retorno = num1 * num2;
                    break;
                case "/":
                    retorno = num1 / num2;
                    break;
                default:
                    break;
            }
            return retorno;
        }


    }
}
