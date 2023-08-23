namespace Carpinteria_App.Presentacion
{
    partial class FrmNuevoPresupuesto
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
            this.DgbDetalle = new System.Windows.Forms.DataGridView();
            this.CboProducto = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblDescuento = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblPresupuesto = new System.Windows.Forms.Label();
            this.Colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgbDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // DgbDetalle
            // 
            this.DgbDetalle.AllowUserToAddRows = false;
            this.DgbDetalle.AllowUserToDeleteRows = false;
            this.DgbDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colid,
            this.ColProducto,
            this.ColPrecio,
            this.ColCantidad,
            this.ColAcciones});
            this.DgbDetalle.Location = new System.Drawing.Point(32, 156);
            this.DgbDetalle.Name = "DgbDetalle";
            this.DgbDetalle.ReadOnly = true;
            this.DgbDetalle.Size = new System.Drawing.Size(554, 150);
            this.DgbDetalle.TabIndex = 0;
            this.DgbDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgbDetalle_CellContentClick);
            // 
            // CboProducto
            // 
            this.CboProducto.FormattingEnabled = true;
            this.CboProducto.Location = new System.Drawing.Point(32, 130);
            this.CboProducto.Name = "CboProducto";
            this.CboProducto.Size = new System.Drawing.Size(293, 21);
            this.CboProducto.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(511, 130);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Location = new System.Drawing.Point(434, 321);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.LblSubtotal.TabIndex = 3;
            this.LblSubtotal.Text = "Subtotal";
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Location = new System.Drawing.Point(486, 318);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.TxtSubtotal.TabIndex = 4;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(445, 351);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(31, 13);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(486, 348);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 6;
            // 
            // LblDescuento
            // 
            this.LblDescuento.AutoSize = true;
            this.LblDescuento.Location = new System.Drawing.Point(29, 103);
            this.LblDescuento.Name = "LblDescuento";
            this.LblDescuento.Size = new System.Drawing.Size(67, 13);
            this.LblDescuento.TabIndex = 8;
            this.LblDescuento.Text = "%Descuento";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(59, 55);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 9;
            this.LblFecha.Text = "Fecha";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(55, 78);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 10;
            this.LblCliente.Text = "Cliente";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(102, 52);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(174, 20);
            this.TxtFecha.TabIndex = 11;
            this.TxtFecha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(102, 75);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(380, 20);
            this.TxtCliente.TabIndex = 12;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Location = new System.Drawing.Point(102, 100);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(174, 20);
            this.TxtDescuento.TabIndex = 13;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(209, 381);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 14;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(331, 381);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(331, 130);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(174, 20);
            this.TxtCantidad.TabIndex = 16;
            this.TxtCantidad.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // LblPresupuesto
            // 
            this.LblPresupuesto.AutoSize = true;
            this.LblPresupuesto.Location = new System.Drawing.Point(29, 19);
            this.LblPresupuesto.Name = "LblPresupuesto";
            this.LblPresupuesto.Size = new System.Drawing.Size(81, 13);
            this.LblPresupuesto.TabIndex = 17;
            this.LblPresupuesto.Text = "Presupuesto N°";
            // 
            // Colid
            // 
            this.Colid.HeaderText = "Id";
            this.Colid.Name = "Colid";
            this.Colid.ReadOnly = true;
            this.Colid.Visible = false;
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.Width = 212;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Text = "Quitar";
            // 
            // FrmNuevoPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 413);
            this.Controls.Add(this.LblPresupuesto);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblDescuento);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.LblSubtotal);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CboProducto);
            this.Controls.Add(this.DgbDetalle);
            this.Name = "FrmNuevoPresupuesto";
            this.Text = "Nuevo Presupuesto";
            this.Load += new System.EventHandler(this.FrmNuevoPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgbDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgbDetalle;
        private System.Windows.Forms.ComboBox CboProducto;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblDescuento;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}