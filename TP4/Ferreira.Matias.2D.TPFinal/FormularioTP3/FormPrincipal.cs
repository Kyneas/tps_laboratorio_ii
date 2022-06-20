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
using System.Threading;

namespace FormularioTP4
{
    public partial class FormPrincipal : Form
    {

        public void MostrarQueHayMuchaPlataEnLaCaja()
        {
            MessageBox.Show("Hay mucho dinero en caja, haga un retiro por favor");
        }
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCargarVentana_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaForms.CerrarFormulariosDelPanel(pnlPrincipal);
                NuevaVenta menuVenta = new NuevaVenta();
                menuVenta.TopLevel = false;
                pnlPrincipal.Controls.Add(menuVenta);
                menuVenta.Show();
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
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
            try
            {
                LogicaForms.CerrarFormulariosDelPanel(pnlPrincipal);
                GestionInsumos menuInsumos = new GestionInsumos();
                menuInsumos.TopLevel = false;
                pnlPrincipal.Controls.Add(menuInsumos);
                menuInsumos.Show();
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void btbVentas_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaForms.CerrarFormulariosDelPanel(pnlPrincipal);
                FormVentas menuAdministrarVenta = new FormVentas();
                menuAdministrarVenta.TopLevel = false;
                pnlPrincipal.Controls.Add(menuAdministrarVenta);
                menuAdministrarVenta.Show();
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                ProbarConexionABaseDeDatos();
                Sistema.saldoAlcanzado += MostrarQueHayMuchaPlataEnLaCaja;
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
                this.btnInsumos.Enabled = false;
                this.btbVentas.Enabled = false;
                this.btnNuevaVentana.Enabled = false;
            }
        }
        private void ProbarConexionABaseDeDatos()
        {
            try
            {
                _ = ProductoAccesoDatos.Leer();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos. Verifique la conexion y vuelva a iniciar el programa", ex);
            }
        }
        
    }
}
