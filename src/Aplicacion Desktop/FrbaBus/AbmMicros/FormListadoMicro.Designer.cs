namespace FrbaBus.AbmMicros
{
    partial class FormListadoMicro
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
            this.tb_Patente = new System.Windows.Forms.TextBox();
            this.lb_Patente = new System.Windows.Forms.Label();
            this.dataGridMicro = new System.Windows.Forms.DataGridView();
            this.lb_Nro = new System.Windows.Forms.Label();
            this.tb_Nro = new System.Windows.Forms.TextBox();
            this.cb_TipoServicio = new System.Windows.Forms.ComboBox();
            this.lb_TipoServicio = new System.Windows.Forms.Label();
            this.cb_BajaFueraServicio = new System.Windows.Forms.ComboBox();
            this.lb_BajaFueraServicio = new System.Windows.Forms.Label();
            this.cb_BajaVidaUtil = new System.Windows.Forms.ComboBox();
            this.lb_BajaVidaUtil = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.columnModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnBaja = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMicro)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Patente
            // 
            this.tb_Patente.Location = new System.Drawing.Point(65, 16);
            this.tb_Patente.Name = "tb_Patente";
            this.tb_Patente.Size = new System.Drawing.Size(123, 20);
            this.tb_Patente.TabIndex = 12;
            // 
            // lb_Patente
            // 
            this.lb_Patente.AutoSize = true;
            this.lb_Patente.Location = new System.Drawing.Point(12, 19);
            this.lb_Patente.Name = "lb_Patente";
            this.lb_Patente.Size = new System.Drawing.Size(47, 13);
            this.lb_Patente.TabIndex = 11;
            this.lb_Patente.Text = "Patente:";
            // 
            // dataGridMicro
            // 
            this.dataGridMicro.AllowUserToAddRows = false;
            this.dataGridMicro.AllowUserToDeleteRows = false;
            this.dataGridMicro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMicro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnModificar,
            this.columnBaja});
            this.dataGridMicro.Location = new System.Drawing.Point(12, 92);
            this.dataGridMicro.Name = "dataGridMicro";
            this.dataGridMicro.ReadOnly = true;
            this.dataGridMicro.Size = new System.Drawing.Size(1180, 245);
            this.dataGridMicro.TabIndex = 13;
            this.dataGridMicro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMicro_CellContentClick);
            // 
            // lb_Nro
            // 
            this.lb_Nro.AutoSize = true;
            this.lb_Nro.Location = new System.Drawing.Point(12, 47);
            this.lb_Nro.Name = "lb_Nro";
            this.lb_Nro.Size = new System.Drawing.Size(27, 13);
            this.lb_Nro.TabIndex = 14;
            this.lb_Nro.Text = "Nro:";
            // 
            // tb_Nro
            // 
            this.tb_Nro.Location = new System.Drawing.Point(65, 45);
            this.tb_Nro.Name = "tb_Nro";
            this.tb_Nro.Size = new System.Drawing.Size(123, 20);
            this.tb_Nro.TabIndex = 15;
            // 
            // cb_TipoServicio
            // 
            this.cb_TipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoServicio.FormattingEnabled = true;
            this.cb_TipoServicio.Location = new System.Drawing.Point(323, 16);
            this.cb_TipoServicio.Name = "cb_TipoServicio";
            this.cb_TipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoServicio.TabIndex = 21;
            // 
            // lb_TipoServicio
            // 
            this.lb_TipoServicio.AutoSize = true;
            this.lb_TipoServicio.Location = new System.Drawing.Point(232, 19);
            this.lb_TipoServicio.Name = "lb_TipoServicio";
            this.lb_TipoServicio.Size = new System.Drawing.Size(85, 13);
            this.lb_TipoServicio.TabIndex = 20;
            this.lb_TipoServicio.Text = "Tipo de servicio:";
            // 
            // cb_BajaFueraServicio
            // 
            this.cb_BajaFueraServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BajaFueraServicio.FormattingEnabled = true;
            this.cb_BajaFueraServicio.Location = new System.Drawing.Point(642, 16);
            this.cb_BajaFueraServicio.Name = "cb_BajaFueraServicio";
            this.cb_BajaFueraServicio.Size = new System.Drawing.Size(50, 21);
            this.cb_BajaFueraServicio.TabIndex = 23;
            // 
            // lb_BajaFueraServicio
            // 
            this.lb_BajaFueraServicio.AutoSize = true;
            this.lb_BajaFueraServicio.Location = new System.Drawing.Point(503, 19);
            this.lb_BajaFueraServicio.Name = "lb_BajaFueraServicio";
            this.lb_BajaFueraServicio.Size = new System.Drawing.Size(133, 13);
            this.lb_BajaFueraServicio.TabIndex = 22;
            this.lb_BajaFueraServicio.Text = "Baja por Fuera de servicio:";
            // 
            // cb_BajaVidaUtil
            // 
            this.cb_BajaVidaUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BajaVidaUtil.FormattingEnabled = true;
            this.cb_BajaVidaUtil.Location = new System.Drawing.Point(642, 44);
            this.cb_BajaVidaUtil.Name = "cb_BajaVidaUtil";
            this.cb_BajaVidaUtil.Size = new System.Drawing.Size(50, 21);
            this.cb_BajaVidaUtil.TabIndex = 25;
            // 
            // lb_BajaVidaUtil
            // 
            this.lb_BajaVidaUtil.AutoSize = true;
            this.lb_BajaVidaUtil.Location = new System.Drawing.Point(503, 47);
            this.lb_BajaVidaUtil.Name = "lb_BajaVidaUtil";
            this.lb_BajaVidaUtil.Size = new System.Drawing.Size(88, 13);
            this.lb_BajaVidaUtil.TabIndex = 24;
            this.lb_BajaVidaUtil.Text = "Baja por vida útil:";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(931, 43);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 27;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(931, 14);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 26;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
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
            this.columnModificar.Width = 70;
            // 
            // columnBaja
            // 
            this.columnBaja.HeaderText = "Baja";
            this.columnBaja.Name = "columnBaja";
            this.columnBaja.ReadOnly = true;
            this.columnBaja.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnBaja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnBaja.Visible = false;
            this.columnBaja.Width = 70;
            // 
            // FormListadoMicro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 349);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.cb_BajaVidaUtil);
            this.Controls.Add(this.lb_BajaVidaUtil);
            this.Controls.Add(this.cb_BajaFueraServicio);
            this.Controls.Add(this.lb_BajaFueraServicio);
            this.Controls.Add(this.cb_TipoServicio);
            this.Controls.Add(this.lb_TipoServicio);
            this.Controls.Add(this.tb_Nro);
            this.Controls.Add(this.lb_Nro);
            this.Controls.Add(this.dataGridMicro);
            this.Controls.Add(this.tb_Patente);
            this.Controls.Add(this.lb_Patente);
            this.Name = "FormListadoMicro";
            this.Text = "FormListadoMicro";
            this.Load += new System.EventHandler(this.FormListadoMicro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMicro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button botonLimpiar;
        protected System.Windows.Forms.Button botonBuscar;
        protected System.Windows.Forms.DataGridViewButtonColumn columnModificar;
        protected System.Windows.Forms.DataGridViewButtonColumn columnBaja;
        protected System.Windows.Forms.DataGridView dataGridMicro;
        protected System.Windows.Forms.TextBox tb_Patente;
        protected System.Windows.Forms.Label lb_Patente;
        protected System.Windows.Forms.Label lb_Nro;
        protected System.Windows.Forms.TextBox tb_Nro;
        protected System.Windows.Forms.ComboBox cb_TipoServicio;
        protected System.Windows.Forms.Label lb_TipoServicio;
        protected System.Windows.Forms.ComboBox cb_BajaFueraServicio;
        protected System.Windows.Forms.Label lb_BajaFueraServicio;
        protected System.Windows.Forms.ComboBox cb_BajaVidaUtil;
        protected System.Windows.Forms.Label lb_BajaVidaUtil;
    }
}