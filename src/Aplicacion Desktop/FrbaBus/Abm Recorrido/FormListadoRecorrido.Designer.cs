namespace FrbaBus.Abm_Recorrido
{
    partial class FormListadoRecorrido
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
            this.components = new System.ComponentModel.Container();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.cb_Habilitado = new System.Windows.Forms.ComboBox();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.lb_Habilitado = new System.Windows.Forms.Label();
            this.lb_Codigo = new System.Windows.Forms.Label();
            this.dataGridRecorrido = new System.Windows.Forms.DataGridView();
            this.columnModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnBaja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lb_CiudadDestino = new System.Windows.Forms.Label();
            this.lb_CiudadOrigen = new System.Windows.Forms.Label();
            this.cb_TipoServicio = new System.Windows.Forms.ComboBox();
            this.lb_TipoServicio = new System.Windows.Forms.Label();
            this.errorProviderCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.botonCiudadDestino = new System.Windows.Forms.Button();
            this.tb_CiudadDestino = new System.Windows.Forms.TextBox();
            this.botonCiudadOrigen = new System.Windows.Forms.Button();
            this.tb_CiudadOrigen = new System.Windows.Forms.TextBox();
            this.botonLimpiarCiudadOrigen = new System.Windows.Forms.Button();
            this.botonLimpiarCiudadDestino = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecorrido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(762, 49);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(144, 23);
            this.botonLimpiar.TabIndex = 13;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(762, 12);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(144, 23);
            this.botonBuscar.TabIndex = 12;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // cb_Habilitado
            // 
            this.cb_Habilitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Habilitado.FormattingEnabled = true;
            this.cb_Habilitado.Location = new System.Drawing.Point(306, 5);
            this.cb_Habilitado.Name = "cb_Habilitado";
            this.cb_Habilitado.Size = new System.Drawing.Size(45, 21);
            this.cb_Habilitado.TabIndex = 11;
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Location = new System.Drawing.Point(65, 6);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(125, 20);
            this.tb_Codigo.TabIndex = 10;
            // 
            // lb_Habilitado
            // 
            this.lb_Habilitado.AutoSize = true;
            this.lb_Habilitado.Location = new System.Drawing.Point(243, 9);
            this.lb_Habilitado.Name = "lb_Habilitado";
            this.lb_Habilitado.Size = new System.Drawing.Size(57, 13);
            this.lb_Habilitado.TabIndex = 9;
            this.lb_Habilitado.Text = "Habilitado:";
            // 
            // lb_Codigo
            // 
            this.lb_Codigo.AutoSize = true;
            this.lb_Codigo.Location = new System.Drawing.Point(12, 9);
            this.lb_Codigo.Name = "lb_Codigo";
            this.lb_Codigo.Size = new System.Drawing.Size(43, 13);
            this.lb_Codigo.TabIndex = 8;
            this.lb_Codigo.Text = "Codigo:";
            // 
            // dataGridRecorrido
            // 
            this.dataGridRecorrido.AllowUserToAddRows = false;
            this.dataGridRecorrido.AllowUserToDeleteRows = false;
            this.dataGridRecorrido.AllowUserToOrderColumns = true;
            this.dataGridRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecorrido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnModificar,
            this.columnBaja});
            this.dataGridRecorrido.Location = new System.Drawing.Point(15, 136);
            this.dataGridRecorrido.Name = "dataGridRecorrido";
            this.dataGridRecorrido.ReadOnly = true;
            this.dataGridRecorrido.Size = new System.Drawing.Size(891, 188);
            this.dataGridRecorrido.TabIndex = 7;
            this.dataGridRecorrido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRecorrido_CellContentClick);
            // 
            // columnModificar
            // 
            this.columnModificar.DataPropertyName = "Modificar";
            this.columnModificar.HeaderText = "Modificar";
            this.columnModificar.Name = "columnModificar";
            this.columnModificar.ReadOnly = true;
            this.columnModificar.Text = "Modificar";
            this.columnModificar.ToolTipText = "Modificar";
            this.columnModificar.Visible = false;
            // 
            // columnBaja
            // 
            this.columnBaja.HeaderText = "Baja";
            this.columnBaja.Name = "columnBaja";
            this.columnBaja.ReadOnly = true;
            this.columnBaja.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnBaja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnBaja.Visible = false;
            // 
            // lb_CiudadDestino
            // 
            this.lb_CiudadDestino.AutoSize = true;
            this.lb_CiudadDestino.Location = new System.Drawing.Point(12, 105);
            this.lb_CiudadDestino.Name = "lb_CiudadDestino";
            this.lb_CiudadDestino.Size = new System.Drawing.Size(80, 13);
            this.lb_CiudadDestino.TabIndex = 15;
            this.lb_CiudadDestino.Text = "Ciudad destino:";
            // 
            // lb_CiudadOrigen
            // 
            this.lb_CiudadOrigen.AutoSize = true;
            this.lb_CiudadOrigen.Location = new System.Drawing.Point(12, 74);
            this.lb_CiudadOrigen.Name = "lb_CiudadOrigen";
            this.lb_CiudadOrigen.Size = new System.Drawing.Size(75, 13);
            this.lb_CiudadOrigen.TabIndex = 14;
            this.lb_CiudadOrigen.Text = "Ciudad origen:";
            // 
            // cb_TipoServicio
            // 
            this.cb_TipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoServicio.FormattingEnabled = true;
            this.cb_TipoServicio.Location = new System.Drawing.Point(103, 38);
            this.cb_TipoServicio.Name = "cb_TipoServicio";
            this.cb_TipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoServicio.TabIndex = 19;
            // 
            // lb_TipoServicio
            // 
            this.lb_TipoServicio.AutoSize = true;
            this.lb_TipoServicio.Location = new System.Drawing.Point(12, 41);
            this.lb_TipoServicio.Name = "lb_TipoServicio";
            this.lb_TipoServicio.Size = new System.Drawing.Size(85, 13);
            this.lb_TipoServicio.TabIndex = 18;
            this.lb_TipoServicio.Text = "Tipo de servicio:";
            // 
            // errorProviderCodigo
            // 
            this.errorProviderCodigo.ContainerControl = this;
            // 
            // botonCiudadDestino
            // 
            this.botonCiudadDestino.Location = new System.Drawing.Point(246, 100);
            this.botonCiudadDestino.Name = "botonCiudadDestino";
            this.botonCiudadDestino.Size = new System.Drawing.Size(75, 23);
            this.botonCiudadDestino.TabIndex = 26;
            this.botonCiudadDestino.Text = "Seleccionar";
            this.botonCiudadDestino.UseVisualStyleBackColor = true;
            this.botonCiudadDestino.Click += new System.EventHandler(this.botonCiudadDestino_Click);
            // 
            // tb_CiudadDestino
            // 
            this.tb_CiudadDestino.Location = new System.Drawing.Point(98, 103);
            this.tb_CiudadDestino.Name = "tb_CiudadDestino";
            this.tb_CiudadDestino.ReadOnly = true;
            this.tb_CiudadDestino.Size = new System.Drawing.Size(131, 20);
            this.tb_CiudadDestino.TabIndex = 25;
            // 
            // botonCiudadOrigen
            // 
            this.botonCiudadOrigen.Location = new System.Drawing.Point(246, 69);
            this.botonCiudadOrigen.Name = "botonCiudadOrigen";
            this.botonCiudadOrigen.Size = new System.Drawing.Size(75, 23);
            this.botonCiudadOrigen.TabIndex = 24;
            this.botonCiudadOrigen.Text = "Seleccionar";
            this.botonCiudadOrigen.UseVisualStyleBackColor = true;
            this.botonCiudadOrigen.Click += new System.EventHandler(this.botonCiudadOrigen_Click);
            // 
            // tb_CiudadOrigen
            // 
            this.tb_CiudadOrigen.Location = new System.Drawing.Point(98, 71);
            this.tb_CiudadOrigen.Name = "tb_CiudadOrigen";
            this.tb_CiudadOrigen.ReadOnly = true;
            this.tb_CiudadOrigen.Size = new System.Drawing.Size(131, 20);
            this.tb_CiudadOrigen.TabIndex = 23;
            // 
            // botonLimpiarCiudadOrigen
            // 
            this.botonLimpiarCiudadOrigen.Location = new System.Drawing.Point(327, 69);
            this.botonLimpiarCiudadOrigen.Name = "botonLimpiarCiudadOrigen";
            this.botonLimpiarCiudadOrigen.Size = new System.Drawing.Size(92, 23);
            this.botonLimpiarCiudadOrigen.TabIndex = 27;
            this.botonLimpiarCiudadOrigen.Text = "Limpiar campo";
            this.botonLimpiarCiudadOrigen.UseVisualStyleBackColor = true;
            this.botonLimpiarCiudadOrigen.Click += new System.EventHandler(this.botonLimpiarCiudadOrigen_Click);
            // 
            // botonLimpiarCiudadDestino
            // 
            this.botonLimpiarCiudadDestino.Location = new System.Drawing.Point(327, 100);
            this.botonLimpiarCiudadDestino.Name = "botonLimpiarCiudadDestino";
            this.botonLimpiarCiudadDestino.Size = new System.Drawing.Size(92, 23);
            this.botonLimpiarCiudadDestino.TabIndex = 28;
            this.botonLimpiarCiudadDestino.Text = "Limpiar campo";
            this.botonLimpiarCiudadDestino.UseVisualStyleBackColor = true;
            this.botonLimpiarCiudadDestino.Click += new System.EventHandler(this.botonLimpiarCiudadDestino_Click);
            // 
            // FormListadoRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 336);
            this.Controls.Add(this.botonLimpiarCiudadDestino);
            this.Controls.Add(this.botonLimpiarCiudadOrigen);
            this.Controls.Add(this.botonCiudadDestino);
            this.Controls.Add(this.tb_CiudadDestino);
            this.Controls.Add(this.botonCiudadOrigen);
            this.Controls.Add(this.tb_CiudadOrigen);
            this.Controls.Add(this.cb_TipoServicio);
            this.Controls.Add(this.lb_TipoServicio);
            this.Controls.Add(this.lb_CiudadDestino);
            this.Controls.Add(this.lb_CiudadOrigen);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.cb_Habilitado);
            this.Controls.Add(this.tb_Codigo);
            this.Controls.Add(this.lb_Habilitado);
            this.Controls.Add(this.lb_Codigo);
            this.Controls.Add(this.dataGridRecorrido);
            this.Name = "FormListadoRecorrido";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.FormListadoRecorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecorrido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.ComboBox cb_Habilitado;
        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.Label lb_Habilitado;
        private System.Windows.Forms.Label lb_Codigo;
        private System.Windows.Forms.DataGridView dataGridRecorrido;
        private System.Windows.Forms.Label lb_CiudadDestino;
        private System.Windows.Forms.Label lb_CiudadOrigen;
        private System.Windows.Forms.ComboBox cb_TipoServicio;
        private System.Windows.Forms.Label lb_TipoServicio;
        protected System.Windows.Forms.DataGridViewButtonColumn columnModificar;
        protected System.Windows.Forms.DataGridViewButtonColumn columnBaja;
        private System.Windows.Forms.ErrorProvider errorProviderCodigo;
        protected System.Windows.Forms.Button botonCiudadDestino;
        protected System.Windows.Forms.TextBox tb_CiudadDestino;
        protected System.Windows.Forms.Button botonCiudadOrigen;
        protected System.Windows.Forms.TextBox tb_CiudadOrigen;
        private System.Windows.Forms.Button botonLimpiarCiudadDestino;
        private System.Windows.Forms.Button botonLimpiarCiudadOrigen;
    }
}