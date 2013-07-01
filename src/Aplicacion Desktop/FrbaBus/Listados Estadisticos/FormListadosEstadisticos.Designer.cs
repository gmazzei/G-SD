namespace FrbaBus.Listados_Estadisticos
{
    partial class FormListadosEstadisticos
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
            this.botonDestinosConMasPasajesComprados = new System.Windows.Forms.Button();
            this.botonDestinosConMasMicrosVacios = new System.Windows.Forms.Button();
            this.botonClientesConMasPuntos = new System.Windows.Forms.Button();
            this.botonDestinosConMasPasajesCancelados = new System.Windows.Forms.Button();
            this.botonMicrosConMasDiasFueraDeServicio = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tb_Anio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Semestre = new System.Windows.Forms.Label();
            this.cb_Semestre = new System.Windows.Forms.ComboBox();
            this.errorProviderAnio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSemestre = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSemestre)).BeginInit();
            this.SuspendLayout();
            // 
            // botonDestinosConMasPasajesComprados
            // 
            this.botonDestinosConMasPasajesComprados.Location = new System.Drawing.Point(12, 12);
            this.botonDestinosConMasPasajesComprados.Name = "botonDestinosConMasPasajesComprados";
            this.botonDestinosConMasPasajesComprados.Size = new System.Drawing.Size(179, 34);
            this.botonDestinosConMasPasajesComprados.TabIndex = 0;
            this.botonDestinosConMasPasajesComprados.Text = "TOP 5 de los Destinos con más pasajes comprados";
            this.botonDestinosConMasPasajesComprados.UseVisualStyleBackColor = true;
            this.botonDestinosConMasPasajesComprados.Click += new System.EventHandler(this.botonDestinosConMasPasajesComprados_Click);
            // 
            // botonDestinosConMasMicrosVacios
            // 
            this.botonDestinosConMasMicrosVacios.Location = new System.Drawing.Point(197, 12);
            this.botonDestinosConMasMicrosVacios.Name = "botonDestinosConMasMicrosVacios";
            this.botonDestinosConMasMicrosVacios.Size = new System.Drawing.Size(179, 34);
            this.botonDestinosConMasMicrosVacios.TabIndex = 1;
            this.botonDestinosConMasMicrosVacios.Text = "TOP 5 de los Destinos con más micros vacíos";
            this.botonDestinosConMasMicrosVacios.UseVisualStyleBackColor = true;
            this.botonDestinosConMasMicrosVacios.Click += new System.EventHandler(this.botonDestinosConMasMicrosVacios_Click);
            // 
            // botonClientesConMasPuntos
            // 
            this.botonClientesConMasPuntos.Location = new System.Drawing.Point(382, 12);
            this.botonClientesConMasPuntos.Name = "botonClientesConMasPuntos";
            this.botonClientesConMasPuntos.Size = new System.Drawing.Size(179, 34);
            this.botonClientesConMasPuntos.TabIndex = 2;
            this.botonClientesConMasPuntos.Text = "TOP 5 de los Clientes con más puntos acumulados hasta la fecha";
            this.botonClientesConMasPuntos.UseVisualStyleBackColor = true;
            this.botonClientesConMasPuntos.Click += new System.EventHandler(this.botonClientesConMasPuntos_Click);
            // 
            // botonDestinosConMasPasajesCancelados
            // 
            this.botonDestinosConMasPasajesCancelados.Location = new System.Drawing.Point(12, 52);
            this.botonDestinosConMasPasajesCancelados.Name = "botonDestinosConMasPasajesCancelados";
            this.botonDestinosConMasPasajesCancelados.Size = new System.Drawing.Size(179, 34);
            this.botonDestinosConMasPasajesCancelados.TabIndex = 3;
            this.botonDestinosConMasPasajesCancelados.Text = "TOP 5 de los Destinos con más pasajes cancelados";
            this.botonDestinosConMasPasajesCancelados.UseVisualStyleBackColor = true;
            this.botonDestinosConMasPasajesCancelados.Click += new System.EventHandler(this.botonDestinosConMasPasajesCancelados_Click);
            // 
            // botonMicrosConMasDiasFueraDeServicio
            // 
            this.botonMicrosConMasDiasFueraDeServicio.Location = new System.Drawing.Point(197, 52);
            this.botonMicrosConMasDiasFueraDeServicio.Name = "botonMicrosConMasDiasFueraDeServicio";
            this.botonMicrosConMasDiasFueraDeServicio.Size = new System.Drawing.Size(179, 34);
            this.botonMicrosConMasDiasFueraDeServicio.TabIndex = 4;
            this.botonMicrosConMasDiasFueraDeServicio.Text = "TOP 5 de los Micros con mayor cantidad de días fuera de servicio";
            this.botonMicrosConMasDiasFueraDeServicio.UseVisualStyleBackColor = true;
            this.botonMicrosConMasDiasFueraDeServicio.Click += new System.EventHandler(this.botonMicrosConMasDiasFueraDeServicio_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(587, 239);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(101, 23);
            this.botonVolver.TabIndex = 5;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 102);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(676, 122);
            this.dataGrid.TabIndex = 6;
            // 
            // tb_Anio
            // 
            this.tb_Anio.Location = new System.Drawing.Point(47, 241);
            this.tb_Anio.Name = "tb_Anio";
            this.tb_Anio.Size = new System.Drawing.Size(62, 20);
            this.tb_Anio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Año:";
            // 
            // lb_Semestre
            // 
            this.lb_Semestre.AutoSize = true;
            this.lb_Semestre.Location = new System.Drawing.Point(135, 244);
            this.lb_Semestre.Name = "lb_Semestre";
            this.lb_Semestre.Size = new System.Drawing.Size(54, 13);
            this.lb_Semestre.TabIndex = 9;
            this.lb_Semestre.Text = "Semestre:";
            // 
            // cb_Semestre
            // 
            this.cb_Semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Semestre.FormattingEnabled = true;
            this.cb_Semestre.Location = new System.Drawing.Point(195, 241);
            this.cb_Semestre.Name = "cb_Semestre";
            this.cb_Semestre.Size = new System.Drawing.Size(38, 21);
            this.cb_Semestre.TabIndex = 10;
            // 
            // errorProviderAnio
            // 
            this.errorProviderAnio.ContainerControl = this;
            // 
            // errorProviderSemestre
            // 
            this.errorProviderSemestre.ContainerControl = this;
            // 
            // FormListadosEstadisticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 274);
            this.Controls.Add(this.cb_Semestre);
            this.Controls.Add(this.lb_Semestre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Anio);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonMicrosConMasDiasFueraDeServicio);
            this.Controls.Add(this.botonDestinosConMasPasajesCancelados);
            this.Controls.Add(this.botonClientesConMasPuntos);
            this.Controls.Add(this.botonDestinosConMasMicrosVacios);
            this.Controls.Add(this.botonDestinosConMasPasajesComprados);
            this.Name = "FormListadosEstadisticos";
            this.Text = "Listados Estadísticos";
            this.Load += new System.EventHandler(this.FormListadosEstadisticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSemestre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonDestinosConMasPasajesComprados;
        private System.Windows.Forms.Button botonDestinosConMasMicrosVacios;
        private System.Windows.Forms.Button botonClientesConMasPuntos;
        private System.Windows.Forms.Button botonDestinosConMasPasajesCancelados;
        private System.Windows.Forms.Button botonMicrosConMasDiasFueraDeServicio;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox tb_Anio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Semestre;
        private System.Windows.Forms.ComboBox cb_Semestre;
        private System.Windows.Forms.ErrorProvider errorProviderAnio;
        private System.Windows.Forms.ErrorProvider errorProviderSemestre;
    }
}