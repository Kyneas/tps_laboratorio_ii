using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        /// <summary>
        /// Contruye el objeto inicializandolo en 0
        /// </summary>
        private Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Construye el objeto inicializando con el valor brindado
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero) : this(numero.ToString())
        {
            
        }
        /// <summary>
        /// Construye el objeto y define su atributo por medio de la propiedad
        /// </summary>
        /// <param name="strNumero">Valor string que se intentara definir al atributo de numero</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        /// <summary>
        /// Verifica que la cadena de texto brindada sea un numero valido
        /// </summary>
        /// <param name="strNumero">Cadena de texto a verificar</param>
        /// <returns>Retorna el valor numerico de la cadena de texto, 0 en caso de no poder validar</returns>
        public double ValidarOperando(string strNumero)
        {
            double numero;
            if (double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            return 0;
        }
        /// <summary>
        /// Define y valida el atributo numero
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        /// <summary>
        /// Verifica que la cadena de texto sea un numero binario
        /// </summary>
        /// <param name="binario">Cadena de texto a verificar</param>
        /// <returns>True de ser correcta, false caso contrario</returns>
        private static bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length - 1; i++)
            {
                if (binario[i] != '1' &&
                    binario[i] != '0')
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numero">Numero a convertir</param>
        /// <returns>Retorna el numero convertido de ser posible, caso contrario "Valor invalido"</returns>
        public static string DecimalBinario(double numero)
        {
            if (numero > int.MaxValue)
            {
                return "Valor invalido";
            }
            int numeroAOperar = (int)Math.Abs(numero);
            if (numeroAOperar == 0)
            {
                return "0";
            }

            if (numeroAOperar == 1)
            {
                return "1";
            }
            string binarioInvertido = String.Empty;
            double resultado = numeroAOperar;
            StringBuilder auxiliar = new StringBuilder();
            int resto;
            bool continuar = true;

            while (continuar)
            {
                resto = (int)resultado % 2;

                auxiliar.Append(resto.ToString());

                resultado = (resultado - resto) / 2;

                if (resultado == 1)
                {
                    auxiliar.Append(resultado.ToString());
                    continuar = false;
                }

                binarioInvertido = auxiliar.ToString();
            }
            auxiliar.Clear();
            for (int i = binarioInvertido.Length - 1; i >= 0; i--)
            {
                auxiliar.Append(binarioInvertido[i]);
            }
            return auxiliar.ToString();
        }
        /// <summary>
        /// Convierte una cadena de texto que contenga un numero decimal a binario
        /// </summary>
        /// <param name="numero">Numero a convertir</param>
        /// <returns>Retorna el numero convertido de ser posible, caso contrario "Valor invalido"</returns>
        public static string DecimalBinario(string numero)
        {
            double valor;
            if (double.TryParse(numero, out valor))
            {
                return DecimalBinario(valor);
            }
            return "Valor inválido";
        }
        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario">Numero a convertir</param>
        /// <returns>Retorna el numero convertido de ser posible, caso contrario "Valor invalido"</returns>
        public static string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                double acumulador = 0;
                int contador = 0;
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    if (binario[i] == '1')
                    {
                        acumulador += Math.Pow(2, contador);
                    }
                    contador++;
                }
                return acumulador.ToString();
            }
            return "Valor inválido";
        }
        /// <summary>
        /// Suma el valor del atributo numero de 2 operandos
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Resta el valor del atributo numero de 2 operandos
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Multiplica el valor del atributo numero de 2 operandos
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Divide el valor del atributo numero de 2 operandos
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>Retorna el resultado de la operacion, en caso del segundo operando ser 0 retorna double.MinValue</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }
    }
}
