
namespace FormularioTP4
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevaVentana = new System.Windows.Forms.Button();
            this.btnInsumos = new System.Windows.Forms.Button();
            this.btbVentas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnNuevaVentana
            // 
            this.btnNuevaVentana.Location = new System.Drawing.Point(12, 80);
            this.btnNuevaVentana.Name = "btnNuevaVentana";
            this.btnNuevaVentana.Size = new System.Drawing.Size(242, 108);
            this.btnNuevaVentana.TabIndex = 0;
            this.btnNuevaVentana.Text = "Nueva Venta";
            this.btnNuevaVentana.UseVisualStyleBackColor = true;
            this.btnNuevaVentana.Click += new System.EventHandler(this.btnCargarVentana_Click);
            // 
            // btnInsumos
            // 
            this.btnInsumos.Location = new System.Drawing.Point(12, 306);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(242, 55);
            this.btnInsumos.TabIndex = 1;
            this.btnInsumos.Text = "Administrar Insumos";
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.Click += new System.EventHandler(this.btnInsumos_Click);
            // 
            // btbVentas
            // 
            this.btbVentas.Location = new System.Drawing.Point(12, 382);
            this.btbVentas.Name = "btbVentas";
            this.btbVentas.Size = new System.Drawing.Size(242, 55);
            this.btbVentas.TabIndex = 2;
            this.btbVentas.Text = "Ventas";
            this.btbVentas.UseVisualStyleBackColor = true;
            this.btbVentas.Click += new System.EventHandler(this.btbVentas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 589);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 41);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Location = new System.Drawing.Point(260, 12);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(896, 618);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 642);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btbVentas);
            this.Controls.Add(this.btnInsumos);
            this.Controls.Add(this.btnNuevaVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaVentana;
        private System.Windows.Forms.Button btnInsumos;
        private System.Windows.Forms.Button btbVentas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}

