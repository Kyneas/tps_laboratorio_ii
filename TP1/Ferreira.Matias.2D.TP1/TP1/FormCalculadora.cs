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

namespace TP1
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = String.Empty;
            this.txtNumero2.Text = String.Empty;
            this.lblResultado.Text = String.Empty;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operando1 = txtNumero1.Text;
            string operando2 = txtNumero2.Text;
            string operador = cmbOperador.Text;
            string resultado;
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(operando1) ||
                string.IsNullOrEmpty(operando2))
            {
                MessageBox.Show("Debe ingresar los operandos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(operador))
            {
                MessageBox.Show("Debe ingresar un operador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                string oper1 = operando1.Replace('.',',');
                string oper2 = operando2.Replace('.',',');
                resultado = (Operar(oper1, oper2, operador)).ToString();
                this.lblResultado.Text = resultado;
                sb.Append($"{oper1} {operador} {oper2} = {resultado}");
                this.lstOperaciones.Items.Add(sb.ToString());
                btnConvertirABinario.Enabled = true;
                sb.Clear();
            }
        }

        private double Operar(string numero1, string numero2, string stOperador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char operador = char.Parse(stOperador);


             return Calculadora.Operar(operando1, operando2, operador);
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = String.Empty;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnConvertirABinario_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string resultado;
            string numero = this.lblResultado.Text;
            resultado = Operando.DecimalBinario(numero);
            this.lblResultado.Text = resultado;
            sb.Append($"Binario: {resultado}");
            this.lstOperaciones.Items.Add(sb.ToString());
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string resultado;
            string numero = this.lblResultado.Text;
            resultado = Operando.BinarioDecimal(numero);
            this.lblResultado.Text = resultado;
            sb.Append($"Decimal: {resultado}");
            this.lstOperaciones.Items.Add(sb.ToString());
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }
    }
}
