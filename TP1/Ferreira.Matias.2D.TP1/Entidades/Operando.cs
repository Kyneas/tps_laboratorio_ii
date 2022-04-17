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

        private Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero) : this()
        {
            this.numero = numero;
        }

        public Operando(string strNumero) : this()
        {
            this.Numero = strNumero;
        }

        public double ValidarOperando(string strNumero)
        {
            double numero;
            if (double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            return 0;
        }

        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

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

        public static string DecimalBinario(double numero)
        {
            double numeroAOperar = Math.Abs(numero);
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

        public static string DecimalBinario(string numero)
        {
            double valor;
            if (double.TryParse(numero, out valor))
            {
                return DecimalBinario(valor);
            }
            return "Valor inválido";
        }
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

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

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
