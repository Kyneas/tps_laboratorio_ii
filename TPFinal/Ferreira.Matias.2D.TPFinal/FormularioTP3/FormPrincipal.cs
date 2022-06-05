using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioTP3
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCargarVentana_Click(object sender, EventArgs e)
        {
            LogicaForms.CerrarFormulariosDelPanel(pnlPrincipal);
            NuevaVenta menuVenta = new NuevaVenta();
            menuVenta.TopLevel = false;
            pnlPrincipal.Controls.Add(menuVenta);
            menuVenta.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma que desea salir?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            LogicaForms.CerrarFormulariosDelPanel(pnlPrincipal);
            AdministrarInsumos menuInsumos = new AdministrarInsumos();
            menuInsumos.TopLevel = false;
            pnlPrincipal.Controls.Add(menuInsumos);
            menuInsumos.Show();
        }

        private void btbVentas_Click(object sender, EventArgs e)
        {
            LogicaForms.CerrarFormulariosDelPanel(pnlPrincipal);
            FormVentas menuAdministrarVenta = new FormVentas();
            menuAdministrarVenta.TopLevel = false;
            pnlPrincipal.Controls.Add(menuAdministrarVenta);
            menuAdministrarVenta.Show();
        }
    }
}
