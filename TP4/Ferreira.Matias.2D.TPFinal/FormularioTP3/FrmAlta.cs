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
    public partial class FrmAlta : Form
    {
        int id;
        Producto producto;
        public FrmAlta()
        {
            InitializeComponent();
        }
        public FrmAlta(Producto producto) : this()
        {
            this.producto = producto;
            this.id = producto.IdProducto;
            btnGuardar.Text = "Modificar";
            PintarForm();
        }
        private void PintarForm()
        {
            txtNombre.Text = producto.Nombre;
            nupPrecio.Value = (decimal)producto.Precio;
            nupStock.Value = (decimal)producto.Stock;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    ValidarDatos(out string nombre, out float precio, out int stock);
                    producto.Nombre = nombre;
                    producto.Precio = precio;
                    producto.Stock = stock;
                    ProductoAccesoDatos.Modificar(producto);
                }
                else
                {
                    ValidarDatos(out string nombre, out float precio, out int stock);
                    ProductoAccesoDatos.Guardar(new Producto(0,nombre,precio,stock));
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                LogicaForms.MostrarExcepciones(ex);
            }
        }

        private void ValidarDatos(out string nombre, out float precio, out int stock)
        {
            if (txtNombre.Text == String.Empty)
            {
                throw new ParametrosVaciosException("Ingrese un nombre");
            }
            else
            {
                nombre = txtNombre.Text;
            }
            precio = Producto.ValidarPrecio(nupPrecio.Value.ToString());
            stock = Producto.ValidarStock(nupStock.Value.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
