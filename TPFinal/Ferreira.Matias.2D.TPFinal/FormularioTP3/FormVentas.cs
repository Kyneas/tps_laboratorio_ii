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
            ListarVentas();
        }

        private void ListarVentas()
        {
            lvwListaVentas.Items.Clear();
            foreach (Venta item in Sistema.listaVentas)
            {
                LogicaForms.AgregarFilaAListView(lvwListaVentas, item.IdVenta.ToString(), item.FechaVenta.ToString("MM/dd/yyyy h:mm tt"), item.Saldo.ToString());
            }
        }

        private void lvwListaVentas_Click(object sender, EventArgs e)
        {
            if (lvwListaVentas.SelectedItems.Count > 0)
            {
                int idVenta = int.Parse(lvwListaVentas.SelectedItems[0].Text);
                MessageBox.Show(VentaPorId(idVenta).ToString());
            }

        }

        private Venta VentaPorId (int id)
        {
            foreach (Venta item in Sistema.listaVentas)
            {
                if (item.IdVenta == id)
                    return item;
            }
            return null;
        }

    }
}
