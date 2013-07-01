namespace FrbaBus.AbmMicros
{
    partial class FormBajaMicro
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
            this.lb_FechaBajaDefinitiva = new System.Windows.Forms.Label();
            this.dtp_FechaBajaDefinitiva = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaReinicioServicio = new System.Windows.Forms.DateTimePicker();
            this.lb_FechaReinicioServicio = new System.Windows.Forms.Label();
            this.lb_FechaFueraServicio = new System.Windows.Forms.Label();
            this.lb_BajaFueraServicio = new System.Windows.Forms.Label();
            this.lb_BajaVidaUtil = new System.Windows.Forms.Label();
            this.dtp_FechaFueraServicio = new System.Windows.Forms.DateTimePicker();
            this.botonBajaFueraServicio = new System.Windows.Forms.Button();
            this.botonBajaVidaUtil = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_FechaBajaDefinitiva
            // 
            this.lb_FechaBajaDefinitiva.AutoSize = true;
            this.lb_FechaBajaDefinitiva.Location = new System.Drawing.Point(12, 136);
            this.lb_FechaBajaDefinitiva.Name = "lb_FechaBajaDefinitiva";
            this.lb_FechaBajaDefinitiva.Size = new System.Drawing.Size(123, 13);
            this.lb_FechaBajaDefinitiva.TabIndex = 39;
            this.lb_FechaBajaDefinitiva.Text = "Fecha de baja definitiva:";
            // 
            // dtp_FechaBajaDefinitiva
            // 
            this.dtp_FechaBajaDefinitiva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaBajaDefinitiva.Location = new System.Drawing.Point(148, 133);
            this.dtp_FechaBajaDefinitiva.Name = "dtp_FechaBajaDefinitiva";
            this.dtp_FechaBajaDefinitiva.Size = new System.Drawing.Size(107, 20);
            this.dtp_FechaBajaDefinitiva.TabIndex = 38;
            // 
            // dtp_FechaReinicioServicio
            // 
            this.dtp_FechaReinicioServicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaReinicioServicio.Location = new System.Drawing.Point(148, 60);
            this.dtp_FechaReinicioServicio.Name = "dtp_FechaReinicioServicio";
            this.dtp_FechaReinicioServicio.Size = new System.Drawing.Size(107, 20);
            this.dtp_FechaReinicioServicio.TabIndex = 37;
            // 
            // lb_FechaReinicioServicio
            // 
            this.lb_FechaReinicioServicio.AutoSize = true;
            this.lb_FechaReinicioServicio.Location = new System.Drawing.Point(12, 63);
            this.lb_FechaReinicioServicio.Name = "lb_FechaReinicioServicio";
            this.lb_FechaReinicioServicio.Size = new System.Drawing.Size(130, 13);
            this.lb_FechaReinicioServicio.TabIndex = 36;
            this.lb_FechaReinicioServicio.Text = "Fecha reinicio de servicio:";
            // 
            // lb_FechaFueraServicio
            // 
            this.lb_FechaFueraServicio.AutoSize = true;
            this.lb_FechaFueraServicio.Location = new System.Drawing.Point(12, 40);
            this.lb_FechaFueraServicio.Name = "lb_FechaFueraServicio";
            this.lb_FechaFueraServicio.Size = new System.Drawing.Size(121, 13);
            this.lb_FechaFueraServicio.TabIndex = 35;
            this.lb_FechaFueraServicio.Text = "Fecha fuera de servicio:";
            // 
            // lb_BajaFueraServicio
            // 
            this.lb_BajaFueraServicio.AutoSize = true;
            this.lb_BajaFueraServicio.Location = new System.Drawing.Point(12, 12);
            this.lb_BajaFueraServicio.Name = "lb_BajaFueraServicio";
            this.lb_BajaFueraServicio.Size = new System.Drawing.Size(130, 13);
            this.lb_BajaFueraServicio.TabIndex = 33;
            this.lb_BajaFueraServicio.Text = "Baja por fuera de servicio:";
            // 
            // lb_BajaVidaUtil
            // 
            this.lb_BajaVidaUtil.AutoSize = true;
            this.lb_BajaVidaUtil.Location = new System.Drawing.Point(12, 111);
            this.lb_BajaVidaUtil.Name = "lb_BajaVidaUtil";
            this.lb_BajaVidaUtil.Size = new System.Drawing.Size(88, 13);
            this.lb_BajaVidaUtil.TabIndex = 31;
            this.lb_BajaVidaUtil.Text = "Baja por vida útil:";
            // 
            // dtp_FechaFueraServicio
            // 
            this.dtp_FechaFueraServicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaFueraServicio.Location = new System.Drawing.Point(148, 37);
            this.dtp_FechaFueraServicio.Name = "dtp_FechaFueraServicio";
            this.dtp_FechaFueraServicio.Size = new System.Drawing.Size(107, 20);
            this.dtp_FechaFueraServicio.TabIndex = 30;
            // 
            // botonBajaFueraServicio
            // 
            this.botonBajaFueraServicio.Location = new System.Drawing.Point(148, 7);
            this.botonBajaFueraServicio.Name = "botonBajaFueraServicio";
            this.botonBajaFueraServicio.Size = new System.Drawing.Size(75, 23);
            this.botonBajaFueraServicio.TabIndex = 40;
            this.botonBajaFueraServicio.Text = "Dar de baja";
            this.botonBajaFueraServicio.UseVisualStyleBackColor = true;
            this.botonBajaFueraServicio.Click += new System.EventHandler(this.botonBajaFueraServicio_Click);
            // 
            // botonBajaVidaUtil
            // 
            this.botonBajaVidaUtil.Location = new System.Drawing.Point(148, 106);
            this.botonBajaVidaUtil.Name = "botonBajaVidaUtil";
            this.botonBajaVidaUtil.Size = new System.Drawing.Size(75, 23);
            this.botonBajaVidaUtil.TabIndex = 41;
            this.botonBajaVidaUtil.Text = "Dar de baja";
            this.botonBajaVidaUtil.UseVisualStyleBackColor = true;
            this.botonBajaVidaUtil.Click += new System.EventHandler(this.botonBajaVidaUtil_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(296, 165);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 42;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // FormBajaMicro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 200);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonBajaVidaUtil);
            this.Controls.Add(this.botonBajaFueraServicio);
            this.Controls.Add(this.lb_FechaBajaDefinitiva);
            this.Controls.Add(this.dtp_FechaBajaDefinitiva);
            this.Controls.Add(this.dtp_FechaReinicioServicio);
            this.Controls.Add(this.lb_FechaReinicioServicio);
            this.Controls.Add(this.lb_FechaFueraServicio);
            this.Controls.Add(this.lb_BajaFueraServicio);
            this.Controls.Add(this.lb_BajaVidaUtil);
            this.Controls.Add(this.dtp_FechaFueraServicio);
            this.Name = "FormBajaMicro";
            this.Text = "FRBA Bus - Baja de un Micro";
            this.Load += new System.EventHandler(this.FormBajaMicro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_FechaBajaDefinitiva;
        private System.Windows.Forms.DateTimePicker dtp_FechaBajaDefinitiva;
        private System.Windows.Forms.DateTimePicker dtp_FechaReinicioServicio;
        private System.Windows.Forms.Label lb_FechaReinicioServicio;
        private System.Windows.Forms.Label lb_FechaFueraServicio;
        private System.Windows.Forms.Label lb_BajaFueraServicio;
        private System.Windows.Forms.Label lb_BajaVidaUtil;
        private System.Windows.Forms.DateTimePicker dtp_FechaFueraServicio;
        private System.Windows.Forms.Button botonBajaFueraServicio;
        private System.Windows.Forms.Button botonBajaVidaUtil;
        private System.Windows.Forms.Button botonVolver;
    }
}