using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTP3
{
    public class Venta:IId
    {
        int idVenta;
        DateTime fechaVenta;
        private float saldo;
        List<Producto> listaProductos;
        private string pedido;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        public string Pedido { get => pedido; set => pedido = value; }

        public Venta()
        {

        }

        public Venta(float saldo, List<Producto> listaProductos)
        {
            this.idVenta = UltimoId();
            this.fechaVenta = DateTime.Now;
            this.saldo = saldo;
            this.listaProductos = listaProductos;
            this.pedido = ListarPedidos();
            AumentarId();
        }

        private string ListarPedidos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------");
            foreach (Producto item in listaProductos)
            {
                sb.AppendLine($"#{item.Cantidad,-5} {item.Nombre,-35} {item.Precio,-5} {(item.Cantidad * item.Precio),-5}");
            }
            sb.AppendLine("------------------------------");
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha: {this.fechaVenta}");
            sb.AppendLine($"{this.pedido}");
            sb.AppendLine($"Saldo total: {this.saldo}");
            return sb.ToString();
        }

        public int UltimoId()
        {
            try
            {
                string id = GestorDeArchivoTexto.Leer("UltimoIDVenta");
                return int.Parse(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ultimo ID de ventas", ex);
            }
        }

        public void AumentarId()
        {
            try
            {
                int id = this.idVenta;
                id += 1;
                GestorDeArchivoTexto.Escribir("UltimoIDVenta", id.ToString());
            }
            catch (ArchivoException ex)
            {
                throw new Exception("Error al escribir el archivo con el ultimo id", ex);
            }
        }
        /// <summary>
        /// Retorna la direccion de memoria de una venta segun un id en una lista
        /// </summary>
        /// <param name="id">Id a buscar</param>
        /// <param name="lista">Lista donde se hara la busqueda</param>
        /// <returns>La venta o null en caso de no existir</returns>
        public static Venta VentaPorId(int id, List<Venta> lista)
        {
            foreach (Venta item in lista)
            {
                if (item.IdVenta == id)
                    return item;
            }
            return null;
        }
    }
}