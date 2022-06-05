
namespace FormularioTP3
{
    partial class AdministrarInsumos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnCrearNuevoProducto = new System.Windows.Forms.Button();
            this.lvwListaProducto = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificarPrecio = new System.Windows.Forms.Button();
            this.btnAgregarStock = new System.Windows.Forms.Button();
            this.txtModificarPrecio = new System.Windows.Forms.TextBox();
            this.txtAgregarStock = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(544, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(544, 169);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(548, 271);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 15);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(669, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(669, 169);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(669, 268);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 23);
            this.txtStock.TabIndex = 5;
            // 
            // btnCrearNuevoProducto
            // 
            this.btnCrearNuevoProducto.Location = new System.Drawing.Point(605, 392);
            this.btnCrearNuevoProducto.Name = "btnCrearNuevoProducto";
            this.btnCrearNuevoProducto.Size = new System.Drawing.Size(127, 49);
            this.btnCrearNuevoProducto.TabIndex = 6;
            this.btnCrearNuevoProducto.Text = "Crear Nuevo Producto";
            this.btnCrearNuevoProducto.UseVisualStyleBackColor = true;
            this.btnCrearNuevoProducto.Click += new System.EventHandler(this.btnCrearNuevoProducto_Click);
            // 
            // lvwListaProducto
            // 
            this.lvwListaProducto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwListaProducto.FullRowSelect = true;
            this.lvwListaProducto.HideSelection = false;
            this.lvwListaProducto.Location = new System.Drawing.Point(67, 42);
            this.lvwListaProducto.Name = "lvwListaProducto";
            this.lvwListaProducto.Size = new System.Drawing.Size(353, 399);
            this.lvwListaProducto.TabIndex = 7;
            this.lvwListaProducto.UseCompatibleStateImageBehavior = false;
            this.lvwListaProducto.View = System.Windows.Forms.View.Details;
            this.lvwListaProducto.Click += new System.EventHandler(this.lvwListaProducto_Click);
            this.lvwListaProducto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvwListaProducto_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stock";
            this.columnHeader4.Width = 50;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(188, 557);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 49);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificarPrecio
            // 
            this.btnModificarPrecio.Location = new System.Drawing.Point(92, 447);
            this.btnModificarPrecio.Name = "btnModificarPrecio";
            this.btnModificarPrecio.Size = new System.Drawing.Size(114, 30);
            this.btnModificarPrecio.TabIndex = 9;
            this.btnModificarPrecio.Text = "Modificar Precio";
            this.btnModificarPrecio.UseVisualStyleBackColor = true;
            this.btnModificarPrecio.Click += new System.EventHandler(this.btnModificarPrecio_Click);
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.Location = new System.Drawing.Point(92, 506);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(114, 30);
            this.btnAgregarStock.TabIndex = 10;
            this.btnAgregarStock.Text = "Modificar Stock";
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            this.btnAgregarStock.Click += new System.EventHandler(this.btnAgregarStock_Click);
            // 
            // txtModificarPrecio
            // 
            this.txtModificarPrecio.Location = new System.Drawing.Point(280, 452);
            this.txtModificarPrecio.Name = "txtModificarPrecio";
            this.txtModificarPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtModificarPrecio.TabIndex = 11;
            // 
            // txtAgregarStock
            // 
            this.txtAgregarStock.Location = new System.Drawing.Point(280, 506);
            this.txtAgregarStock.Name = "txtAgregarStock";
            this.txtAgregarStock.Size = new System.Drawing.Size(100, 23);
            this.txtAgregarStock.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(795, 569);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 37);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AdministrarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 618);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtAgregarStock);
            this.Controls.Add(this.txtModificarPrecio);
            this.Controls.Add(this.btnAgregarStock);
            this.Controls.Add(this.btnModificarPrecio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lvwListaProducto);
            this.Controls.Add(this.btnCrearNuevoProducto);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarInsumos";
            this.Text = "AdministrarInsumos";
            this.Load += new System.EventHandler(this.AdministrarInsumos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnCrearNuevoProducto;
        private System.Windows.Forms.ListView lvwListaProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnModificarPrecio;
        private System.Windows.Forms.Button btnAgregarStock;
        private System.Windows.Forms.TextBox txtModificarPrecio;
        private System.Windows.Forms.TextBox txtAgregarStock;
        private System.Windows.Forms.Button btnCancelar;
    }
}