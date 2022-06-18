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
        /// <summary>
        /// Constructor del formulario para inicializar los componentes
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Luego de presionar el boton btnLimpiar_Click, llama al metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Borra los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = String.Empty;
            this.txtNumero2.Text = String.Empty;
            this.lblResultado.Text = String.Empty;
            this.cmbOperador.SelectedIndex = 0;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = false;
        }
        /// <summary>
        /// Al presionar en el boton btnOperar_Click, llama al metodo Operar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            else if (!double.TryParse(operando1, out _) || !double.TryParse(operando2, out _))
            {
                MessageBox.Show("Ingrese un valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbOperador.Text == " ")
                {
                    cmbOperador.Text = "+";
                }
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
        /// <summary>
        /// Permite realizar la operacion matematica solicitada entre 2 numeros
        /// </summary>
        /// <param name="numero1">Primer operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="stOperador">Operacion matematica a realizar</param>
        /// <returns>Resultado de la operacion</returns>
        private double Operar(string numero1, string numero2, string stOperador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            char operador = char.Parse(stOperador);


             return Calculadora.Operar(operando1, operando2, operador);
        }
        /// <summary>
        /// Carga inicial de los componentes de la calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Confirma con el usuario la accion de cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Al presionar el boton btnCerrar_Click, intenta cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Al presionar en el boton brnConvertirABinario_Click, convierte el valor almacenado en lblResultado a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Al presionar en el boton btnConvertirADecimal_Click,convierte el valor almacenado en lblResultado a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
