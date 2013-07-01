namespace FrbaBus.Devoluciones
{
    partial class FormDevoluciones
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
            this.lb_CompraNro = new System.Windows.Forms.Label();
            this.tb_CompraNro = new System.Windows.Forms.TextBox();
            this.tb_Motivo = new System.Windows.Forms.TextBox();
            this.lb_Motivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.lb_Mensaje = new System.Windows.Forms.Label();
            this.botonRealizarDevolucion = new System.Windows.Forms.Button();
            this.errorProviderNroCompra = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMotivo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNumero = new System.Windows.Forms.ErrorProvider(this.components);
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.lb_Tipo = new System.Windows.Forms.Label();
            this.lb_PasajesAgregados = new System.Windows.Forms.Label();
            this.lb_EncomiendasAgregadas = new System.Windows.Forms.Label();
            this.lb_CantidadPasajes = new System.Windows.Forms.Label();
            this.lb_CantidadEncomiendas = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNroCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMotivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CompraNro
            // 
            this.lb_CompraNro.AutoSize = true;
            this.lb_CompraNro.Location = new System.Drawing.Point(13, 13);
            this.lb_CompraNro.Name = "lb_CompraNro";
            this.lb_CompraNro.Size = new System.Drawing.Size(66, 13);
            this.lb_CompraNro.TabIndex = 0;
            this.lb_CompraNro.Text = "Nro Compra:";
            // 
            // tb_CompraNro
            // 
            this.tb_CompraNro.Location = new System.Drawing.Point(86, 13);
            this.tb_CompraNro.Name = "tb_CompraNro";
            this.tb_CompraNro.Size = new System.Drawing.Size(176, 20);
            this.tb_CompraNro.TabIndex = 1;
            // 
            // tb_Motivo
            // 
            this.tb_Motivo.Location = new System.Drawing.Point(86, 39);
            this.tb_Motivo.Name = "tb_Motivo";
            this.tb_Motivo.Size = new System.Drawing.Size(176, 20);
            this.tb_Motivo.TabIndex = 2;
            // 
            // lb_Motivo
            // 
            this.lb_Motivo.AutoSize = true;
            this.lb_Motivo.Location = new System.Drawing.Point(37, 42);
            this.lb_Motivo.Name = "lb_Motivo";
            this.lb_Motivo.Size = new System.Drawing.Size(42, 13);
            this.lb_Motivo.TabIndex = 3;
            this.lb_Motivo.Text = "Motivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nro de Pasaje/Encomienda:";
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Location = new System.Drawing.Point(161, 113);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(130, 20);
            this.tb_Codigo.TabIndex = 5;
            // 
            // lb_Mensaje
            // 
            this.lb_Mensaje.AutoSize = true;
            this.lb_Mensaje.Location = new System.Drawing.Point(14, 88);
            this.lb_Mensaje.Name = "lb_Mensaje";
            this.lb_Mensaje.Size = new System.Drawing.Size(397, 13);
            this.lb_Mensaje.TabIndex = 7;
            this.lb_Mensaje.Text = "Ingrese un Nro y luego elija si agregarlo a la devolción como pasaje o encomienda" +
                ".";
            // 
            // botonRealizarDevolucion
            // 
            this.botonRealizarDevolucion.Location = new System.Drawing.Point(403, 213);
            this.botonRealizarDevolucion.Name = "botonRealizarDevolucion";
            this.botonRealizarDevolucion.Size = new System.Drawing.Size(130, 31);
            this.botonRealizarDevolucion.TabIndex = 9;
            this.botonRealizarDevolucion.Text = "Realizar devolución";
            this.botonRealizarDevolucion.UseVisualStyleBackColor = true;
            this.botonRealizarDevolucion.Click += new System.EventHandler(this.botonRealizarDevolucion_Click);
            // 
            // errorProviderNroCompra
            // 
            this.errorProviderNroCompra.ContainerControl = this;
            // 
            // errorProviderMotivo
            // 
            this.errorProviderMotivo.ContainerControl = this;
            // 
            // errorProviderNumero
            // 
            this.errorProviderNumero.ContainerControl = this;
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Location = new System.Drawing.Point(161, 139);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(130, 21);
            this.cb_Tipo.TabIndex = 10;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(297, 137);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(80, 23);
            this.botonAgregar.TabIndex = 11;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // lb_Tipo
            // 
            this.lb_Tipo.AutoSize = true;
            this.lb_Tipo.Location = new System.Drawing.Point(124, 142);
            this.lb_Tipo.Name = "lb_Tipo";
            this.lb_Tipo.Size = new System.Drawing.Size(31, 13);
            this.lb_Tipo.TabIndex = 12;
            this.lb_Tipo.Text = "Tipo:";
            // 
            // lb_PasajesAgregados
            // 
            this.lb_PasajesAgregados.AutoSize = true;
            this.lb_PasajesAgregados.Location = new System.Drawing.Point(12, 175);
            this.lb_PasajesAgregados.Name = "lb_PasajesAgregados";
            this.lb_PasajesAgregados.Size = new System.Drawing.Size(100, 13);
            this.lb_PasajesAgregados.TabIndex = 13;
            this.lb_PasajesAgregados.Text = "Pasajes agregados:";
            // 
            // lb_EncomiendasAgregadas
            // 
            this.lb_EncomiendasAgregadas.AutoSize = true;
            this.lb_EncomiendasAgregadas.Location = new System.Drawing.Point(12, 193);
            this.lb_EncomiendasAgregadas.Name = "lb_EncomiendasAgregadas";
            this.lb_EncomiendasAgregadas.Size = new System.Drawing.Size(127, 13);
            this.lb_EncomiendasAgregadas.TabIndex = 14;
            this.lb_EncomiendasAgregadas.Text = "Encomiendas agregadas:";
            // 
            // lb_CantidadPasajes
            // 
            this.lb_CantidadPasajes.AutoSize = true;
            this.lb_CantidadPasajes.Location = new System.Drawing.Point(118, 175);
            this.lb_CantidadPasajes.Name = "lb_CantidadPasajes";
            this.lb_CantidadPasajes.Size = new System.Drawing.Size(13, 13);
            this.lb_CantidadPasajes.TabIndex = 15;
            this.lb_CantidadPasajes.Text = "0";
            // 
            // lb_CantidadEncomiendas
            // 
            this.lb_CantidadEncomiendas.AutoSize = true;
            this.lb_CantidadEncomiendas.Location = new System.Drawing.Point(147, 193);
            this.lb_CantidadEncomiendas.Name = "lb_CantidadEncomiendas";
            this.lb_CantidadEncomiendas.Size = new System.Drawing.Size(13, 13);
            this.lb_CantidadEncomiendas.TabIndex = 16;
            this.lb_CantidadEncomiendas.Text = "0";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 221);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(80, 23);
            this.botonLimpiar.TabIndex = 17;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // FormDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 255);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.lb_CantidadEncomiendas);
            this.Controls.Add(this.lb_CantidadPasajes);
            this.Controls.Add(this.lb_EncomiendasAgregadas);
            this.Controls.Add(this.lb_PasajesAgregados);
            this.Controls.Add(this.lb_Tipo);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.botonRealizarDevolucion);
            this.Controls.Add(this.lb_Mensaje);
            this.Controls.Add(this.tb_Codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Motivo);
            this.Controls.Add(this.tb_Motivo);
            this.Controls.Add(this.tb_CompraNro);
            this.Controls.Add(this.lb_CompraNro);
            this.Name = "FormDevoluciones";
            this.Text = "FRBA Bus - Devolución";
            this.Load += new System.EventHandler(this.FormDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNroCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMotivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CompraNro;
        private System.Windows.Forms.TextBox tb_CompraNro;
        private System.Windows.Forms.TextBox tb_Motivo;
        private System.Windows.Forms.Label lb_Motivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.Label lb_Mensaje;
        private System.Windows.Forms.Button botonRealizarDevolucion;
        private System.Windows.Forms.ErrorProvider errorProviderNroCompra;
        private System.Windows.Forms.ErrorProvider errorProviderMotivo;
        private System.Windows.Forms.ErrorProvider errorProviderNumero;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.ComboBox cb_Tipo;
        private System.Windows.Forms.Label lb_Tipo;
        private System.Windows.Forms.Label lb_EncomiendasAgregadas;
        private System.Windows.Forms.Label lb_PasajesAgregados;
        private System.Windows.Forms.Label lb_CantidadEncomiendas;
        private System.Windows.Forms.Label lb_CantidadPasajes;
        private System.Windows.Forms.Button botonLimpiar;
    }
}