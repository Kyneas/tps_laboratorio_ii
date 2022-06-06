using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTP3
{
    public class Sistema
    {
        public static List<Producto> listaProductos;
        public static List<Venta> listaVentas;

        static Sistema()
        {

            listaProductos = new List<Producto>();
            listaVentas = new List<Venta>();
            CargaInicialProductos();
            CargaInicialVentas();
        }
        /// <summary>
        /// Lee los datos de productos de un archivo xml, de no exitir hardcodea los datos
        /// </summary>
        private static void CargaInicialProductos()
        {
            try
            {
                RecuperarProductos();
            }
            catch
            {
                CargarProductosHardcodeados();
            }
        }

        private static void CargaInicialVentas()
        {
            try
            {
                RecuperarVentas();
            }
            catch
            {

            }
        }

        private static void CargarProductosHardcodeados()
        {
            listaProductos.Add(new Producto("Alfajor", 60, 0));
            listaProductos.Add(new Producto("Cigarrillos", 100, 5));
            listaProductos.Add(new Producto("Lapicera", 40, 10));
            listaProductos.Add(new Producto("Chupetin", 10, 10));
        }

        private static void RecuperarProductos()
        {
            listaProductos = GestorSerializacion<List<Producto>>.Deserializar("listaProductos");
        }

        private static void GuardarProductos()
        {
            GestorSerializacion<List<Producto>>.Serializar("listaProductos", listaProductos);
        }

        private static void GuardarVentas()
        {
            GestorSerializacion<List<Venta>>.Serializar("listaVentas", listaVentas);
        }

        private static void RecuperarVentas()
        {
            listaVentas = GestorSerializacion<List<Venta>>.Deserializar("listaVentas");
        }
        /// <summary>
        /// Agrega el producto en el sistema y guarda los cambios
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        public static void AgregarNuevoProducto(string nombre, float precio, int stock)
        {
            listaProductos.Add(new Producto(nombre, precio, stock));
            GuardarProductos();
        }
        /// <summary>
        /// Elimina el producto del sistema y guarda los cambios
        /// </summary>
        /// <param name="producto"></param>
        public static void EliminarProducto(Producto producto)
        {
            listaProductos.Remove(producto);
            GuardarProductos();
        }

        public static List<Producto> ClonarLista(List<Producto> listaOrigen)
        {
            List<Producto> listaCopia = new List<Producto>();
            foreach (Producto item in listaOrigen)
            {
                listaCopia.Add(new Producto(item.IdProducto, item.Nombre, item.Precio, item.Stock));
            }
            return listaCopia;
        }
        /// <summary>
        /// Agrega ;a venta realizada a la lista del sistema y guarda los cambios
        /// </summary>
        /// <param name="venta"></param>
        public static void AgregarVenta(Venta venta)
        {
            listaVentas.Add(venta);
            GuardarVentas();
        }
    }
}
