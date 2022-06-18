using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogicaTP4
{
    public static class GestorDeArchivoTexto
    {
        static string rutaBase;
        static GestorDeArchivoTexto()
        {
            rutaBase = AppDomain.CurrentDomain.BaseDirectory;
        }
        public static bool Escribir(string ruta, string dato)
        {
            string rutaCompleta = rutaBase + ruta + ".txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    sw.WriteLine(dato);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al escrbir", ex);
            }
        }

        public static string Leer(string ruta)
        {
            string rutaCompleta = rutaBase + ruta + ".txt";
            try
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al leer", ex);
            }
        }
    }
}
