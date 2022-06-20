
namespace FormularioTP4
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
            this.lblSaldoEnCaja = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
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
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(795, 569);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 37);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSaldoEnCaja
            // 
            this.lblSaldoEnCaja.AutoSize = true;
            this.lblSaldoEnCaja.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldoEnCaja.Location = new System.Drawing.Point(112, 540);
            this.lblSaldoEnCaja.Name = "lblSaldoEnCaja";
            this.lblSaldoEnCaja.Size = new System.Drawing.Size(128, 30);
            this.lblSaldoEnCaja.TabIndex = 2;
            this.lblSaldoEnCaja.Text = "$SaldoTotal";
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRetirar.Enabled = false;
            this.btnRetirar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRetirar.Location = new System.Drawing.Point(387, 535);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(120, 44);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.Text = "Hacer Retiro";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(896, 618);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.lblSaldoEnCaja);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lvwListaVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwListaVentas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSaldoEnCaja;
        private System.Windows.Forms.Button btnRetirar;
    }
}