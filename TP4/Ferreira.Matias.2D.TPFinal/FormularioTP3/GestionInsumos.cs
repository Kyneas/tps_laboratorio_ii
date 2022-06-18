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
    public partial class GestionInsumos : Form
    {
        public GestionInsumos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GestionInsumos_Load(object sender, EventArgs e)
        {
            RefrescarLista();
            ModificarDiseñoDataGridView();
        }
        private void RefrescarLista()
        {
            this.dtgvProductos.DataSource = ProductoAccesoDatos.Leer();
            this.dtgvProductos.Update();
            this.dtgvProductos.Refresh();
        }

        private void ModificarDiseñoDataGridView()
        {
            foreach (DataGridViewColumn c in dtgvProductos.Columns)
            {
                c.Width = 170;
                c.DefaultCellStyle.Font = new Font("Arial", 20, GraphicsUnit.Pixel);
            }
            dtgvProductos.Columns[3].Width = 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgvProductos.SelectedRows.Count > 0)
            {
                Producto producto = (Producto)dtgvProductos.CurrentRow.DataBoundItem;
                FrmAlta alta = new FrmAlta(producto.IdProducto);
                alta.ShowDialog();
                RefrescarLista();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta alta = new FrmAlta();
            alta.ShowDialog();
            RefrescarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvProductos.SelectedRows.Count > 0)
            {
                RefrescarLista();
                if (MessageBox.Show("Confirma que quiere borrar el producto?", "Confirmacion", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
                {
                    Producto producto = (Producto)dtgvProductos.CurrentRow.DataBoundItem;
                    ProductoAccesoDatos.Eliminar(producto.IdProducto);
                    RefrescarLista();
                }
            }
        }
    }
}
