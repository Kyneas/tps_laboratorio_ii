using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaTP4;

namespace FormularioTP4
{
    public partial class FormHacerRetiro : Form
    {
        public FormHacerRetiro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.nudRetiro.Maximum = (decimal)Sistema.SaldoTotalEnCaja;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Sistema.SaldoTotalEnCaja = (float)nudRetiro.Value;
            this.DialogResult = DialogResult.Yes;
        }
    }
}
