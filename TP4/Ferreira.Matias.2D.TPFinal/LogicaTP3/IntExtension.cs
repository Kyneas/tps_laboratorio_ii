using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTP4
{
    public static class IntExtension
    {
        /// <summary>
        /// Extiende la clase int, busca una venta con ese numero de id dentro de una lista de Ventas
        /// </summary>
        /// <param name="id">Id a buscar</param>
        /// <param name="lista">Lista donde se realizara la busqueda</param>
        /// <returns>Venta que conincida con ese id, null en caso de no encontrala</returns>
        public static Venta VentaPorId(this int id, List<Venta> lista)
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
