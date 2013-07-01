namespace FrbaBus.GenerarViaje
{
    partial class FormGenerarViaje
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
            this.lb_RecorridoCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lb_Fecha = new System.Windows.Forms.Label();
            this.lb_FechaLlegadaEstimada = new System.Windows.Forms.Label();
            this.dtp_FechaLlegadaEstimada = new System.Windows.Forms.DateTimePicker();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.errorProviderCodigoRecorrido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMicroPatente = new System.Windows.Forms.ErrorProvider(this.components);
            this.cb_PatenteMicro = new System.Windows.Forms.ComboBox();
            this.cb_RecorridoCodigo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodigoRecorrido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMicroPatente)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_RecorridoCodigo
            // 
            this.lb_RecorridoCodigo.AutoSize = true;
            this.lb_RecorridoCodigo.Location = new System.Drawing.Point(13, 13);
            this.lb_RecorridoCodigo.Name = "lb_RecorridoCodigo";
            this.lb_RecorridoCodigo.Size = new System.Drawing.Size(107, 13);
            this.lb_RecorridoCodigo.TabIndex = 0;
            this.lb_RecorridoCodigo.Text = "Codigo de Recorrido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patente de Micro:";
            // 
            // dtp_FechaSalida
            // 
            this.dtp_FechaSalida.CustomFormat = "dd/MM/yyyy   hh:mm:ss";
            this.dtp_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FechaSalida.Location = new System.Drawing.Point(91, 77);
            this.dtp_FechaSalida.Name = "dtp_FechaSalida";
            this.dtp_FechaSalida.Size = new System.Drawing.Size(194, 20);
            this.dtp_FechaSalida.TabIndex = 4;
            // 
            // lb_Fecha
            // 
            this.lb_Fecha.AutoSize = true;
            this.lb_Fecha.Location = new System.Drawing.Point(13, 78);
            this.lb_Fecha.Name = "lb_Fecha";
            this.lb_Fecha.Size = new System.Drawing.Size(72, 13);
            this.lb_Fecha.TabIndex = 5;
            this.lb_Fecha.Text = "Fecha Salida:";
            // 
            // lb_FechaLlegadaEstimada
            // 
            this.lb_FechaLlegadaEstimada.AutoSize = true;
            this.lb_FechaLlegadaEstimada.Location = new System.Drawing.Point(13, 112);
            this.lb_FechaLlegadaEstimada.Name = "lb_FechaLlegadaEstimada";
            this.lb_FechaLlegadaEstimada.Size = new System.Drawing.Size(137, 13);
            this.lb_FechaLlegadaEstimada.TabIndex = 7;
            this.lb_FechaLlegadaEstimada.Text = "Fecha de llegada estimada:";
            // 
            // dtp_FechaLlegadaEstimada
            // 
            this.dtp_FechaLlegadaEstimada.CustomFormat = "dd/MM/yyyy   hh:mm:ss";
            this.dtp_FechaLlegadaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FechaLlegadaEstimada.Location = new System.Drawing.Point(156, 109);
            this.dtp_FechaLlegadaEstimada.Name = "dtp_FechaLlegadaEstimada";
            this.dtp_FechaLlegadaEstimada.Size = new System.Drawing.Size(194, 20);
            this.dtp_FechaLlegadaEstimada.TabIndex = 6;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(295, 151);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 8;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(295, 180);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 9;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // errorProviderCodigoRecorrido
            // 
            this.errorProviderCodigoRecorrido.ContainerControl = this;
            // 
            // errorProviderMicroPatente
            // 
            this.errorProviderMicroPatente.ContainerControl = this;
            // 
            // cb_PatenteMicro
            // 
            this.cb_PatenteMicro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PatenteMicro.FormattingEnabled = true;
            this.cb_PatenteMicro.Location = new System.Drawing.Point(110, 39);
            this.cb_PatenteMicro.Name = "cb_PatenteMicro";
            this.cb_PatenteMicro.Size = new System.Drawing.Size(121, 21);
            this.cb_PatenteMicro.TabIndex = 10;
            // 
            // cb_RecorridoCodigo
            // 
            this.cb_RecorridoCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_RecorridoCodigo.FormattingEnabled = true;
            this.cb_RecorridoCodigo.Location = new System.Drawing.Point(127, 13);
            this.cb_RecorridoCodigo.Name = "cb_RecorridoCodigo";
            this.cb_RecorridoCodigo.Size = new System.Drawing.Size(121, 21);
            this.cb_RecorridoCodigo.TabIndex = 11;
            // 
            // FormGenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 212);
            this.Controls.Add(this.cb_RecorridoCodigo);
            this.Controls.Add(this.cb_PatenteMicro);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.lb_FechaLlegadaEstimada);
            this.Controls.Add(this.dtp_FechaLlegadaEstimada);
            this.Controls.Add(this.lb_Fecha);
            this.Controls.Add(this.dtp_FechaSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_RecorridoCodigo);
            this.Name = "FormGenerarViaje";
            this.Text = "FRBA Bus - Generar viaje";
            this.Load += new System.EventHandler(this.FormGenerarViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCodigoRecorrido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMicroPatente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_RecorridoCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_FechaSalida;
        private System.Windows.Forms.Label lb_Fecha;
        private System.Windows.Forms.Label lb_FechaLlegadaEstimada;
        private System.Windows.Forms.DateTimePicker dtp_FechaLlegadaEstimada;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.ErrorProvider errorProviderCodigoRecorrido;
        private System.Windows.Forms.ErrorProvider errorProviderMicroPatente;
        private System.Windows.Forms.ComboBox cb_PatenteMicro;
        private System.Windows.Forms.ComboBox cb_RecorridoCodigo;
    }
}