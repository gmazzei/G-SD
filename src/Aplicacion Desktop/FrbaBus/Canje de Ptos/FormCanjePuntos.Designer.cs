namespace FrbaBus.Canje_de_Ptos
{
    partial class FormCanjePuntos
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
            this.tb_DNI = new System.Windows.Forms.TextBox();
            this.cb_Producto = new System.Windows.Forms.ComboBox();
            this.lb_Producto = new System.Windows.Forms.Label();
            this.lb_Cantidad = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonCanjear = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.errorProviderDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProducto = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_DNI
            // 
            this.lb_DNI.AutoSize = true;
            this.lb_DNI.Location = new System.Drawing.Point(12, 9);
            this.lb_DNI.Name = "lb_DNI";
            this.lb_DNI.Size = new System.Drawing.Size(29, 13);
            this.lb_DNI.TabIndex = 0;
            this.lb_DNI.Text = "DNI:";
            // 
            // tb_DNI
            // 
            this.tb_DNI.Location = new System.Drawing.Point(44, 6);
            this.tb_DNI.Name = "tb_DNI";
            this.tb_DNI.Size = new System.Drawing.Size(106, 20);
            this.tb_DNI.TabIndex = 1;
            // 
            // cb_Producto
            // 
            this.cb_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Producto.FormattingEnabled = true;
            this.cb_Producto.Location = new System.Drawing.Point(71, 40);
            this.cb_Producto.Name = "cb_Producto";
            this.cb_Producto.Size = new System.Drawing.Size(128, 21);
            this.cb_Producto.TabIndex = 2;
            // 
            // lb_Producto
            // 
            this.lb_Producto.AutoSize = true;
            this.lb_Producto.Location = new System.Drawing.Point(12, 43);
            this.lb_Producto.Name = "lb_Producto";
            this.lb_Producto.Size = new System.Drawing.Size(53, 13);
            this.lb_Producto.TabIndex = 3;
            this.lb_Producto.Text = "Producto:";
            // 
            // lb_Cantidad
            // 
            this.lb_Cantidad.AutoSize = true;
            this.lb_Cantidad.Location = new System.Drawing.Point(13, 76);
            this.lb_Cantidad.Name = "lb_Cantidad";
            this.lb_Cantidad.Size = new System.Drawing.Size(52, 13);
            this.lb_Cantidad.TabIndex = 4;
            this.lb_Cantidad.Text = "Cantidad:";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(263, 124);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(110, 23);
            this.botonCancelar.TabIndex = 6;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonCanjear
            // 
            this.botonCanjear.Location = new System.Drawing.Point(263, 95);
            this.botonCanjear.Name = "botonCanjear";
            this.botonCanjear.Size = new System.Drawing.Size(110, 23);
            this.botonCanjear.TabIndex = 7;
            this.botonCanjear.Text = "Realizar canje";
            this.botonCanjear.UseVisualStyleBackColor = true;
            this.botonCanjear.Click += new System.EventHandler(this.botonCanjear_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(16, 124);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 8;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Location = new System.Drawing.Point(71, 74);
            this.nud_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(42, 20);
            this.nud_Cantidad.TabIndex = 9;
            this.nud_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errorProviderDNI
            // 
            this.errorProviderDNI.ContainerControl = this;
            // 
            // errorProviderProducto
            // 
            this.errorProviderProducto.ContainerControl = this;
            // 
            // FormCanjePuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 159);
            this.Controls.Add(this.nud_Cantidad);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonCanjear);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.lb_Cantidad);
            this.Controls.Add(this.lb_Producto);
            this.Controls.Add(this.cb_Producto);
            this.Controls.Add(this.tb_DNI);
            this.Controls.Add(this.lb_DNI);
            this.Name = "FormCanjePuntos";
            this.Text = "FRBA Bus - Canje de Puntos";
            this.Load += new System.EventHandler(this.FormCanjePuntos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DNI;
        private System.Windows.Forms.TextBox tb_DNI;
        private System.Windows.Forms.ComboBox cb_Producto;
        private System.Windows.Forms.Label lb_Producto;
        private System.Windows.Forms.Label lb_Cantidad;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonCanjear;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.ErrorProvider errorProviderDNI;
        private System.Windows.Forms.ErrorProvider errorProviderProducto;
    }
}