using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTP4
{
    public static class IntExtension
    {
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
