namespace FrbaBus.AbmMicros
{
    partial class FormAbmMicros
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
            this.botonAltaMicro = new System.Windows.Forms.Button();
            this.botonModificarMicro = new System.Windows.Forms.Button();
            this.botonBajaMicro = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonListado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAltaMicro
            // 
            this.botonAltaMicro.Location = new System.Drawing.Point(44, 12);
            this.botonAltaMicro.Name = "botonAltaMicro";
            this.botonAltaMicro.Size = new System.Drawing.Size(180, 23);
            this.botonAltaMicro.TabIndex = 0;
            this.botonAltaMicro.Text = "Alta de un nuevo Micro";
            this.botonAltaMicro.UseVisualStyleBackColor = true;
            this.botonAltaMicro.Click += new System.EventHandler(this.botonAltaMicro_Click);
            // 
            // botonModificarMicro
            // 
            this.botonModificarMicro.Location = new System.Drawing.Point(44, 41);
            this.botonModificarMicro.Name = "botonModificarMicro";
            this.botonModificarMicro.Size = new System.Drawing.Size(180, 23);
            this.botonModificarMicro.TabIndex = 1;
            this.botonModificarMicro.Text = "Modificar un Micro";
            this.botonModificarMicro.UseVisualStyleBackColor = true;
            this.botonModificarMicro.Click += new System.EventHandler(this.botonModificarMicro_Click);
            // 
            // botonBajaMicro
            // 
            this.botonBajaMicro.Location = new System.Drawing.Point(44, 70);
            this.botonBajaMicro.Name = "botonBajaMicro";
            this.botonBajaMicro.Size = new System.Drawing.Size(180, 23);
            this.botonBajaMicro.TabIndex = 2;
            this.botonBajaMicro.Text = "Dar de baja un Micro";
            this.botonBajaMicro.UseVisualStyleBackColor = true;
            this.botonBajaMicro.Click += new System.EventHandler(this.botonBajaMicro_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(87, 138);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(88, 23);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonListado
            // 
            this.botonListado.Location = new System.Drawing.Point(44, 99);
            this.botonListado.Name = "botonListado";
            this.botonListado.Size = new System.Drawing.Size(180, 23);
            this.botonListado.TabIndex = 4;
            this.botonListado.Text = "Listado";
            this.botonListado.UseVisualStyleBackColor = true;
            this.botonListado.Click += new System.EventHandler(this.botonListado_Click);
            // 
            // FormAbmMicros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 173);
            this.Controls.Add(this.botonListado);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonBajaMicro);
            this.Controls.Add(this.botonModificarMicro);
            this.Controls.Add(this.botonAltaMicro);
            this.Name = "FormAbmMicros";
            this.Text = "FRBA Bus - Abm de Micro";
            this.Load += new System.EventHandler(this.FormAbmMicros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAltaMicro;
        private System.Windows.Forms.Button botonModificarMicro;
        private System.Windows.Forms.Button botonBajaMicro;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonListado;
    }
}