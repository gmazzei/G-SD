namespace FrbaBus.Consulta_Puntos_Adquiridos
{
    partial class FormConsultaPuntos
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
            this.lb_DNI = new System.Windows.Forms.Label();
            this.lb_Puntos = new System.Windows.Forms.Label();
            this.lb_CantidadPuntos = new System.Windows.Forms.Label();
            this.tb_DNI = new System.Windows.Forms.TextBox();
            this.lb_Registro = new System.Windows.Forms.Label();
            this.lb_RegistroCanjes = new System.Windows.Forms.Label();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.dataGridRegistro = new System.Windows.Forms.DataGridView();
            this.dataGridCanjes = new System.Windows.Forms.DataGridView();
            this.errorProviderDNI = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCanjes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_DNI
            // 
            this.lb_DNI.AutoSize = true;
            this.lb_DNI.Location = new System.Drawing.Point(13, 13);
            this.lb_DNI.Name = "lb_DNI";
            this.lb_DNI.Size = new System.Drawing.Size(29, 13);
            this.lb_DNI.TabIndex = 0;
            this.lb_DNI.Text = "DNI:";
            // 
            // lb_Puntos
            // 
            this.lb_Puntos.AutoSize = true;
            this.lb_Puntos.Location = new System.Drawing.Point(215, 13);
            this.lb_Puntos.Name = "lb_Puntos";
            this.lb_Puntos.Size = new System.Drawing.Size(43, 13);
            this.lb_Puntos.TabIndex = 1;
            this.lb_Puntos.Text = "Puntos:";
            // 
            // lb_CantidadPuntos
            // 
            this.lb_CantidadPuntos.AutoSize = true;
            this.lb_CantidadPuntos.Location = new System.Drawing.Point(263, 13);
            this.lb_CantidadPuntos.Name = "lb_CantidadPuntos";
            this.lb_CantidadPuntos.Size = new System.Drawing.Size(57, 13);
            this.lb_CantidadPuntos.TabIndex = 2;
            this.lb_CantidadPuntos.Text = "Sin puntos";
            // 
            // tb_DNI
            // 
            this.tb_DNI.Location = new System.Drawing.Point(48, 10);
            this.tb_DNI.Name = "tb_DNI";
            this.tb_DNI.Size = new System.Drawing.Size(141, 20);
            this.tb_DNI.TabIndex = 3;
            // 
            // lb_Registro
            // 
            this.lb_Registro.AutoSize = true;
            this.lb_Registro.Location = new System.Drawing.Point(9, 53);
            this.lb_Registro.Name = "lb_Registro";
            this.lb_Registro.Size = new System.Drawing.Size(46, 13);
            this.lb_Registro.TabIndex = 6;
            this.lb_Registro.Text = "Registro";
            // 
            // lb_RegistroCanjes
            // 
            this.lb_RegistroCanjes.AutoSize = true;
            this.lb_RegistroCanjes.Location = new System.Drawing.Point(349, 53);
            this.lb_RegistroCanjes.Name = "lb_RegistroCanjes";
            this.lb_RegistroCanjes.Size = new System.Drawing.Size(39, 13);
            this.lb_RegistroCanjes.TabIndex = 7;
            this.lb_RegistroCanjes.Text = "Canjes";
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(352, 10);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(72, 23);
            this.botonCalcular.TabIndex = 8;
            this.botonCalcular.Text = "Ver Puntos";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(430, 10);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(72, 23);
            this.botonCancelar.TabIndex = 9;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // dataGridRegistro
            // 
            this.dataGridRegistro.AllowUserToAddRows = false;
            this.dataGridRegistro.AllowUserToDeleteRows = false;
            this.dataGridRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistro.Location = new System.Drawing.Point(12, 69);
            this.dataGridRegistro.Name = "dataGridRegistro";
            this.dataGridRegistro.ReadOnly = true;
            this.dataGridRegistro.Size = new System.Drawing.Size(308, 150);
            this.dataGridRegistro.TabIndex = 10;
            // 
            // dataGridCanjes
            // 
            this.dataGridCanjes.AllowUserToAddRows = false;
            this.dataGridCanjes.AllowUserToDeleteRows = false;
            this.dataGridCanjes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCanjes.Location = new System.Drawing.Point(352, 69);
            this.dataGridCanjes.Name = "dataGridCanjes";
            this.dataGridCanjes.ReadOnly = true;
            this.dataGridCanjes.Size = new System.Drawing.Size(317, 150);
            this.dataGridCanjes.TabIndex = 11;
            // 
            // errorProviderDNI
            // 
            this.errorProviderDNI.ContainerControl = this;
            // 
            // FormConsultaPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 231);
            this.Controls.Add(this.dataGridCanjes);
            this.Controls.Add(this.dataGridRegistro);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.lb_RegistroCanjes);
            this.Controls.Add(this.lb_Registro);
            this.Controls.Add(this.tb_DNI);
            this.Controls.Add(this.lb_CantidadPuntos);
            this.Controls.Add(this.lb_Puntos);
            this.Controls.Add(this.lb_DNI);
            this.Name = "FormConsultaPuntos";
            this.Text = "FRBA Bus - Consulta de Puntos";
            this.Load += new System.EventHandler(this.FormConsultaPuntos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCanjes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DNI;
        private System.Windows.Forms.Label lb_Puntos;
        private System.Windows.Forms.Label lb_CantidadPuntos;
        private System.Windows.Forms.TextBox tb_DNI;
        private System.Windows.Forms.Label lb_Registro;
        private System.Windows.Forms.Label lb_RegistroCanjes;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.DataGridView dataGridRegistro;
        private System.Windows.Forms.DataGridView dataGridCanjes;
        private System.Windows.Forms.ErrorProvider errorProviderDNI;
    }
}