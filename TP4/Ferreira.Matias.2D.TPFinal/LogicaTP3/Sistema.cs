using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTP4
{
    public class Sistema
    {
        public static List<Producto> listaProductos;
        public static List<Venta> listaVentas;

        static Sistema()
        {

            //listaProductos = new List<Producto>();
            //listaProductos = ProductoAccesoDatos.Leer();
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
                listaProductos = ProductoAccesoDatos.Leer();
            }
            catch(Exception)
            {
                throw;
            }
        }

        private static void CargaInicialVentas()
        {
            try
            {
                RecuperarVentas();
            }
            catch (Exception)
            {
                throw;
            }
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
        /// Elimina el producto del sistema y guarda los cambios
        /// </summary>
        /// <param name="producto"></param>

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
