using System;
using System.Collections.Generic;

namespace LogicaTP4
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private float precio;
        private int cantidad;
        private int stock;

        public Producto()
        {

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

        /// <summary>
        /// Retorna la direccion de memoria de un producto segun un id en una lista
        /// </summary>
        /// <param name="id">Id a buscar</param>
        /// <param name="lista">Lista donde se hara la busqueda</param>
        /// <returns>El producto o null en caso de no existir</returns>
        public static Producto ProductoPorId(int id, List<Producto> lista)
        {
            foreach (Producto producto in lista)
            {
                if (producto.IdProducto == id)
                    return producto;
            }
            return null;
        }

        public static float ValidarPrecio(string value)
        {
            if (value == String.Empty)
            {
                throw new ParametrosVaciosException("Ingrese un precio");
            }
            if (!float.TryParse(value, out float precio) || precio >= 10000 || precio <= 0)
            {
                throw new DatoInvalidoException("Ingrese un precio valido");
            }
            return precio;
        }

        public static int ValidarStock(string value)
        {
            if (value == String.Empty)
            {
                throw new ParametrosVaciosException("Ingrese un stock");
            }
            if (!int.TryParse(value, out int stock) || stock >= 1000 || stock < 0)
            {
                throw new DatoInvalidoException("Ingrese un stock valido");
            }
            return stock;
        }
    }
}
