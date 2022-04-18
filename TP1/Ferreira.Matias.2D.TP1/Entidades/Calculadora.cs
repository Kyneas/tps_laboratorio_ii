using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que el caracter ingresado sea valido
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>De ser valido retorna +, -, / o *. Caso contrario retornará +</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '-' ||
                operador == '/' ||
                operador == '*')
            {
                return operador;
            }
            return '+';
        }
        /// <summary>
        /// Realiza la operacion matematica
        /// </summary>
        /// <param name="num1">Primer Operando para realizar la operacion matematica</param>
        /// <param name="num2">Primer Operando para realizar la operacion matematica</param>
        /// <param name="operador">Operacion matematica a realizar</param>
        /// <returns>Retorna el resultado de la operacion, o 0 de no poder realizarse</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            switch (ValidarOperador(operador))
            {
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '/': return num1 / num2;
                case '*': return num1 * num2;
            }
            return 0;
        }
    }
}
