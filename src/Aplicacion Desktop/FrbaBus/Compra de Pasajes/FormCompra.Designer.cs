using System;
namespace FrbaBus.Compra_de_Pasajes
{
    partial class FormCompra
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
            this.lb_CiudadOrigen = new System.Windows.Forms.Label();
            this.lb_CiudadDestino = new System.Windows.Forms.Label();
            this.lb_FechaViaje = new System.Windows.Forms.Label();
            this.dataGridViajes = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.cb_CiudadOrigen = new System.Windows.Forms.ComboBox();
            this.cb_CiudadDestino = new System.Windows.Forms.ComboBox();
            this.dtp_FechaViaje = new System.Windows.Forms.DateTimePicker();
            this.lb_PasajesAComprar = new System.Windows.Forms.Label();
            this.lb_KgAEnviar = new System.Windows.Forms.Label();
            this.nud_Pasajes = new System.Windows.Forms.NumericUpDown();
            this.nud_Kg = new System.Windows.Forms.NumericUpDown();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.lb_Mensaje = new System.Windows.Forms.Label();
            this.errorProviderCiudadOrigen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCiudadDestino = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_ViajeSeleccionado = new System.Windows.Forms.Label();
            this.lb_IDViajeSeleccionado = new System.Windows.Forms.Label();
            this.errorProviderPasajes = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderViaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKg = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pasajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Kg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudadOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudadDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPasajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderViaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKg)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CiudadOrigen
            // 
            this.lb_CiudadOrigen.AutoSize = true;
            this.lb_CiudadOrigen.Location = new System.Drawing.Point(13, 13);
            this.lb_CiudadOrigen.Name = "lb_CiudadOrigen";
            this.lb_CiudadOrigen.Size = new System.Drawing.Size(90, 13);
            this.lb_CiudadOrigen.TabIndex = 0;
            this.lb_CiudadOrigen.Text = "Ciudad de origen:";
            // 
            // lb_CiudadDestino
            // 
            this.lb_CiudadDestino.AutoSize = true;
            this.lb_CiudadDestino.Location = new System.Drawing.Point(13, 40);
            this.lb_CiudadDestino.Name = "lb_CiudadDestino";
            this.lb_CiudadDestino.Size = new System.Drawing.Size(95, 13);
            this.lb_CiudadDestino.TabIndex = 1;
            this.lb_CiudadDestino.Text = "Ciudad de destino:";
            // 
            // lb_FechaViaje
            // 
            this.lb_FechaViaje.AutoSize = true;
            this.lb_FechaViaje.Location = new System.Drawing.Point(275, 11);
            this.lb_FechaViaje.Name = "lb_FechaViaje";
            this.lb_FechaViaje.Size = new System.Drawing.Size(40, 13);
            this.lb_FechaViaje.TabIndex = 2;
            this.lb_FechaViaje.Text = "Fecha:";
            // 
            // dataGridViajes
            // 
            this.dataGridViajes.AllowUserToAddRows = false;
            this.dataGridViajes.AllowUserToDeleteRows = false;
            this.dataGridViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridViajes.Location = new System.Drawing.Point(16, 98);
            this.dataGridViajes.Name = "dataGridViajes";
            this.dataGridViajes.ReadOnly = true;
            this.dataGridViajes.Size = new System.Drawing.Size(602, 150);
            this.dataGridViajes.TabIndex = 3;
            this.dataGridViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViajes_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(486, 8);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // cb_CiudadOrigen
            // 
            this.cb_CiudadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CiudadOrigen.FormattingEnabled = true;
            this.cb_CiudadOrigen.Location = new System.Drawing.Point(114, 8);
            this.cb_CiudadOrigen.Name = "cb_CiudadOrigen";
            this.cb_CiudadOrigen.Size = new System.Drawing.Size(121, 21);
            this.cb_CiudadOrigen.TabIndex = 5;
            // 
            // cb_CiudadDestino
            // 
            this.cb_CiudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CiudadDestino.FormattingEnabled = true;
            this.cb_CiudadDestino.Location = new System.Drawing.Point(114, 37);
            this.cb_CiudadDestino.Name = "cb_CiudadDestino";
            this.cb_CiudadDestino.Size = new System.Drawing.Size(121, 21);
            this.cb_CiudadDestino.TabIndex = 6;
            // 
            // dtp_FechaViaje
            // 
            this.dtp_FechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaViaje.Location = new System.Drawing.Point(321, 8);
            this.dtp_FechaViaje.Name = "dtp_FechaViaje";
            this.dtp_FechaViaje.Size = new System.Drawing.Size(135, 20);
            this.dtp_FechaViaje.TabIndex = 7;
            // 
            // lb_PasajesAComprar
            // 
            this.lb_PasajesAComprar.AutoSize = true;
            this.lb_PasajesAComprar.Location = new System.Drawing.Point(13, 267);
            this.lb_PasajesAComprar.Name = "lb_PasajesAComprar";
            this.lb_PasajesAComprar.Size = new System.Drawing.Size(97, 13);
            this.lb_PasajesAComprar.TabIndex = 8;
            this.lb_PasajesAComprar.Text = "Pasajes a comprar:";
            // 
            // lb_KgAEnviar
            // 
            this.lb_KgAEnviar.AutoSize = true;
            this.lb_KgAEnviar.Location = new System.Drawing.Point(13, 290);
            this.lb_KgAEnviar.Name = "lb_KgAEnviar";
            this.lb_KgAEnviar.Size = new System.Drawing.Size(64, 13);
            this.lb_KgAEnviar.TabIndex = 9;
            this.lb_KgAEnviar.Text = "Kg a enviar:";
            // 
            // nud_Pasajes
            // 
            this.nud_Pasajes.Location = new System.Drawing.Point(117, 264);
            this.nud_Pasajes.Name = "nud_Pasajes";
            this.nud_Pasajes.ReadOnly = true;
            this.nud_Pasajes.Size = new System.Drawing.Size(47, 20);
            this.nud_Pasajes.TabIndex = 10;
            // 
            // nud_Kg
            // 
            this.nud_Kg.Location = new System.Drawing.Point(117, 290);
            this.nud_Kg.Name = "nud_Kg";
            this.nud_Kg.ReadOnly = true;
            this.nud_Kg.Size = new System.Drawing.Size(47, 20);
            this.nud_Kg.TabIndex = 11;
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Location = new System.Drawing.Point(455, 343);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.botonSiguiente.TabIndex = 12;
            this.botonSiguiente.Text = "Siguiente";
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // lb_Mensaje
            // 
            this.lb_Mensaje.AutoSize = true;
            this.lb_Mensaje.Location = new System.Drawing.Point(15, 82);
            this.lb_Mensaje.Name = "lb_Mensaje";
            this.lb_Mensaje.Size = new System.Drawing.Size(300, 13);
            this.lb_Mensaje.TabIndex = 13;
            this.lb_Mensaje.Text = "Para seleccionar un viaje, marquelo haciendo clic sobre la fila.";
            // 
            // errorProviderCiudadOrigen
            // 
            this.errorProviderCiudadOrigen.ContainerControl = this;
            // 
            // errorProviderCiudadDestino
            // 
            this.errorProviderCiudadDestino.ContainerControl = this;
            // 
            // lb_ViajeSeleccionado
            // 
            this.lb_ViajeSeleccionado.AutoSize = true;
            this.lb_ViajeSeleccionado.Location = new System.Drawing.Point(433, 264);
            this.lb_ViajeSeleccionado.Name = "lb_ViajeSeleccionado";
            this.lb_ViajeSeleccionado.Size = new System.Drawing.Size(99, 13);
            this.lb_ViajeSeleccionado.TabIndex = 14;
            this.lb_ViajeSeleccionado.Text = "Viaje seleccionado:";
            // 
            // lb_IDViajeSeleccionado
            // 
            this.lb_IDViajeSeleccionado.AutoSize = true;
            this.lb_IDViajeSeleccionado.Location = new System.Drawing.Point(538, 264);
            this.lb_IDViajeSeleccionado.Name = "lb_IDViajeSeleccionado";
            this.lb_IDViajeSeleccionado.Size = new System.Drawing.Size(47, 13);
            this.lb_IDViajeSeleccionado.TabIndex = 15;
            this.lb_IDViajeSeleccionado.Text = "Ninguno";
            // 
            // errorProviderPasajes
            // 
            this.errorProviderPasajes.ContainerControl = this;
            // 
            // errorProviderViaje
            // 
            this.errorProviderViaje.ContainerControl = this;
            // 
            // errorProviderKg
            // 
            this.errorProviderKg.ContainerControl = this;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 378);
            this.Controls.Add(this.lb_IDViajeSeleccionado);
            this.Controls.Add(this.lb_ViajeSeleccionado);
            this.Controls.Add(this.lb_Mensaje);
            this.Controls.Add(this.botonSiguiente);
            this.Controls.Add(this.nud_Kg);
            this.Controls.Add(this.nud_Pasajes);
            this.Controls.Add(this.lb_KgAEnviar);
            this.Controls.Add(this.lb_PasajesAComprar);
            this.Controls.Add(this.dtp_FechaViaje);
            this.Controls.Add(this.cb_CiudadDestino);
            this.Controls.Add(this.cb_CiudadOrigen);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.dataGridViajes);
            this.Controls.Add(this.lb_FechaViaje);
            this.Controls.Add(this.lb_CiudadDestino);
            this.Controls.Add(this.lb_CiudadOrigen);
            this.Name = "FormCompra";
            this.Text = "FRBA Bus - Compra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pasajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Kg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudadOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudadDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPasajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderViaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CiudadOrigen;
        private System.Windows.Forms.Label lb_CiudadDestino;
        private System.Windows.Forms.Label lb_FechaViaje;
        private System.Windows.Forms.DataGridView dataGridViajes;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.ComboBox cb_CiudadOrigen;
        private System.Windows.Forms.ComboBox cb_CiudadDestino;
        private System.Windows.Forms.DateTimePicker dtp_FechaViaje;
        private System.Windows.Forms.Label lb_PasajesAComprar;
        private System.Windows.Forms.Label lb_KgAEnviar;
        private System.Windows.Forms.NumericUpDown nud_Pasajes;
        private System.Windows.Forms.NumericUpDown nud_Kg;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Label lb_Mensaje;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.ErrorProvider errorProviderCiudadOrigen;
        private System.Windows.Forms.ErrorProvider errorProviderCiudadDestino;
        private System.Windows.Forms.Label lb_IDViajeSeleccionado;
        private System.Windows.Forms.Label lb_ViajeSeleccionado;
        private System.Windows.Forms.ErrorProvider errorProviderPasajes;
        private System.Windows.Forms.ErrorProvider errorProviderViaje;
        private System.Windows.Forms.ErrorProvider errorProviderKg;
    }
}