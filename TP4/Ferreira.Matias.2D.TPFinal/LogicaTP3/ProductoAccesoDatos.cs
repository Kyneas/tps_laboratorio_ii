using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LogicaTP4
{
    public class ProductoAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static ProductoAccesoDatos()
        {
            connectionString = @"Data Source=.;Initial Catalog=DB_TP4;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static List<Producto> Leer()//(int id, string nombre, float precio, int stock, int cantidad)(dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["ID"])
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                connection.Open();

                command.CommandText = "SELECT * FROM PRODUCTOS";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        productos.Add(new Producto(Convert.ToInt32(dataReader["ID_PRODUCTO"]), dataReader["NOMBRE"].ToString(), Convert.ToInt32(dataReader["PRECIO"]),
                                                   Convert.ToInt32(dataReader["STOCK"]), Convert.ToInt32(dataReader["CANTIDAD"])));
                    }
                }

                return productos;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static Producto LeerPorId(int id)
        {
            Producto producto = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM PRODUCTOS WHERE ID_PRODUCTO =@ID";
                command.Parameters.AddWithValue("@ID", id);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        producto = new Producto(Convert.ToInt32(dataReader["ID_PRODUCTO"]), dataReader["NOMBRE"].ToString(), Convert.ToInt32(dataReader["PRECIO"]),
                                                Convert.ToInt32(dataReader["STOCK"]), Convert.ToInt32(dataReader["CANTIDAD"]));
                    }
                }

                return producto;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Guardar(Producto producto)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO PRODUCTOS (NOMBRE,PRECIO,CANTIDAD,STOCK) VALUES (@Nombre,@Precio,@Cantidad,@Stock)";
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@Stock", producto.Stock);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM PRODUCTOS WHERE ID_PRODUCTO = @ID";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Modificar(Producto producto)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE PRODUCTOS SET NOMBRE = @Nombre,PRECIO =@Precio, STOCK=@Stock WHERE ID_PRODUCTO = @ID";
                command.Parameters.AddWithValue("@ID", producto.IdProducto);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Stock", producto.Stock);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
