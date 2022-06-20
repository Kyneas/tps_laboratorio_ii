using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTP4
{
    public delegate void DelegadoVerificarSaldo();
    public class Sistema
    {
        public static event DelegadoVerificarSaldo saldoAlcanzado;
        public static List<Venta> listaVentas;
        private static float saldoTotalEnCaja;

        public static float SaldoTotalEnCaja { get => saldoTotalEnCaja; set => saldoTotalEnCaja = ValidarRetiro(value); }

        private static float ValidarRetiro(float value)
        {
            if (value <= saldoTotalEnCaja)
                return saldoTotalEnCaja -= value;
            return saldoTotalEnCaja;
        }

        static Sistema()
        {
            listaVentas = new List<Venta>();
            CargaInicialVentas();
            saldoTotalEnCaja = 0;
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
            saldoTotalEnCaja += venta.Saldo;
            if (saldoTotalEnCaja >= 1500)
            {
                if (saldoAlcanzado is not null)
                {
                    saldoAlcanzado.Invoke();
                }
            }
            GuardarVentas();
        }
    }
}
