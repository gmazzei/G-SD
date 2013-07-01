namespace FrbaBus.AbmMicros
{
    partial class FormAltaMicro
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
            this.lb_Nro = new System.Windows.Forms.Label();
            this.nud_Nro = new System.Windows.Forms.NumericUpDown();
            this.lb_Modelo = new System.Windows.Forms.Label();
            this.lb_Patente = new System.Windows.Forms.Label();
            this.lb_Marca = new System.Windows.Forms.Label();
            this.lb_TipoServicio = new System.Windows.Forms.Label();
            this.lb_CantidadButacas = new System.Windows.Forms.Label();
            this.lb_CantidadKg = new System.Windows.Forms.Label();
            this.tb_Modelo = new System.Windows.Forms.TextBox();
            this.tb_Patente = new System.Windows.Forms.TextBox();
            this.cb_TipoServicio = new System.Windows.Forms.ComboBox();
            this.nud_CantidadButacas = new System.Windows.Forms.NumericUpDown();
            this.nud_CantidadKg = new System.Windows.Forms.NumericUpDown();
            this.botonAgregarButaca = new System.Windows.Forms.Button();
            this.cb_TipoButaca = new System.Windows.Forms.ComboBox();
            this.nud_Piso = new System.Windows.Forms.NumericUpDown();
            this.lb_Piso = new System.Windows.Forms.Label();
            this.lb_TipoButaca = new System.Windows.Forms.Label();
            this.lb_Mensaje = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.errorProviderNro = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModelo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPatente = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTipoServicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFechaFueraServicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderButacas = new System.Windows.Forms.ErrorProvider(this.components);
            this.cb_Marca = new System.Windows.Forms.ComboBox();
            this.lb_MensajeCantidadButacas = new System.Windows.Forms.Label();
            this.lb_ButacasActuales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Nro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadButacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Piso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipoServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaFueraServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderButacas)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Nro
            // 
            this.lb_Nro.AutoSize = true;
            this.lb_Nro.Location = new System.Drawing.Point(12, 9);
            this.lb_Nro.Name = "lb_Nro";
            this.lb_Nro.Size = new System.Drawing.Size(27, 13);
            this.lb_Nro.TabIndex = 0;
            this.lb_Nro.Text = "Nro:";
            // 
            // nud_Nro
            // 
            this.nud_Nro.Location = new System.Drawing.Point(58, 7);
            this.nud_Nro.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_Nro.Name = "nud_Nro";
            this.nud_Nro.ReadOnly = true;
            this.nud_Nro.Size = new System.Drawing.Size(62, 20);
            this.nud_Nro.TabIndex = 1;
            this.nud_Nro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_Modelo
            // 
            this.lb_Modelo.AutoSize = true;
            this.lb_Modelo.Location = new System.Drawing.Point(12, 33);
            this.lb_Modelo.Name = "lb_Modelo";
            this.lb_Modelo.Size = new System.Drawing.Size(45, 13);
            this.lb_Modelo.TabIndex = 5;
            this.lb_Modelo.Text = "Modelo:";
            // 
            // lb_Patente
            // 
            this.lb_Patente.AutoSize = true;
            this.lb_Patente.Location = new System.Drawing.Point(12, 56);
            this.lb_Patente.Name = "lb_Patente";
            this.lb_Patente.Size = new System.Drawing.Size(47, 13);
            this.lb_Patente.TabIndex = 6;
            this.lb_Patente.Text = "Patente:";
            // 
            // lb_Marca
            // 
            this.lb_Marca.AutoSize = true;
            this.lb_Marca.Location = new System.Drawing.Point(12, 79);
            this.lb_Marca.Name = "lb_Marca";
            this.lb_Marca.Size = new System.Drawing.Size(40, 13);
            this.lb_Marca.TabIndex = 7;
            this.lb_Marca.Text = "Marca:";
            // 
            // lb_TipoServicio
            // 
            this.lb_TipoServicio.AutoSize = true;
            this.lb_TipoServicio.Location = new System.Drawing.Point(12, 103);
            this.lb_TipoServicio.Name = "lb_TipoServicio";
            this.lb_TipoServicio.Size = new System.Drawing.Size(87, 13);
            this.lb_TipoServicio.TabIndex = 8;
            this.lb_TipoServicio.Text = "Tipo de Servicio:";
            // 
            // lb_CantidadButacas
            // 
            this.lb_CantidadButacas.AutoSize = true;
            this.lb_CantidadButacas.Location = new System.Drawing.Point(12, 134);
            this.lb_CantidadButacas.Name = "lb_CantidadButacas";
            this.lb_CantidadButacas.Size = new System.Drawing.Size(108, 13);
            this.lb_CantidadButacas.TabIndex = 11;
            this.lb_CantidadButacas.Text = "Cantidad de butacas:";
            // 
            // lb_CantidadKg
            // 
            this.lb_CantidadKg.AutoSize = true;
            this.lb_CantidadKg.Location = new System.Drawing.Point(12, 160);
            this.lb_CantidadKg.Name = "lb_CantidadKg";
            this.lb_CantidadKg.Size = new System.Drawing.Size(138, 13);
            this.lb_CantidadKg.TabIndex = 12;
            this.lb_CantidadKg.Text = "Cantidad de Kg disponibles:";
            // 
            // tb_Modelo
            // 
            this.tb_Modelo.Location = new System.Drawing.Point(58, 30);
            this.tb_Modelo.Name = "tb_Modelo";
            this.tb_Modelo.Size = new System.Drawing.Size(100, 20);
            this.tb_Modelo.TabIndex = 13;
            // 
            // tb_Patente
            // 
            this.tb_Patente.Location = new System.Drawing.Point(58, 53);
            this.tb_Patente.Name = "tb_Patente";
            this.tb_Patente.Size = new System.Drawing.Size(100, 20);
            this.tb_Patente.TabIndex = 14;
            // 
            // cb_TipoServicio
            // 
            this.cb_TipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoServicio.FormattingEnabled = true;
            this.cb_TipoServicio.Location = new System.Drawing.Point(105, 100);
            this.cb_TipoServicio.Name = "cb_TipoServicio";
            this.cb_TipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoServicio.TabIndex = 16;
            // 
            // nud_CantidadButacas
            // 
            this.nud_CantidadButacas.Location = new System.Drawing.Point(126, 131);
            this.nud_CantidadButacas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_CantidadButacas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CantidadButacas.Name = "nud_CantidadButacas";
            this.nud_CantidadButacas.ReadOnly = true;
            this.nud_CantidadButacas.Size = new System.Drawing.Size(62, 20);
            this.nud_CantidadButacas.TabIndex = 19;
            this.nud_CantidadButacas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_CantidadKg
            // 
            this.nud_CantidadKg.Location = new System.Drawing.Point(156, 157);
            this.nud_CantidadKg.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_CantidadKg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CantidadKg.Name = "nud_CantidadKg";
            this.nud_CantidadKg.ReadOnly = true;
            this.nud_CantidadKg.Size = new System.Drawing.Size(62, 20);
            this.nud_CantidadKg.TabIndex = 20;
            this.nud_CantidadKg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // botonAgregarButaca
            // 
            this.botonAgregarButaca.Location = new System.Drawing.Point(15, 296);
            this.botonAgregarButaca.Name = "botonAgregarButaca";
            this.botonAgregarButaca.Size = new System.Drawing.Size(135, 23);
            this.botonAgregarButaca.TabIndex = 31;
            this.botonAgregarButaca.Text = "Agregar butaca";
            this.botonAgregarButaca.UseVisualStyleBackColor = true;
            this.botonAgregarButaca.Click += new System.EventHandler(this.botonAgregarButaca_Click);
            // 
            // cb_TipoButaca
            // 
            this.cb_TipoButaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoButaca.FormattingEnabled = true;
            this.cb_TipoButaca.Location = new System.Drawing.Point(48, 259);
            this.cb_TipoButaca.Name = "cb_TipoButaca";
            this.cb_TipoButaca.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoButaca.TabIndex = 32;
            // 
            // nud_Piso
            // 
            this.nud_Piso.Location = new System.Drawing.Point(48, 236);
            this.nud_Piso.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_Piso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Piso.Name = "nud_Piso";
            this.nud_Piso.ReadOnly = true;
            this.nud_Piso.Size = new System.Drawing.Size(62, 20);
            this.nud_Piso.TabIndex = 33;
            this.nud_Piso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_Piso
            // 
            this.lb_Piso.AutoSize = true;
            this.lb_Piso.Location = new System.Drawing.Point(12, 238);
            this.lb_Piso.Name = "lb_Piso";
            this.lb_Piso.Size = new System.Drawing.Size(30, 13);
            this.lb_Piso.TabIndex = 34;
            this.lb_Piso.Text = "Piso:";
            // 
            // lb_TipoButaca
            // 
            this.lb_TipoButaca.AutoSize = true;
            this.lb_TipoButaca.Location = new System.Drawing.Point(12, 262);
            this.lb_TipoButaca.Name = "lb_TipoButaca";
            this.lb_TipoButaca.Size = new System.Drawing.Size(31, 13);
            this.lb_TipoButaca.TabIndex = 35;
            this.lb_TipoButaca.Text = "Tipo:";
            // 
            // lb_Mensaje
            // 
            this.lb_Mensaje.AutoSize = true;
            this.lb_Mensaje.Location = new System.Drawing.Point(12, 208);
            this.lb_Mensaje.Name = "lb_Mensaje";
            this.lb_Mensaje.Size = new System.Drawing.Size(406, 13);
            this.lb_Mensaje.TabIndex = 36;
            this.lb_Mensaje.Text = "Ingrese los datos de las butacas y presione Agregar Butaca para incluirla en el m" +
                "icro.";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(15, 370);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(124, 23);
            this.botonLimpiar.TabIndex = 37;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(461, 341);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(124, 23);
            this.botonGuardar.TabIndex = 38;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(461, 370);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(124, 23);
            this.botonVolver.TabIndex = 39;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // errorProviderNro
            // 
            this.errorProviderNro.ContainerControl = this;
            // 
            // errorProviderModelo
            // 
            this.errorProviderModelo.ContainerControl = this;
            // 
            // errorProviderPatente
            // 
            this.errorProviderPatente.ContainerControl = this;
            // 
            // errorProviderMarca
            // 
            this.errorProviderMarca.ContainerControl = this;
            // 
            // errorProviderTipoServicio
            // 
            this.errorProviderTipoServicio.ContainerControl = this;
            // 
            // errorProviderFechaFueraServicio
            // 
            this.errorProviderFechaFueraServicio.ContainerControl = this;
            // 
            // errorProviderButacas
            // 
            this.errorProviderButacas.ContainerControl = this;
            // 
            // cb_Marca
            // 
            this.cb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Marca.FormattingEnabled = true;
            this.cb_Marca.Location = new System.Drawing.Point(58, 76);
            this.cb_Marca.Name = "cb_Marca";
            this.cb_Marca.Size = new System.Drawing.Size(121, 21);
            this.cb_Marca.TabIndex = 40;
            // 
            // lb_MensajeCantidadButacas
            // 
            this.lb_MensajeCantidadButacas.AutoSize = true;
            this.lb_MensajeCantidadButacas.Location = new System.Drawing.Point(12, 331);
            this.lb_MensajeCantidadButacas.Name = "lb_MensajeCantidadButacas";
            this.lb_MensajeCantidadButacas.Size = new System.Drawing.Size(102, 13);
            this.lb_MensajeCantidadButacas.TabIndex = 41;
            this.lb_MensajeCantidadButacas.Text = "Butacas agregadas:";
            // 
            // lb_ButacasActuales
            // 
            this.lb_ButacasActuales.AutoSize = true;
            this.lb_ButacasActuales.Location = new System.Drawing.Point(116, 331);
            this.lb_ButacasActuales.Name = "lb_ButacasActuales";
            this.lb_ButacasActuales.Size = new System.Drawing.Size(13, 13);
            this.lb_ButacasActuales.TabIndex = 42;
            this.lb_ButacasActuales.Text = "0";
            // 
            // FormAltaMicro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 405);
            this.Controls.Add(this.lb_ButacasActuales);
            this.Controls.Add(this.lb_MensajeCantidadButacas);
            this.Controls.Add(this.cb_Marca);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.lb_Mensaje);
            this.Controls.Add(this.lb_TipoButaca);
            this.Controls.Add(this.lb_Piso);
            this.Controls.Add(this.nud_Piso);
            this.Controls.Add(this.cb_TipoButaca);
            this.Controls.Add(this.botonAgregarButaca);
            this.Controls.Add(this.nud_CantidadKg);
            this.Controls.Add(this.nud_CantidadButacas);
            this.Controls.Add(this.cb_TipoServicio);
            this.Controls.Add(this.tb_Patente);
            this.Controls.Add(this.tb_Modelo);
            this.Controls.Add(this.lb_CantidadKg);
            this.Controls.Add(this.lb_CantidadButacas);
            this.Controls.Add(this.lb_TipoServicio);
            this.Controls.Add(this.lb_Marca);
            this.Controls.Add(this.lb_Patente);
            this.Controls.Add(this.lb_Modelo);
            this.Controls.Add(this.nud_Nro);
            this.Controls.Add(this.lb_Nro);
            this.Name = "FormAltaMicro";
            this.Text = "FRBA Bus - Alta de Micro";
            this.Load += new System.EventHandler(this.FormAltaMicro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Nro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadButacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Piso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipoServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaFueraServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderButacas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProviderNro;
        private System.Windows.Forms.ErrorProvider errorProviderModelo;
        private System.Windows.Forms.ErrorProvider errorProviderPatente;
        private System.Windows.Forms.ErrorProvider errorProviderMarca;
        private System.Windows.Forms.ErrorProvider errorProviderTipoServicio;
        private System.Windows.Forms.ErrorProvider errorProviderFechaFueraServicio;
        private System.Windows.Forms.ErrorProvider errorProviderButacas;
        protected System.Windows.Forms.Label lb_Modelo;
        protected System.Windows.Forms.Label lb_Patente;
        protected System.Windows.Forms.Label lb_Marca;
        protected System.Windows.Forms.Label lb_TipoServicio;
        protected System.Windows.Forms.Label lb_CantidadButacas;
        protected System.Windows.Forms.Label lb_CantidadKg;
        protected System.Windows.Forms.TextBox tb_Modelo;
        protected System.Windows.Forms.TextBox tb_Patente;
        protected System.Windows.Forms.ComboBox cb_TipoServicio;
        protected System.Windows.Forms.NumericUpDown nud_CantidadButacas;
        protected System.Windows.Forms.NumericUpDown nud_CantidadKg;
        protected System.Windows.Forms.Button botonAgregarButaca;
        protected System.Windows.Forms.ComboBox cb_TipoButaca;
        protected System.Windows.Forms.NumericUpDown nud_Piso;
        protected System.Windows.Forms.Label lb_Piso;
        protected System.Windows.Forms.Label lb_TipoButaca;
        protected System.Windows.Forms.Label lb_Mensaje;
        protected System.Windows.Forms.Button botonLimpiar;
        protected System.Windows.Forms.Button botonGuardar;
        protected System.Windows.Forms.Button botonVolver;
        protected System.Windows.Forms.ComboBox cb_Marca;
        protected System.Windows.Forms.Label lb_ButacasActuales;
        protected System.Windows.Forms.Label lb_MensajeCantidadButacas;
        protected System.Windows.Forms.Label lb_Nro;
        protected System.Windows.Forms.NumericUpDown nud_Nro;
    }
}