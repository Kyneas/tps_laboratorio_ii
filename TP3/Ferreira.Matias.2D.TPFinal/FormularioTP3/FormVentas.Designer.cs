
namespace FormularioTP3
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwListaVentas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwListaVentas
            // 
            this.lvwListaVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwListaVentas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwListaVentas.FullRowSelect = true;
            this.lvwListaVentas.HideSelection = false;
            this.lvwListaVentas.Location = new System.Drawing.Point(112, 50);
            this.lvwListaVentas.Name = "lvwListaVentas";
            this.lvwListaVentas.Size = new System.Drawing.Size(680, 453);
            this.lvwListaVentas.TabIndex = 0;
            this.lvwListaVentas.UseCompatibleStateImageBehavior = false;
            this.lvwListaVentas.View = System.Windows.Forms.View.Details;
            this.lvwListaVentas.Click += new System.EventHandler(this.lvwListaVentas_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numero de Venta";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha y Hora";
            this.columnHeader2.Width = 320;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Saldo";
            this.columnHeader3.Width = 80;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(795, 569);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 37);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 618);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lvwListaVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwListaVentas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnCancelar;
    }
}