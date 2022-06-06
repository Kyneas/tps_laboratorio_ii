using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace LogicaTP3
{
    public static class GestorSerializacion<T>
    {
        private static string rutaBase;

        static GestorSerializacion()
        {
            rutaBase = AppDomain.CurrentDomain.BaseDirectory;
        }

        public static void Serializar(string nombreArchivo, T dato)
        {
            try
            {
                using (XmlTextWriter xmlTW = new XmlTextWriter($"{rutaBase}{nombreArchivo}.xml", Encoding.UTF8))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xmlTW.Formatting = Formatting.Indented;
                    xml.Serialize(xmlTW, dato);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al serializar", ex);
            }
        }
        public static T Deserializar(string nombreArchivo)
        {
            try
            {
                using (XmlTextReader sr = new XmlTextReader($"{rutaBase}{nombreArchivo}.xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    return (T)xml.Deserialize(sr);
                }
            }
            catch(Exception ex)
            {
                throw new ArchivoException("Error al deserializar",ex);
            }
        }
    }
}
