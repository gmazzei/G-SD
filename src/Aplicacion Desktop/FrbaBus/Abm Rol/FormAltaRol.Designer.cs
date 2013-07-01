namespace FrbaBus.Abm_Rol
{
    partial class FormAltaRol
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
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.clb_funcionalidad = new System.Windows.Forms.CheckedListBox();
            this.lb_Funcionalidad = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.lb_Habilitado = new System.Windows.Forms.Label();
            this.cb_Habilitado = new System.Windows.Forms.ComboBox();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(13, 13);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(47, 13);
            this.lb_Nombre.TabIndex = 0;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(66, 10);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(122, 20);
            this.tb_nombre.TabIndex = 1;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(197, 253);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 2;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(197, 224);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 3;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // clb_funcionalidad
            // 
            this.clb_funcionalidad.CheckOnClick = true;
            this.clb_funcionalidad.FormattingEnabled = true;
            this.clb_funcionalidad.Location = new System.Drawing.Point(105, 76);
            this.clb_funcionalidad.Name = "clb_funcionalidad";
            this.clb_funcionalidad.Size = new System.Drawing.Size(167, 124);
            this.clb_funcionalidad.TabIndex = 4;
            // 
            // lb_Funcionalidad
            // 
            this.lb_Funcionalidad.AutoSize = true;
            this.lb_Funcionalidad.Location = new System.Drawing.Point(12, 76);
            this.lb_Funcionalidad.Name = "lb_Funcionalidad";
            this.lb_Funcionalidad.Size = new System.Drawing.Size(87, 13);
            this.lb_Funcionalidad.TabIndex = 5;
            this.lb_Funcionalidad.Text = "Funcionalidades:";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(12, 253);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // lb_Habilitado
            // 
            this.lb_Habilitado.AutoSize = true;
            this.lb_Habilitado.Location = new System.Drawing.Point(13, 42);
            this.lb_Habilitado.Name = "lb_Habilitado";
            this.lb_Habilitado.Size = new System.Drawing.Size(57, 13);
            this.lb_Habilitado.TabIndex = 7;
            this.lb_Habilitado.Text = "Habilitado:";
            // 
            // cb_Habilitado
            // 
            this.cb_Habilitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Habilitado.FormattingEnabled = true;
            this.cb_Habilitado.Location = new System.Drawing.Point(76, 39);
            this.cb_Habilitado.Name = "cb_Habilitado";
            this.cb_Habilitado.Size = new System.Drawing.Size(121, 21);
            this.cb_Habilitado.TabIndex = 8;
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // FormAltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 308);
            this.Controls.Add(this.cb_Habilitado);
            this.Controls.Add(this.lb_Habilitado);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.lb_Funcionalidad);
            this.Controls.Add(this.clb_funcionalidad);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.lb_Nombre);
            this.Name = "FormAltaRol";
            this.Text = "FRBA Bus - Alta de Rol";
            this.Load += new System.EventHandler(this.FormAltaRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lb_Nombre;
        protected System.Windows.Forms.TextBox tb_nombre;
        protected System.Windows.Forms.Button botonCancelar;
        protected System.Windows.Forms.Button botonGuardar;
        protected System.Windows.Forms.Label lb_Funcionalidad;
        protected System.Windows.Forms.CheckedListBox clb_funcionalidad;
        protected System.Windows.Forms.Button botonLimpiar;
        protected System.Windows.Forms.Label lb_Habilitado;
        protected System.Windows.Forms.ComboBox cb_Habilitado;
        protected System.Windows.Forms.ErrorProvider errorProviderNombre;

    }
}