using System;
using System.Collections.Generic;

namespace LogicaTP3
{
    public class Producto:IId
    {
        private int idProducto;
        private string nombre;
        private float precio;
        private int cantidad;
        private int stock;

        public Producto()
        {

        }
        public Producto(string nombre, float precio, int stock)
        {
            this.idProducto = UltimoId();
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = 0;
            this.stock = stock;
            AumentarId();
        }
        public Producto(int id, string nombre, float precio, int stock)
        {
            this.idProducto = id;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = 0;
            this.stock = stock;
        }
        public Producto(int id, string nombre, float precio, int stock, int cantidad):this(id, nombre, precio, stock)
        {
            this.cantidad = cantidad;
        }


        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Stock { get => stock; set => stock = value; }

        public int UltimoId()
        {
            try
            {
                string id = GestorDeArchivoTexto.Leer("UltimoIDProducto");
                return int.Parse(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ultimo ID de productos", ex);
            }
        }

        public void AumentarId()
        {
            try
            {
                int id = this.idProducto;
                id += 1;
                GestorDeArchivoTexto.Escribir("UltimoIDProducto", id.ToString());
            }
            catch (ArchivoException ex)
            {
                throw new Exception("Error al escribir el archivo con el ultimo id de productos", ex);
            }
        }

        public static Producto ProductoPorId(int id, List<Producto> lista)
        {
            foreach (Producto producto in lista)
            {
                if (producto.IdProducto == id)
                    return producto;
            }
            return null;
        }
    }
}
