namespace Carpinteria_App.Presentacion
{
    partial class FrmConsultarPresupuesto
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
            this.DgvPresupuesto = new System.Windows.Forms.DataGridView();
            this.ColNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.GrpFiltros = new System.Windows.Forms.GroupBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.DtpHasta = new System.Windows.Forms.DateTimePicker();
            this.LblHasta = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.LblDesde = new System.Windows.Forms.Label();
            this.DtpDesde = new System.Windows.Forms.DateTimePicker();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPresupuesto)).BeginInit();
            this.GrpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPresupuesto
            // 
            this.DgvPresupuesto.AllowUserToAddRows = false;
            this.DgvPresupuesto.AllowUserToDeleteRows = false;
            this.DgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNro,
            this.ColFecha,
            this.ColCliente,
            this.ColTotal,
            this.ColAcciones});
            this.DgvPresupuesto.Location = new System.Drawing.Point(23, 133);
            this.DgvPresupuesto.Name = "DgvPresupuesto";
            this.DgvPresupuesto.ReadOnly = true;
            this.DgvPresupuesto.Size = new System.Drawing.Size(644, 177);
            this.DgvPresupuesto.TabIndex = 0;
            this.DgvPresupuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPresupuesto_CellContentClick);
            // 
            // ColNro
            // 
            this.ColNro.HeaderText = "Presupuesto";
            this.ColNro.Name = "ColNro";
            this.ColNro.ReadOnly = true;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.Width = 200;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            this.ColTotal.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            this.ColAcciones.Text = "Ver Detalle";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(550, 70);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(88, 43);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // GrpFiltros
            // 
            this.GrpFiltros.Controls.Add(this.LblCliente);
            this.GrpFiltros.Controls.Add(this.DtpHasta);
            this.GrpFiltros.Controls.Add(this.LblHasta);
            this.GrpFiltros.Controls.Add(this.TxtCliente);
            this.GrpFiltros.Controls.Add(this.LblDesde);
            this.GrpFiltros.Controls.Add(this.DtpDesde);
            this.GrpFiltros.Controls.Add(this.BtnConsultar);
            this.GrpFiltros.Location = new System.Drawing.Point(23, 12);
            this.GrpFiltros.Name = "GrpFiltros";
            this.GrpFiltros.Size = new System.Drawing.Size(644, 115);
            this.GrpFiltros.TabIndex = 2;
            this.GrpFiltros.TabStop = false;
            this.GrpFiltros.Text = "Filtros";
            this.GrpFiltros.Enter += new System.EventHandler(this.GrpFiltros_Enter);
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(32, 82);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 7;
            this.LblCliente.Text = "Cliente";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DtpHasta
            // 
            this.DtpHasta.Location = new System.Drawing.Point(369, 29);
            this.DtpHasta.Name = "DtpHasta";
            this.DtpHasta.Size = new System.Drawing.Size(200, 20);
            this.DtpHasta.TabIndex = 6;
            // 
            // LblHasta
            // 
            this.LblHasta.AutoSize = true;
            this.LblHasta.Location = new System.Drawing.Point(317, 34);
            this.LblHasta.Name = "LblHasta";
            this.LblHasta.Size = new System.Drawing.Size(35, 13);
            this.LblHasta.TabIndex = 5;
            this.LblHasta.Text = "Hasta";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(110, 82);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(286, 20);
            this.TxtCliente.TabIndex = 4;
            // 
            // LblDesde
            // 
            this.LblDesde.AutoSize = true;
            this.LblDesde.Location = new System.Drawing.Point(33, 35);
            this.LblDesde.Name = "LblDesde";
            this.LblDesde.Size = new System.Drawing.Size(38, 13);
            this.LblDesde.TabIndex = 3;
            this.LblDesde.Text = "Desde";
            // 
            // DtpDesde
            // 
            this.DtpDesde.Location = new System.Drawing.Point(97, 29);
            this.DtpDesde.Name = "DtpDesde";
            this.DtpDesde.Size = new System.Drawing.Size(200, 20);
            this.DtpDesde.TabIndex = 2;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(23, 332);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(88, 43);
            this.BtnEditar.TabIndex = 8;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(573, 332);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(88, 43);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(310, 332);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(88, 43);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 413);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.GrpFiltros);
            this.Controls.Add(this.DgvPresupuesto);
            this.Name = "FrmConsultarPresupuesto";
            this.Text = "FrmConsultarPresupuesto";
            this.Load += new System.EventHandler(this.FrmConsultarPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPresupuesto)).EndInit();
            this.GrpFiltros.ResumeLayout(false);
            this.GrpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPresupuesto;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.GroupBox GrpFiltros;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.DateTimePicker DtpHasta;
        private System.Windows.Forms.Label LblHasta;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label LblDesde;
        private System.Windows.Forms.DateTimePicker DtpDesde;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}