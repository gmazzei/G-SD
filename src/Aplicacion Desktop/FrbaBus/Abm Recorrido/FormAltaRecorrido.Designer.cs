namespace FrbaBus.Abm_Recorrido
{
    partial class FormAltaRecorrido
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
            this.lb_Codigo = new System.Windows.Forms.Label();
            this.lb_CiudadOrigen = new System.Windows.Forms.Label();
            this.lb_CiudadDestino = new System.Windows.Forms.Label();
            this.lb_TipoServicio = new System.Windows.Forms.Label();
            this.lb_PrecioKg = new System.Windows.Forms.Label();
            this.lb_PrecioPasaje = new System.Windows.Forms.Label();
            this.cb_TipoServicio = new System.Windows.Forms.ComboBox();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.tb_PrecioPasaje = new System.Windows.Forms.TextBox();
            this.tb_PrecioKg = new System.Windows.Forms.TextBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.lb_Habilitado = new System.Windows.Forms.Label();
            this.cb_Habilitado = new System.Windows.Forms.ComboBox();
            this.errorProviderCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderServicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOrigen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDestino = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPasaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderHabilitado = new System.Windows.Forms.ErrorProvider(this.components);
            this.tb_CiudadOrigen = new System.Windows.Forms.TextBox();
            this.botonCiudadOrigen = new System.Windows.Forms.Button();
            this.botonCiudadDestino = new System.Windows.Forms.Button();
            this.tb_CiudadDestino = new System.Windows.Forms.TextBox();
            this.errorProviderCiudades = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPasaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHabilitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Codigo
            // 
            this.lb_Codigo.AutoSize = true;
            this.lb_Codigo.Location = new System.Drawing.Point(12, 19);
            this.lb_Codigo.Name = "lb_Codigo";
            this.lb_Codigo.Size = new System.Drawing.Size(43, 13);
            this.lb_Codigo.TabIndex = 0;
            this.lb_Codigo.Text = "Codigo:";
            // 
            // lb_CiudadOrigen
            // 
            this.lb_CiudadOrigen.AutoSize = true;
            this.lb_CiudadOrigen.Location = new System.Drawing.Point(12, 66);
            this.lb_CiudadOrigen.Name = "lb_CiudadOrigen";
            this.lb_CiudadOrigen.Size = new System.Drawing.Size(75, 13);
            this.lb_CiudadOrigen.TabIndex = 1;
            this.lb_CiudadOrigen.Text = "Ciudad origen:";
            // 
            // lb_CiudadDestino
            // 
            this.lb_CiudadDestino.AutoSize = true;
            this.lb_CiudadDestino.Location = new System.Drawing.Point(12, 96);
            this.lb_CiudadDestino.Name = "lb_CiudadDestino";
            this.lb_CiudadDestino.Size = new System.Drawing.Size(80, 13);
            this.lb_CiudadDestino.TabIndex = 2;
            this.lb_CiudadDestino.Text = "Ciudad destino:";
            // 
            // lb_TipoServicio
            // 
            this.lb_TipoServicio.AutoSize = true;
            this.lb_TipoServicio.Location = new System.Drawing.Point(232, 19);
            this.lb_TipoServicio.Name = "lb_TipoServicio";
            this.lb_TipoServicio.Size = new System.Drawing.Size(85, 13);
            this.lb_TipoServicio.TabIndex = 3;
            this.lb_TipoServicio.Text = "Tipo de servicio:";
            // 
            // lb_PrecioKg
            // 
            this.lb_PrecioKg.AutoSize = true;
            this.lb_PrecioKg.Location = new System.Drawing.Point(12, 166);
            this.lb_PrecioKg.Name = "lb_PrecioKg";
            this.lb_PrecioKg.Size = new System.Drawing.Size(102, 13);
            this.lb_PrecioKg.TabIndex = 4;
            this.lb_PrecioKg.Text = "Precio base por KG:";
            // 
            // lb_PrecioPasaje
            // 
            this.lb_PrecioPasaje.AutoSize = true;
            this.lb_PrecioPasaje.Location = new System.Drawing.Point(12, 143);
            this.lb_PrecioPasaje.Name = "lb_PrecioPasaje";
            this.lb_PrecioPasaje.Size = new System.Drawing.Size(118, 13);
            this.lb_PrecioPasaje.TabIndex = 5;
            this.lb_PrecioPasaje.Text = "Precio base por pasaje:";
            // 
            // cb_TipoServicio
            // 
            this.cb_TipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoServicio.FormattingEnabled = true;
            this.cb_TipoServicio.Location = new System.Drawing.Point(323, 16);
            this.cb_TipoServicio.Name = "cb_TipoServicio";
            this.cb_TipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoServicio.TabIndex = 6;
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Location = new System.Drawing.Point(61, 16);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(107, 20);
            this.tb_Codigo.TabIndex = 9;
            // 
            // tb_PrecioPasaje
            // 
            this.tb_PrecioPasaje.Location = new System.Drawing.Point(136, 140);
            this.tb_PrecioPasaje.Name = "tb_PrecioPasaje";
            this.tb_PrecioPasaje.Size = new System.Drawing.Size(107, 20);
            this.tb_PrecioPasaje.TabIndex = 10;
            // 
            // tb_PrecioKg
            // 
            this.tb_PrecioKg.Location = new System.Drawing.Point(136, 163);
            this.tb_PrecioKg.Name = "tb_PrecioKg";
            this.tb_PrecioKg.Size = new System.Drawing.Size(107, 20);
            this.tb_PrecioKg.TabIndex = 11;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(425, 201);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 12;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(344, 201);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 13;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(425, 172);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 14;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // lb_Habilitado
            // 
            this.lb_Habilitado.AutoSize = true;
            this.lb_Habilitado.Location = new System.Drawing.Point(12, 201);
            this.lb_Habilitado.Name = "lb_Habilitado";
            this.lb_Habilitado.Size = new System.Drawing.Size(57, 13);
            this.lb_Habilitado.TabIndex = 15;
            this.lb_Habilitado.Text = "Habilitado:";
            // 
            // cb_Habilitado
            // 
            this.cb_Habilitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Habilitado.FormattingEnabled = true;
            this.cb_Habilitado.Location = new System.Drawing.Point(76, 198);
            this.cb_Habilitado.Name = "cb_Habilitado";
            this.cb_Habilitado.Size = new System.Drawing.Size(55, 21);
            this.cb_Habilitado.TabIndex = 16;
            // 
            // errorProviderCodigo
            // 
            this.errorProviderCodigo.ContainerControl = this;
            // 
            // errorProviderServicio
            // 
            this.errorProviderServicio.ContainerControl = this;
            // 
            // errorProviderOrigen
            // 
            this.errorProviderOrigen.ContainerControl = this;
            // 
            // errorProviderDestino
            // 
            this.errorProviderDestino.ContainerControl = this;
            // 
            // errorProviderPasaje
            // 
            this.errorProviderPasaje.ContainerControl = this;
            // 
            // errorProviderKg
            // 
            this.errorProviderKg.ContainerControl = this;
            // 
            // errorProviderHabilitado
            // 
            this.errorProviderHabilitado.ContainerControl = this;
            // 
            // tb_CiudadOrigen
            // 
            this.tb_CiudadOrigen.Location = new System.Drawing.Point(98, 63);
            this.tb_CiudadOrigen.Name = "tb_CiudadOrigen";
            this.tb_CiudadOrigen.ReadOnly = true;
            this.tb_CiudadOrigen.Size = new System.Drawing.Size(131, 20);
            this.tb_CiudadOrigen.TabIndex = 17;
            // 
            // botonCiudadOrigen
            // 
            this.botonCiudadOrigen.Location = new System.Drawing.Point(252, 61);
            this.botonCiudadOrigen.Name = "botonCiudadOrigen";
            this.botonCiudadOrigen.Size = new System.Drawing.Size(75, 23);
            this.botonCiudadOrigen.TabIndex = 18;
            this.botonCiudadOrigen.Text = "Seleccionar";
            this.botonCiudadOrigen.UseVisualStyleBackColor = true;
            this.botonCiudadOrigen.Click += new System.EventHandler(this.botonCiudadOrigen_Click);
            // 
            // botonCiudadDestino
            // 
            this.botonCiudadDestino.Location = new System.Drawing.Point(252, 91);
            this.botonCiudadDestino.Name = "botonCiudadDestino";
            this.botonCiudadDestino.Size = new System.Drawing.Size(75, 23);
            this.botonCiudadDestino.TabIndex = 20;
            this.botonCiudadDestino.Text = "Seleccionar";
            this.botonCiudadDestino.UseVisualStyleBackColor = true;
            this.botonCiudadDestino.Click += new System.EventHandler(this.botonCiudadDestino_Click);
            // 
            // tb_CiudadDestino
            // 
            this.tb_CiudadDestino.Location = new System.Drawing.Point(98, 93);
            this.tb_CiudadDestino.Name = "tb_CiudadDestino";
            this.tb_CiudadDestino.ReadOnly = true;
            this.tb_CiudadDestino.Size = new System.Drawing.Size(131, 20);
            this.tb_CiudadDestino.TabIndex = 19;
            // 
            // errorProviderCiudades
            // 
            this.errorProviderCiudades.ContainerControl = this;
            // 
            // FormAltaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 237);
            this.Controls.Add(this.botonCiudadDestino);
            this.Controls.Add(this.tb_CiudadDestino);
            this.Controls.Add(this.botonCiudadOrigen);
            this.Controls.Add(this.tb_CiudadOrigen);
            this.Controls.Add(this.cb_Habilitado);
            this.Controls.Add(this.lb_Habilitado);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.tb_PrecioKg);
            this.Controls.Add(this.tb_PrecioPasaje);
            this.Controls.Add(this.tb_Codigo);
            this.Controls.Add(this.cb_TipoServicio);
            this.Controls.Add(this.lb_PrecioPasaje);
            this.Controls.Add(this.lb_PrecioKg);
            this.Controls.Add(this.lb_TipoServicio);
            this.Controls.Add(this.lb_CiudadDestino);
            this.Controls.Add(this.lb_CiudadOrigen);
            this.Controls.Add(this.lb_Codigo);
            this.Name = "FormAltaRecorrido";
            this.Text = "Alta de un Recorrido";
            this.Load += new System.EventHandler(this.FormAltaRecorrido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPasaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHabilitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lb_Codigo;
        protected System.Windows.Forms.Label lb_CiudadOrigen;
        protected System.Windows.Forms.Label lb_CiudadDestino;
        protected System.Windows.Forms.Label lb_TipoServicio;
        protected System.Windows.Forms.Label lb_PrecioKg;
        protected System.Windows.Forms.Label lb_PrecioPasaje;
        protected System.Windows.Forms.ComboBox cb_TipoServicio;
        protected System.Windows.Forms.TextBox tb_Codigo;
        protected System.Windows.Forms.TextBox tb_PrecioPasaje;
        protected System.Windows.Forms.TextBox tb_PrecioKg;
        protected System.Windows.Forms.Button botonCancelar;
        protected System.Windows.Forms.Button botonGuardar;
        protected System.Windows.Forms.Button botonLimpiar;
        protected System.Windows.Forms.Label lb_Habilitado;
        protected System.Windows.Forms.ComboBox cb_Habilitado;
        protected System.Windows.Forms.ErrorProvider errorProviderCodigo;
        protected System.Windows.Forms.ErrorProvider errorProviderServicio;
        protected System.Windows.Forms.ErrorProvider errorProviderOrigen;
        protected System.Windows.Forms.ErrorProvider errorProviderDestino;
        protected System.Windows.Forms.ErrorProvider errorProviderPasaje;
        protected System.Windows.Forms.ErrorProvider errorProviderKg;
        protected System.Windows.Forms.ErrorProvider errorProviderHabilitado;
        protected System.Windows.Forms.Button botonCiudadOrigen;
        protected System.Windows.Forms.TextBox tb_CiudadOrigen;
        protected System.Windows.Forms.Button botonCiudadDestino;
        protected System.Windows.Forms.TextBox tb_CiudadDestino;
        protected System.Windows.Forms.ErrorProvider errorProviderCiudades;
    }
}