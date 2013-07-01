namespace FrbaBus.Abm_Rol
{
    partial class FormListadoRol
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
            this.dataGridRol = new System.Windows.Forms.DataGridView();
            this.columnModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnBaja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_Habilitado = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.cb_Habilitado = new System.Windows.Forms.ComboBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRol
            // 
            this.dataGridRol.AllowUserToAddRows = false;
            this.dataGridRol.AllowUserToDeleteRows = false;
            this.dataGridRol.AllowUserToOrderColumns = true;
            this.dataGridRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnModificar,
            this.columnBaja});
            this.dataGridRol.Location = new System.Drawing.Point(12, 104);
            this.dataGridRol.Name = "dataGridRol";
            this.dataGridRol.ReadOnly = true;
            this.dataGridRol.Size = new System.Drawing.Size(485, 172);
            this.dataGridRol.TabIndex = 0;
            this.dataGridRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRol_CellContentClick);
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
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(12, 17);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(47, 13);
            this.lb_Nombre.TabIndex = 1;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // lb_Habilitado
            // 
            this.lb_Habilitado.AutoSize = true;
            this.lb_Habilitado.Location = new System.Drawing.Point(12, 46);
            this.lb_Habilitado.Name = "lb_Habilitado";
            this.lb_Habilitado.Size = new System.Drawing.Size(57, 13);
            this.lb_Habilitado.TabIndex = 2;
            this.lb_Habilitado.Text = "Habilitado:";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(65, 14);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(123, 20);
            this.tb_Nombre.TabIndex = 3;
            // 
            // cb_Habilitado
            // 
            this.cb_Habilitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Habilitado.FormattingEnabled = true;
            this.cb_Habilitado.Location = new System.Drawing.Point(75, 43);
            this.cb_Habilitado.Name = "cb_Habilitado";
            this.cb_Habilitado.Size = new System.Drawing.Size(45, 21);
            this.cb_Habilitado.TabIndex = 4;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(431, 12);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 5;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(431, 46);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // FormListadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 288);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.cb_Habilitado);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.lb_Habilitado);
            this.Controls.Add(this.lb_Nombre);
            this.Controls.Add(this.dataGridRol);
            this.Name = "FormListadoRol";
            this.Text = "ListadoRol";
            this.Load += new System.EventHandler(this.ListadoRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Label lb_Habilitado;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.ComboBox cb_Habilitado;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.DataGridView dataGridRol;
        public System.Windows.Forms.DataGridViewButtonColumn columnModificar;
        public System.Windows.Forms.DataGridViewButtonColumn columnBaja;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
    }
}