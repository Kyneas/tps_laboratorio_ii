using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaTP4;

namespace FormularioTP4
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            try
            {
                ListarVentas();
                this.lblSaldoEnCaja.Text = $"Saldo Total: {Sistema.SaldoTotalEnCaja}";
                ValidarSiHayQuePermitirRetiro();
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }
        /// <summary>
        /// Muestro todas las ventas efectuadas
        /// </summary>
        private void ListarVentas()
        {
            lvwListaVentas.Items.Clear();
            foreach (Venta item in Sistema.listaVentas)
            {
                LogicaForms.AgregarFilaAListView(lvwListaVentas, item.IdVenta.ToString(), item.FechaVenta.ToString("MM/dd/yyyy h:mm tt"), item.Saldo.ToString());
            }
        }
        /// <summary>
        /// Muestro los detalles de la venta seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvwListaVentas_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwListaVentas.SelectedItems.Count > 0)
                {
                    int idVenta = int.Parse(lvwListaVentas.SelectedItems[0].Text);
                    MessageBox.Show(idVenta.VentaPorId(Sistema.listaVentas).ToString());
                }
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            FormHacerRetiro retiro = new FormHacerRetiro();
            if (retiro.ShowDialog() == DialogResult.Yes)
            {
                this.lblSaldoEnCaja.Text = $"Saldo Total: {Sistema.SaldoTotalEnCaja}";
                ValidarSiHayQuePermitirRetiro();
            }
        }

        public void ValidarSiHayQuePermitirRetiro()
        {
            if (Sistema.SaldoTotalEnCaja >= 1)
            {
                this.btnRetirar.Enabled = true;
            }
            else
            {
                this.btnRetirar.Enabled = false;
            }
        }
    }
}
