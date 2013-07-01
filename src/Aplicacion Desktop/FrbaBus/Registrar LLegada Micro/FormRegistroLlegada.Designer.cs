namespace FrbaBus.Registrar_LLegada_Micro
{
    partial class FormRegistroLlegada
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
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.lb_Patente = new System.Windows.Forms.Label();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.lb_CiudadOrigen = new System.Windows.Forms.Label();
            this.lb_CiudadDestino = new System.Windows.Forms.Label();
            this.cb_CiudadOrigen = new System.Windows.Forms.ComboBox();
            this.cb_CiudadDestino = new System.Windows.Forms.ComboBox();
            this.cb_Patente = new System.Windows.Forms.ComboBox();
            this.errorProviderCiudadOrigen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCiudadDestino = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPatente = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudadOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudadDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.CustomFormat = "dd/MM/yyyy       hh:mm:ss";
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fecha.Location = new System.Drawing.Point(65, 35);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(220, 20);
            this.dtp_Fecha.TabIndex = 5;
            // 
            // lb_Patente
            // 
            this.lb_Patente.AutoSize = true;
            this.lb_Patente.Location = new System.Drawing.Point(12, 9);
            this.lb_Patente.Name = "lb_Patente";
            this.lb_Patente.Size = new System.Drawing.Size(47, 13);
            this.lb_Patente.TabIndex = 6;
            this.lb_Patente.Text = "Patente:";
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Location = new System.Drawing.Point(12, 38);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(40, 13);
            this.lb_Fecha.TabIndex = 8;
            this.lb_Fecha.Text = "Fecha:";
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(89, 149);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 9;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(170, 149);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 10;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // lb_CiudadOrigen
            // 
            this.lb_CiudadOrigen.AutoSize = true;
            this.lb_CiudadOrigen.Location = new System.Drawing.Point(12, 71);
            this.lb_CiudadOrigen.Name = "lb_CiudadOrigen";
            this.lb_CiudadOrigen.Size = new System.Drawing.Size(75, 13);
            this.lb_CiudadOrigen.TabIndex = 11;
            this.lb_CiudadOrigen.Text = "Ciudad origen:";
            // 
            // lb_CiudadDestino
            // 
            this.lb_CiudadDestino.AutoSize = true;
            this.lb_CiudadDestino.Location = new System.Drawing.Point(12, 101);
            this.lb_CiudadDestino.Name = "lb_CiudadDestino";
            this.lb_CiudadDestino.Size = new System.Drawing.Size(80, 13);
            this.lb_CiudadDestino.TabIndex = 12;
            this.lb_CiudadDestino.Text = "Ciudad destino:";
            // 
            // cb_CiudadOrigen
            // 
            this.cb_CiudadOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CiudadOrigen.FormattingEnabled = true;
            this.cb_CiudadOrigen.Location = new System.Drawing.Point(98, 68);
            this.cb_CiudadOrigen.Name = "cb_CiudadOrigen";
            this.cb_CiudadOrigen.Size = new System.Drawing.Size(121, 21);
            this.cb_CiudadOrigen.TabIndex = 13;
            // 
            // cb_CiudadDestino
            // 
            this.cb_CiudadDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CiudadDestino.FormattingEnabled = true;
            this.cb_CiudadDestino.Location = new System.Drawing.Point(98, 98);
            this.cb_CiudadDestino.Name = "cb_CiudadDestino";
            this.cb_CiudadDestino.Size = new System.Drawing.Size(121, 21);
            this.cb_CiudadDestino.TabIndex = 14;
            // 
            // cb_Patente
            // 
            this.cb_Patente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Patente.FormattingEnabled = true;
            this.cb_Patente.Location = new System.Drawing.Point(65, 6);
            this.cb_Patente.Name = "cb_Patente";
            this.cb_Patente.Size = new System.Drawing.Size(121, 21);
            this.cb_Patente.TabIndex = 15;
            // 
            // errorProviderCiudadOrigen
            // 
            this.errorProviderCiudadOrigen.ContainerControl = this;
            // 
            // errorProviderCiudadDestino
            // 
            this.errorProviderCiudadDestino.ContainerControl = this;
            // 
            // errorProviderPatente
            // 
            this.errorProviderPatente.ContainerControl = this;
            // 
            // FormRegistroLlegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 184);
            this.Controls.Add(this.cb_Patente);
            this.Controls.Add(this.cb_CiudadDestino);
            this.Controls.Add(this.cb_CiudadOrigen);
            this.Controls.Add(this.lb_CiudadDestino);
            this.Controls.Add(this.lb_CiudadOrigen);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.lb_Patente);
            this.Controls.Add(this.dtp_Fecha);
            this.Name = "FormRegistroLlegada";
            this.Text = "FRBA Bus - Registrar llegada de Micro";
            this.Load += new System.EventHandler(this.FormRegistroLlegada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudadOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudadDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label lb_Patente;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label lb_CiudadOrigen;
        private System.Windows.Forms.Label lb_CiudadDestino;
        private System.Windows.Forms.ComboBox cb_CiudadOrigen;
        private System.Windows.Forms.ComboBox cb_CiudadDestino;
        private System.Windows.Forms.ComboBox cb_Patente;
        private System.Windows.Forms.ErrorProvider errorProviderCiudadOrigen;
        private System.Windows.Forms.ErrorProvider errorProviderCiudadDestino;
        private System.Windows.Forms.ErrorProvider errorProviderPatente;
    }
}