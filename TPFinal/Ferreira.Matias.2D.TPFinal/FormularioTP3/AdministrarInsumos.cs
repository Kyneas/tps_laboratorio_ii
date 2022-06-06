using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaTP3;

namespace FormularioTP3
{
    public partial class AdministrarInsumos : Form
    {
        Producto productoSeleccionado;
        public AdministrarInsumos()
        {
            InitializeComponent();
        }

        public void ListarProductos()
        {
            lvwListaProducto.Items.Clear();
            foreach (Producto producto in Sistema.listaProductos)
            {
                LogicaForms.AgregarFilaAListView(lvwListaProducto, producto.IdProducto.ToString(), producto.Nombre, producto.Precio.ToString(), producto.Stock.ToString());
            }
        }

        private void AdministrarInsumos_Load(object sender, EventArgs e)
        {
            try
            {
                ListarProductos();
                DesactivarBotonesYTextBoxDeParteEliminar();
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void DesactivarBotonesYTextBoxDeParteEliminar()
        {
            btnEliminar.Enabled = false;
            btnModificarPrecio.Enabled = false;
            btnAgregarStock.Enabled = false;
            txtAgregarStock.Text = String.Empty;
            txtModificarPrecio.Text = String.Empty;
            txtAgregarStock.ReadOnly = true;
            txtModificarPrecio.ReadOnly = true;
        }

        private void lvwListaProducto_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (lvwListaProducto.SelectedItems.Count == 0)
                {
                    DesactivarBotonesYTextBoxDeParteEliminar();
                }
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void lvwListaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwListaProducto.SelectedItems.Count > 0)
                {
                    btnEliminar.Enabled = true;
                    btnAgregarStock.Enabled = true;
                    btnModificarPrecio.Enabled = true;
                    txtAgregarStock.ReadOnly = false;
                    txtModificarPrecio.ReadOnly = false;
                    productoSeleccionado = Producto.ProductoPorId(int.Parse(lvwListaProducto.SelectedItems[0].Text), Sistema.listaProductos);
                }
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma que quiere borrar el producto?", "Confirmacion", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
                {
                    Sistema.EliminarProducto(productoSeleccionado);
                    ListarProductos();
                    DesactivarBotonesYTextBoxDeParteEliminar();
                }
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void btnModificarPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                productoSeleccionado.Precio = Producto.ValidarPrecio(txtModificarPrecio.Text);
                ListarProductos();
                MessageBox.Show("Precio modificado con exito");
                DesactivarBotonesYTextBoxDeParteEliminar();
            }
            catch(ParametrosVaciosException ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
            catch (DatoInvalidoException ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
            finally
            {
                txtModificarPrecio.Text = String.Empty;
            }
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            try
            {
                productoSeleccionado.Stock = Producto.ValidarStock(txtAgregarStock.Text);
                ListarProductos();
                MessageBox.Show("Stock modificado con exito");
                DesactivarBotonesYTextBoxDeParteEliminar();
            }
            catch (ParametrosVaciosException ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
            catch (DatoInvalidoException ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
            finally
            {
                txtAgregarStock.Text = String.Empty;
            }
        }

        private void btnCrearNuevoProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Sistema.AgregarNuevoProducto(txtNombre.Text, Producto.ValidarPrecio(txtPrecio.Text), Producto.ValidarStock(txtStock.Text));
                MessageBox.Show("Producto agregado con exito");
                ListarProductos();
            }
            catch (ParametrosVaciosException ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
            catch(DatoInvalidoException ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
            finally
            {
                txtNombre.Text = String.Empty;
                txtPrecio.Text = String.Empty;
                txtStock.Text = String.Empty;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
