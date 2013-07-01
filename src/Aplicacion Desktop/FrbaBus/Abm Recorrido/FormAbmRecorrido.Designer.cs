namespace FrbaBus.Abm_Recorrido
{
    partial class FormAbmRecorrido
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
            this.botonAlta = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonBaja = new System.Windows.Forms.Button();
            this.botonListado = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAlta
            // 
            this.botonAlta.Location = new System.Drawing.Point(12, 12);
            this.botonAlta.Name = "botonAlta";
            this.botonAlta.Size = new System.Drawing.Size(155, 23);
            this.botonAlta.TabIndex = 0;
            this.botonAlta.Text = "Alta de Recorrido";
            this.botonAlta.UseVisualStyleBackColor = true;
            this.botonAlta.Click += new System.EventHandler(this.botonAlta_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(12, 41);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(155, 23);
            this.botonModificar.TabIndex = 1;
            this.botonModificar.Text = "Modificar Recorrido";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonBaja
            // 
            this.botonBaja.Location = new System.Drawing.Point(12, 70);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(155, 23);
            this.botonBaja.TabIndex = 2;
            this.botonBaja.Text = "Dar de Baja un Recorrido";
            this.botonBaja.UseVisualStyleBackColor = true;
            this.botonBaja.Click += new System.EventHandler(this.botonBaja_Click);
            // 
            // botonListado
            // 
            this.botonListado.Location = new System.Drawing.Point(12, 99);
            this.botonListado.Name = "botonListado";
            this.botonListado.Size = new System.Drawing.Size(155, 23);
            this.botonListado.TabIndex = 3;
            this.botonListado.Text = "Listado";
            this.botonListado.UseVisualStyleBackColor = true;
            this.botonListado.Click += new System.EventHandler(this.botonListado_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Volver";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormAbmRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 178);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.botonListado);
            this.Controls.Add(this.botonBaja);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonAlta);
            this.Name = "FormAbmRecorrido";
            this.Text = "Abm de Recorrido";
            this.Load += new System.EventHandler(this.FormAbmRecorrido_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAlta;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonBaja;
        private System.Windows.Forms.Button botonListado;
        private System.Windows.Forms.Button button5;
    }
}