namespace FrbaBus.Abm_Permisos
{
    partial class FormAbmRol
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
            this.botonAltaRol = new System.Windows.Forms.Button();
            this.botonModificarRol = new System.Windows.Forms.Button();
            this.botonBajaRol = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonListado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAltaRol
            // 
            this.botonAltaRol.Location = new System.Drawing.Point(31, 12);
            this.botonAltaRol.Name = "botonAltaRol";
            this.botonAltaRol.Size = new System.Drawing.Size(145, 23);
            this.botonAltaRol.TabIndex = 0;
            this.botonAltaRol.Text = "Alta de nuevo Rol";
            this.botonAltaRol.UseVisualStyleBackColor = true;
            this.botonAltaRol.Click += new System.EventHandler(this.botonAltaRol_Click);
            // 
            // botonModificarRol
            // 
            this.botonModificarRol.Location = new System.Drawing.Point(31, 41);
            this.botonModificarRol.Name = "botonModificarRol";
            this.botonModificarRol.Size = new System.Drawing.Size(145, 23);
            this.botonModificarRol.TabIndex = 1;
            this.botonModificarRol.Text = "Modificar un Rol";
            this.botonModificarRol.UseVisualStyleBackColor = true;
            this.botonModificarRol.Click += new System.EventHandler(this.botonModificarRol_Click);
            // 
            // botonBajaRol
            // 
            this.botonBajaRol.Location = new System.Drawing.Point(31, 70);
            this.botonBajaRol.Name = "botonBajaRol";
            this.botonBajaRol.Size = new System.Drawing.Size(145, 23);
            this.botonBajaRol.TabIndex = 2;
            this.botonBajaRol.Text = "Dar de Baja un Rol";
            this.botonBajaRol.UseVisualStyleBackColor = true;
            this.botonBajaRol.Click += new System.EventHandler(this.botonBajaRol_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(59, 143);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(85, 23);
            this.botonVolver.TabIndex = 3;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonListado
            // 
            this.botonListado.Location = new System.Drawing.Point(31, 99);
            this.botonListado.Name = "botonListado";
            this.botonListado.Size = new System.Drawing.Size(145, 23);
            this.botonListado.TabIndex = 4;
            this.botonListado.Text = "Listado";
            this.botonListado.UseVisualStyleBackColor = true;
            this.botonListado.Click += new System.EventHandler(this.botonListado_Click);
            // 
            // FormAbmRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 178);
            this.Controls.Add(this.botonListado);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonBajaRol);
            this.Controls.Add(this.botonModificarRol);
            this.Controls.Add(this.botonAltaRol);
            this.Name = "FormAbmRol";
            this.Text = "Abm de Roles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAltaRol;
        private System.Windows.Forms.Button botonModificarRol;
        private System.Windows.Forms.Button botonBajaRol;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonListado;
    }
}