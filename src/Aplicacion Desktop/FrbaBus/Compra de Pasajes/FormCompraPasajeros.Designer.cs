namespace FrbaBus.Compra_de_Pasajes
{
    partial class FormCompraPasajeros
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
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.lb_DNI = new System.Windows.Forms.Label();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_Apellido = new System.Windows.Forms.Label();
            this.lb_Direccion = new System.Windows.Forms.Label();
            this.lb_Telefono = new System.Windows.Forms.Label();
            this.lb_Mail = new System.Windows.Forms.Label();
            this.lb_FechaNacimiento = new System.Windows.Forms.Label();
            this.tb_DNI = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Apellido = new System.Windows.Forms.TextBox();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.tb_Telefono = new System.Windows.Forms.TextBox();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lb_Genero = new System.Windows.Forms.Label();
            this.cb_Genero = new System.Windows.Forms.ComboBox();
            this.lb_KgAEnviar = new System.Windows.Forms.Label();
            this.nud_Kg = new System.Windows.Forms.NumericUpDown();
            this.dataGridButacas = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cb_Discapacitado = new System.Windows.Forms.ComboBox();
            this.lb_Discapacitado = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.errorProviderDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGenero = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDiscapacitado = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderButaca = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_Inicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Kg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridButacas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDiscapacitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderButaca)).BeginInit();
            this.SuspendLayout();
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Location = new System.Drawing.Point(351, 263);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.botonSiguiente.TabIndex = 0;
            this.botonSiguiente.Text = "Siguiente";
            this.botonSiguiente.UseVisualStyleBackColor = true;
            this.botonSiguiente.Click += new System.EventHandler(this.botonSiguiente_Click);
            // 
            // lb_DNI
            // 
            this.lb_DNI.AutoSize = true;
            this.lb_DNI.Location = new System.Drawing.Point(12, 31);
            this.lb_DNI.Name = "lb_DNI";
            this.lb_DNI.Size = new System.Drawing.Size(29, 13);
            this.lb_DNI.TabIndex = 1;
            this.lb_DNI.Text = "DNI:";
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(12, 56);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(47, 13);
            this.lb_Nombre.TabIndex = 2;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // lb_Apellido
            // 
            this.lb_Apellido.AutoSize = true;
            this.lb_Apellido.Location = new System.Drawing.Point(12, 81);
            this.lb_Apellido.Name = "lb_Apellido";
            this.lb_Apellido.Size = new System.Drawing.Size(47, 13);
            this.lb_Apellido.TabIndex = 3;
            this.lb_Apellido.Text = "Apellido:";
            // 
            // lb_Direccion
            // 
            this.lb_Direccion.AutoSize = true;
            this.lb_Direccion.Location = new System.Drawing.Point(222, 27);
            this.lb_Direccion.Name = "lb_Direccion";
            this.lb_Direccion.Size = new System.Drawing.Size(55, 13);
            this.lb_Direccion.TabIndex = 4;
            this.lb_Direccion.Text = "Dirección:";
            // 
            // lb_Telefono
            // 
            this.lb_Telefono.AutoSize = true;
            this.lb_Telefono.Location = new System.Drawing.Point(222, 55);
            this.lb_Telefono.Name = "lb_Telefono";
            this.lb_Telefono.Size = new System.Drawing.Size(52, 13);
            this.lb_Telefono.TabIndex = 5;
            this.lb_Telefono.Text = "Teléfono:";
            // 
            // lb_Mail
            // 
            this.lb_Mail.AutoSize = true;
            this.lb_Mail.Location = new System.Drawing.Point(222, 82);
            this.lb_Mail.Name = "lb_Mail";
            this.lb_Mail.Size = new System.Drawing.Size(29, 13);
            this.lb_Mail.TabIndex = 6;
            this.lb_Mail.Text = "Mail:";
            // 
            // lb_FechaNacimiento
            // 
            this.lb_FechaNacimiento.AutoSize = true;
            this.lb_FechaNacimiento.Location = new System.Drawing.Point(12, 124);
            this.lb_FechaNacimiento.Name = "lb_FechaNacimiento";
            this.lb_FechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lb_FechaNacimiento.TabIndex = 7;
            this.lb_FechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // tb_DNI
            // 
            this.tb_DNI.Location = new System.Drawing.Point(80, 28);
            this.tb_DNI.Name = "tb_DNI";
            this.tb_DNI.Size = new System.Drawing.Size(100, 20);
            this.tb_DNI.TabIndex = 8;
            this.tb_DNI.TextChanged += new System.EventHandler(this.tb_DNI_TextChanged);
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(80, 52);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_Nombre.TabIndex = 9;
            // 
            // tb_Apellido
            // 
            this.tb_Apellido.Location = new System.Drawing.Point(80, 78);
            this.tb_Apellido.Name = "tb_Apellido";
            this.tb_Apellido.Size = new System.Drawing.Size(100, 20);
            this.tb_Apellido.TabIndex = 10;
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.Location = new System.Drawing.Point(290, 24);
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(100, 20);
            this.tb_Direccion.TabIndex = 11;
            // 
            // tb_Telefono
            // 
            this.tb_Telefono.Location = new System.Drawing.Point(290, 52);
            this.tb_Telefono.Name = "tb_Telefono";
            this.tb_Telefono.Size = new System.Drawing.Size(100, 20);
            this.tb_Telefono.TabIndex = 12;
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(290, 78);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(100, 20);
            this.tb_Mail.TabIndex = 13;
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(129, 120);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(110, 20);
            this.dtp_FechaNacimiento.TabIndex = 14;
            // 
            // lb_Genero
            // 
            this.lb_Genero.AutoSize = true;
            this.lb_Genero.Location = new System.Drawing.Point(12, 153);
            this.lb_Genero.Name = "lb_Genero";
            this.lb_Genero.Size = new System.Drawing.Size(45, 13);
            this.lb_Genero.TabIndex = 15;
            this.lb_Genero.Text = "Género:";
            // 
            // cb_Genero
            // 
            this.cb_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Genero.FormattingEnabled = true;
            this.cb_Genero.Location = new System.Drawing.Point(63, 150);
            this.cb_Genero.Name = "cb_Genero";
            this.cb_Genero.Size = new System.Drawing.Size(32, 21);
            this.cb_Genero.TabIndex = 16;
            this.cb_Genero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb_KgAEnviar
            // 
            this.lb_KgAEnviar.AutoSize = true;
            this.lb_KgAEnviar.Location = new System.Drawing.Point(11, 184);
            this.lb_KgAEnviar.Name = "lb_KgAEnviar";
            this.lb_KgAEnviar.Size = new System.Drawing.Size(64, 13);
            this.lb_KgAEnviar.TabIndex = 17;
            this.lb_KgAEnviar.Text = "Kg a enviar:";
            // 
            // nud_Kg
            // 
            this.nud_Kg.Location = new System.Drawing.Point(81, 182);
            this.nud_Kg.Name = "nud_Kg";
            this.nud_Kg.Size = new System.Drawing.Size(47, 20);
            this.nud_Kg.TabIndex = 18;
            // 
            // dataGridButacas
            // 
            this.dataGridButacas.AllowUserToAddRows = false;
            this.dataGridButacas.AllowUserToDeleteRows = false;
            this.dataGridButacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridButacas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridButacas.Location = new System.Drawing.Point(11, 220);
            this.dataGridButacas.Name = "dataGridButacas";
            this.dataGridButacas.ReadOnly = true;
            this.dataGridButacas.Size = new System.Drawing.Size(318, 99);
            this.dataGridButacas.TabIndex = 19;
            this.dataGridButacas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridButacas_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // cb_Discapacitado
            // 
            this.cb_Discapacitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Discapacitado.FormattingEnabled = true;
            this.cb_Discapacitado.Location = new System.Drawing.Point(210, 150);
            this.cb_Discapacitado.Name = "cb_Discapacitado";
            this.cb_Discapacitado.Size = new System.Drawing.Size(32, 21);
            this.cb_Discapacitado.TabIndex = 21;
            // 
            // lb_Discapacitado
            // 
            this.lb_Discapacitado.AutoSize = true;
            this.lb_Discapacitado.Location = new System.Drawing.Point(126, 153);
            this.lb_Discapacitado.Name = "lb_Discapacitado";
            this.lb_Discapacitado.Size = new System.Drawing.Size(78, 13);
            this.lb_Discapacitado.TabIndex = 20;
            this.lb_Discapacitado.Text = "Discapacitado:";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(351, 296);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 22;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // errorProviderDNI
            // 
            this.errorProviderDNI.ContainerControl = this;
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderApellido
            // 
            this.errorProviderApellido.ContainerControl = this;
            // 
            // errorProviderDireccion
            // 
            this.errorProviderDireccion.ContainerControl = this;
            // 
            // errorProviderTelefono
            // 
            this.errorProviderTelefono.ContainerControl = this;
            // 
            // errorProviderMail
            // 
            this.errorProviderMail.ContainerControl = this;
            // 
            // errorProviderGenero
            // 
            this.errorProviderGenero.ContainerControl = this;
            // 
            // errorProviderDiscapacitado
            // 
            this.errorProviderDiscapacitado.ContainerControl = this;
            // 
            // errorProviderKg
            // 
            this.errorProviderKg.ContainerControl = this;
            // 
            // errorProviderButaca
            // 
            this.errorProviderButaca.ContainerControl = this;
            // 
            // lb_Inicio
            // 
            this.lb_Inicio.AutoSize = true;
            this.lb_Inicio.Location = new System.Drawing.Point(12, 9);
            this.lb_Inicio.Name = "lb_Inicio";
            this.lb_Inicio.Size = new System.Drawing.Size(0, 13);
            this.lb_Inicio.TabIndex = 23;
            // 
            // FormCompraPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 332);
            this.Controls.Add(this.lb_Inicio);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.cb_Discapacitado);
            this.Controls.Add(this.lb_Discapacitado);
            this.Controls.Add(this.dataGridButacas);
            this.Controls.Add(this.nud_Kg);
            this.Controls.Add(this.lb_KgAEnviar);
            this.Controls.Add(this.cb_Genero);
            this.Controls.Add(this.lb_Genero);
            this.Controls.Add(this.dtp_FechaNacimiento);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.tb_Telefono);
            this.Controls.Add(this.tb_Direccion);
            this.Controls.Add(this.tb_Apellido);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.tb_DNI);
            this.Controls.Add(this.lb_FechaNacimiento);
            this.Controls.Add(this.lb_Mail);
            this.Controls.Add(this.lb_Telefono);
            this.Controls.Add(this.lb_Direccion);
            this.Controls.Add(this.lb_Apellido);
            this.Controls.Add(this.lb_Nombre);
            this.Controls.Add(this.lb_DNI);
            this.Controls.Add(this.botonSiguiente);
            this.Name = "FormCompraPasajeros";
            this.Text = "Ingreso de datos";
            this.Load += new System.EventHandler(this.FormCompraPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Kg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridButacas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDiscapacitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderButaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Label lb_DNI;
        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Label lb_Apellido;
        private System.Windows.Forms.Label lb_Direccion;
        private System.Windows.Forms.Label lb_Telefono;
        private System.Windows.Forms.Label lb_Mail;
        private System.Windows.Forms.Label lb_FechaNacimiento;
        private System.Windows.Forms.TextBox tb_DNI;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Apellido;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.TextBox tb_Telefono;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private System.Windows.Forms.Label lb_Genero;
        private System.Windows.Forms.ComboBox cb_Genero;
        private System.Windows.Forms.Label lb_KgAEnviar;
        private System.Windows.Forms.NumericUpDown nud_Kg;
        private System.Windows.Forms.DataGridView dataGridButacas;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.ComboBox cb_Discapacitado;
        private System.Windows.Forms.Label lb_Discapacitado;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.ErrorProvider errorProviderDNI;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderApellido;
        private System.Windows.Forms.ErrorProvider errorProviderDireccion;
        private System.Windows.Forms.ErrorProvider errorProviderTelefono;
        private System.Windows.Forms.ErrorProvider errorProviderMail;
        private System.Windows.Forms.ErrorProvider errorProviderGenero;
        private System.Windows.Forms.ErrorProvider errorProviderDiscapacitado;
        private System.Windows.Forms.ErrorProvider errorProviderKg;
        private System.Windows.Forms.ErrorProvider errorProviderButaca;
        private System.Windows.Forms.Label lb_Inicio;
    }
}