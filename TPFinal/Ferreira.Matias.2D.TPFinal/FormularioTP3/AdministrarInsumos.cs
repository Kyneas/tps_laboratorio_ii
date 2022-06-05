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
            ListarProductos();
            DesactivarBotonesYTextBoxDeParteEliminar();
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
            if (lvwListaProducto.SelectedItems.Count == 0)
            {
                DesactivarBotonesYTextBoxDeParteEliminar();
            }
        }

        private void lvwListaProducto_Click(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que quiere borrar el producto?", "Confirmacion", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                Sistema.listaProductos.Remove(productoSeleccionado);
                ListarProductos();
                DesactivarBotonesYTextBoxDeParteEliminar();
            }
        }

        private void btnModificarPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtModificarPrecio.Text == String.Empty)
                {
                    throw new ParametrosVaciosException("Ingrese un precio");
                }
                if (!float.TryParse(txtModificarPrecio.Text, out float precio) || precio >= 10000 || precio <= 0)
                {
                    throw new DatoInvalidoException("Ingrese un precio valido");
                }

                productoSeleccionado.Precio = precio;
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
                if (txtAgregarStock.Text == String.Empty)
                {
                    throw new ParametrosVaciosException("Ingrese un stock");
                }
                if (!int.TryParse(txtAgregarStock.Text, out int stock) || stock >= 1000 || stock < 0)
                {
                    throw new DatoInvalidoException("Ingrese un stock valido");
                }

                productoSeleccionado.Stock = stock;
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
                if (txtNombre.Text == String.Empty || txtPrecio.Text == String.Empty || txtStock.Text == String.Empty)
                {
                    throw new ParametrosVaciosException("Ningun campo puede estar vacio");
                }
                if (!int.TryParse(txtStock.Text, out int stock) || stock >= 1000 || stock < 0 ||
                    !float.TryParse(txtPrecio.Text, out float precio) || precio >= 10000 || precio <= 0)
                {
                    throw new DatoInvalidoException("Ingrese un valor valido");
                }
                Sistema.AgregarNuevoProducto(txtNombre.Text, precio, stock);
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
