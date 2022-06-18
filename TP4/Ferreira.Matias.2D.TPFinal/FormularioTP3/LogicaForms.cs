using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioTP4
{
    public static class LogicaForms
    {
        /// <summary>
        /// Cierra todos los formularios contenidos dentro del panel
        /// </summary>
        /// <param name="panel"></param>
        public static void CerrarFormulariosDelPanel(Panel panel)
        {
            foreach (Form item in panel.Controls)
            {
                if (item is Form)
                    item.Dispose();
            }
        }

        public static void AgregarFilaAListView(ListView lista, string item1, string item2, string item3)
        {
            String[] fila = { item1, item2, item3 };
            ListViewItem item = new ListViewItem(fila);
            lista.Items.Add(item);
        }
        public static void AgregarFilaAListView(ListView lista, string item1, string item2, string item3, string item4)
        {
            String[] fila = { item1, item2, item3, item4 };
            ListViewItem item = new ListViewItem(fila);
            lista.Items.Add(item);
        }
        /// <summary>
        /// Muestro todas las excepciones y las inner dentro de un unico MessageBox
        /// </summary>
        /// <param name="ex"></param>
        public static void MostrarExcepciones(Exception ex)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(ex.Message);
            Exception inner = ex.InnerException;

            while(inner is not null)
            {
                sb.AppendLine(inner.Message);
                inner = inner.InnerException;
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
