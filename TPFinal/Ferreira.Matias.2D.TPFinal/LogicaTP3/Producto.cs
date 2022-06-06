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
        public Producto(string nombre, string precio, int stock)
        {
            this.idProducto = UltimoId();
            this.nombre = nombre;
            this.precio = ValidarPrecio(precio);
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
