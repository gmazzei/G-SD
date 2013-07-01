namespace FrbaBus.Abm_Recorrido
{
    partial class FormBusquedaCiudades
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
            this.dataGridCiudades = new System.Windows.Forms.DataGridView();
            this.columnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCiudades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCiudades
            // 
            this.dataGridCiudades.AllowUserToAddRows = false;
            this.dataGridCiudades.AllowUserToDeleteRows = false;
            this.dataGridCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSeleccionar});
            this.dataGridCiudades.Location = new System.Drawing.Point(12, 108);
            this.dataGridCiudades.Name = "dataGridCiudades";
            this.dataGridCiudades.ReadOnly = true;
            this.dataGridCiudades.Size = new System.Drawing.Size(402, 161);
            this.dataGridCiudades.TabIndex = 0;
            this.dataGridCiudades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCiudades_CellContentClick);
            // 
            // columnSeleccionar
            // 
            this.columnSeleccionar.HeaderText = "Seleccionar";
            this.columnSeleccionar.Name = "columnSeleccionar";
            this.columnSeleccionar.ReadOnly = true;
            this.columnSeleccionar.Width = 70;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(65, 15);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(196, 20);
            this.tb_Nombre.TabIndex = 1;
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(12, 18);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(47, 13);
            this.lb_Nombre.TabIndex = 2;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(339, 12);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 3;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(339, 41);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 4;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(339, 70);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 5;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // FormBusquedaCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 281);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.lb_Nombre);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.dataGridCiudades);
            this.Name = "FormBusquedaCiudades";
            this.Text = "FormBusquedaCiudades";
            this.Load += new System.EventHandler(this.FormBusquedaCiudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCiudades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCiudades;
        private System.Windows.Forms.DataGridViewButtonColumn columnSeleccionar;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
    }
}