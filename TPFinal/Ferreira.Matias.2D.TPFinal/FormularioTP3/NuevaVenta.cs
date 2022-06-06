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
    public partial class NuevaVenta : Form
    {
        int idProducto;
        List<Producto> copiaListaProductosDeSistema;
        List<Producto> comidaPedida;

        public NuevaVenta()
        {
            InitializeComponent();
            comidaPedida = new List<Producto>();
            copiaListaProductosDeSistema = Sistema.ClonarLista(Sistema.listaProductos);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ListarProductosParaLaVenta()
        {
            lvwListaProductosParaVenta.Items.Clear();
            foreach (Producto producto in copiaListaProductosDeSistema)
            {
                LogicaForms.AgregarFilaAListView(lvwListaProductosParaVenta, producto.IdProducto.ToString(), producto.Nombre, producto.Precio.ToString(), producto.Stock.ToString());
            }
        }

        public void ListarProductosPedidos()
        {
            lvwListaProductosPedidos.Items.Clear();
            foreach (Producto producto in comidaPedida)
            {
                LogicaForms.AgregarFilaAListView(lvwListaProductosPedidos, producto.IdProducto.ToString(), producto.Nombre, producto.Cantidad.ToString());
            }
        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            try
            {
                ListarProductosParaLaVenta();
                lblSaldoTotal.Text = "Saldo: $0";
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwListaProductosParaVenta.SelectedItems.Count > 0)
                {
                    btnMenos.Enabled = true;
                    Producto productoSistema = Producto.ProductoPorId(idProducto, copiaListaProductosDeSistema);
                    Producto productoPedido = Producto.ProductoPorId(idProducto, comidaPedida);
                    AgregarOSumarProducto(productoSistema, productoPedido);
                    ListarProductosPedidos();
                    int itemSeleccionado = lvwListaProductosParaVenta.SelectedIndices[0];
                    ListarProductosParaLaVenta();
                    lvwListaProductosParaVenta.Items[itemSeleccionado].Selected = true;
                    lblSaldoTotal.Text = $"Saldo: ${CalcularSaldo()}";
                    btnConfirmarVenta.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void AgregarOSumarProducto(Producto productoSistema, Producto productoPedido)
        {
            if (productoPedido is not null)
                productoPedido.Cantidad++;

            else
                comidaPedida.Add(new Producto(productoSistema.IdProducto, productoSistema.Nombre, productoSistema.Precio, productoSistema.Stock, 1));
            productoSistema.Stock--;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwListaProductosParaVenta.SelectedItems.Count > 0)
                {
                    btnMas.Enabled = true;
                    Producto productoSistema = Producto.ProductoPorId(idProducto, copiaListaProductosDeSistema);
                    Producto productoPedido = Producto.ProductoPorId(idProducto, comidaPedida);
                    RestarOQuitarProductos(productoSistema, productoPedido);
                    ListarProductosPedidos();
                    int itemSeleccionado = lvwListaProductosParaVenta.SelectedIndices[0];
                    ListarProductosParaLaVenta();
                    lvwListaProductosParaVenta.Items[itemSeleccionado].Selected = true;
                    lblSaldoTotal.Text = $"Saldo: ${CalcularSaldo()}";
                }
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void RestarOQuitarProductos(Producto productoSistema, Producto productoPedido)
        {
            if (productoPedido.Cantidad == 1)
                comidaPedida.Remove(productoPedido);
            else if (productoPedido.Cantidad > 1)
                productoPedido.Cantidad--;
            productoSistema.Stock++;
        }

        private void lvwListaProductosParaVenta_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (lvwListaProductosParaVenta.SelectedItems.Count == 0)
                {
                    btnMas.Enabled = false;
                    btnMenos.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void lvwListaProductosParaVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwListaProductosParaVenta.SelectedItems.Count > 0)
                {
                    idProducto = int.Parse(lvwListaProductosParaVenta.SelectedItems[0].Text);
                    Producto producto = Producto.ProductoPorId(idProducto, copiaListaProductosDeSistema);
                    Producto productoPedido = Producto.ProductoPorId(idProducto, comidaPedida);

                    if (producto is not null && producto.Stock > 0)
                        btnMas.Enabled = true;
                    else
                        btnMas.Enabled = false;

                    if (productoPedido is not null)
                        btnMenos.Enabled = true;
                    else
                        btnMenos.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private float CalcularSaldo()
        {
            float saldoTotal = 0;
            foreach (Producto producto in comidaPedida)
            {
                saldoTotal += (producto.Precio * producto.Cantidad);
            }
            return saldoTotal;
        }

        private void btnMenos_MouseUp(object sender, MouseEventArgs e)
        {
            Producto productoPedido = Producto.ProductoPorId(idProducto, comidaPedida);
            if (productoPedido is null)
                btnMenos.Enabled = false;
            if (CalcularSaldo() <= 0)
                btnConfirmarVenta.Enabled = false;
        }

        private void btnMas_MouseUp(object sender, MouseEventArgs e)
        {
            Producto productoSistema = Producto.ProductoPorId(idProducto, copiaListaProductosDeSistema);
            if (productoSistema.Stock == 0)
                btnMas.Enabled = false;
        }

        private void ActulizarStockSistema()
        {
            foreach (Producto item in copiaListaProductosDeSistema)
            {
                int idABuscar = item.IdProducto;
                Producto productoSistema = Producto.ProductoPorId(idABuscar, Sistema.listaProductos);
                productoSistema.Stock = item.Stock;
            }
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                ActulizarStockSistema();
                Venta ventaEfectuada = new Venta(CalcularSaldo(), comidaPedida);
                Sistema.AgregarVenta(ventaEfectuada);
                MessageBox.Show(ventaEfectuada.ToString());
                this.Dispose();
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }
    }
}
