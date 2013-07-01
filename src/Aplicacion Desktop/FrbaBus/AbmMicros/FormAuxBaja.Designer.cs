namespace FrbaBus.AbmMicros
{
    partial class FormAuxBaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Patente = new System.Windows.Forms.TextBox();
            this.boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ningún micro puede reemplazarlo, ingrese la patente del nuevo micro a dar de alta" +
                ".";
            // 
            // tb_Patente
            // 
            this.tb_Patente.Location = new System.Drawing.Point(16, 39);
            this.tb_Patente.Name = "tb_Patente";
            this.tb_Patente.Size = new System.Drawing.Size(100, 20);
            this.tb_Patente.TabIndex = 1;
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(122, 37);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 2;
            this.boton.Text = "Guardar";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // FormAuxBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 95);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.tb_Patente);
            this.Controls.Add(this.label1);
            this.Name = "FormAuxBaja";
            this.Text = "Pregunta";
            this.Load += new System.EventHandler(this.FormAuxBaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Patente;
        private System.Windows.Forms.Button boton;
    }
}