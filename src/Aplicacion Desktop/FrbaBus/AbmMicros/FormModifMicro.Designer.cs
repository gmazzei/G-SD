namespace FrbaBus.AbmMicros
{
    partial class FormModifMicro
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
            this.cb_Marca = new System.Windows.Forms.ComboBox();
            this.cb_TipoServicio = new System.Windows.Forms.ComboBox();
            this.tb_Patente = new System.Windows.Forms.TextBox();
            this.tb_Modelo = new System.Windows.Forms.TextBox();
            this.lb_TipoServicio = new System.Windows.Forms.Label();
            this.lb_Marca = new System.Windows.Forms.Label();
            this.lb_Patente = new System.Windows.Forms.Label();
            this.lb_Modelo = new System.Windows.Forms.Label();
            this.nud_Nro = new System.Windows.Forms.NumericUpDown();
            this.lb_Nro = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.errorProviderNro = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModelo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPatente = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTipoServicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_FueraServicio = new System.Windows.Forms.Label();
            this.lb_BajaVidaUtil = new System.Windows.Forms.Label();
            this.cb_BajaVidaUtil = new System.Windows.Forms.ComboBox();
            this.cb_FueraServicio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Nro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Marca
            // 
            this.cb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Marca.FormattingEnabled = true;
            this.cb_Marca.Location = new System.Drawing.Point(58, 76);
            this.cb_Marca.Name = "cb_Marca";
            this.cb_Marca.Size = new System.Drawing.Size(121, 21);
            this.cb_Marca.TabIndex = 54;
            // 
            // cb_TipoServicio
            // 
            this.cb_TipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoServicio.FormattingEnabled = true;
            this.cb_TipoServicio.Location = new System.Drawing.Point(105, 100);
            this.cb_TipoServicio.Name = "cb_TipoServicio";
            this.cb_TipoServicio.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoServicio.TabIndex = 51;
            // 
            // tb_Patente
            // 
            this.tb_Patente.Location = new System.Drawing.Point(58, 53);
            this.tb_Patente.Name = "tb_Patente";
            this.tb_Patente.Size = new System.Drawing.Size(100, 20);
            this.tb_Patente.TabIndex = 50;
            // 
            // tb_Modelo
            // 
            this.tb_Modelo.Location = new System.Drawing.Point(58, 30);
            this.tb_Modelo.Name = "tb_Modelo";
            this.tb_Modelo.Size = new System.Drawing.Size(100, 20);
            this.tb_Modelo.TabIndex = 49;
            // 
            // lb_TipoServicio
            // 
            this.lb_TipoServicio.AutoSize = true;
            this.lb_TipoServicio.Location = new System.Drawing.Point(12, 103);
            this.lb_TipoServicio.Name = "lb_TipoServicio";
            this.lb_TipoServicio.Size = new System.Drawing.Size(87, 13);
            this.lb_TipoServicio.TabIndex = 46;
            this.lb_TipoServicio.Text = "Tipo de Servicio:";
            // 
            // lb_Marca
            // 
            this.lb_Marca.AutoSize = true;
            this.lb_Marca.Location = new System.Drawing.Point(12, 79);
            this.lb_Marca.Name = "lb_Marca";
            this.lb_Marca.Size = new System.Drawing.Size(40, 13);
            this.lb_Marca.TabIndex = 45;
            this.lb_Marca.Text = "Marca:";
            // 
            // lb_Patente
            // 
            this.lb_Patente.AutoSize = true;
            this.lb_Patente.Location = new System.Drawing.Point(12, 56);
            this.lb_Patente.Name = "lb_Patente";
            this.lb_Patente.Size = new System.Drawing.Size(47, 13);
            this.lb_Patente.TabIndex = 44;
            this.lb_Patente.Text = "Patente:";
            // 
            // lb_Modelo
            // 
            this.lb_Modelo.AutoSize = true;
            this.lb_Modelo.Location = new System.Drawing.Point(12, 33);
            this.lb_Modelo.Name = "lb_Modelo";
            this.lb_Modelo.Size = new System.Drawing.Size(45, 13);
            this.lb_Modelo.TabIndex = 43;
            this.lb_Modelo.Text = "Modelo:";
            // 
            // nud_Nro
            // 
            this.nud_Nro.Location = new System.Drawing.Point(58, 7);
            this.nud_Nro.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_Nro.Name = "nud_Nro";
            this.nud_Nro.ReadOnly = true;
            this.nud_Nro.Size = new System.Drawing.Size(62, 20);
            this.nud_Nro.TabIndex = 42;
            this.nud_Nro.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_Nro
            // 
            this.lb_Nro.AutoSize = true;
            this.lb_Nro.Location = new System.Drawing.Point(12, 9);
            this.lb_Nro.Name = "lb_Nro";
            this.lb_Nro.Size = new System.Drawing.Size(27, 13);
            this.lb_Nro.TabIndex = 41;
            this.lb_Nro.Text = "Nro:";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(55, 181);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(124, 23);
            this.botonVolver.TabIndex = 56;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(55, 152);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(124, 23);
            this.botonGuardar.TabIndex = 55;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // errorProviderNro
            // 
            this.errorProviderNro.ContainerControl = this;
            // 
            // errorProviderModelo
            // 
            this.errorProviderModelo.ContainerControl = this;
            // 
            // errorProviderPatente
            // 
            this.errorProviderPatente.ContainerControl = this;
            // 
            // errorProviderMarca
            // 
            this.errorProviderMarca.ContainerControl = this;
            // 
            // errorProviderTipoServicio
            // 
            this.errorProviderTipoServicio.ContainerControl = this;
            // 
            // lb_FueraServicio
            // 
            this.lb_FueraServicio.AutoSize = true;
            this.lb_FueraServicio.Location = new System.Drawing.Point(254, 9);
            this.lb_FueraServicio.Name = "lb_FueraServicio";
            this.lb_FueraServicio.Size = new System.Drawing.Size(93, 13);
            this.lb_FueraServicio.TabIndex = 57;
            this.lb_FueraServicio.Text = "Fuera de Servicio:";
            // 
            // lb_BajaVidaUtil
            // 
            this.lb_BajaVidaUtil.AutoSize = true;
            this.lb_BajaVidaUtil.Location = new System.Drawing.Point(254, 33);
            this.lb_BajaVidaUtil.Name = "lb_BajaVidaUtil";
            this.lb_BajaVidaUtil.Size = new System.Drawing.Size(88, 13);
            this.lb_BajaVidaUtil.TabIndex = 58;
            this.lb_BajaVidaUtil.Text = "Baja por vida útil:";
            // 
            // cb_BajaVidaUtil
            // 
            this.cb_BajaVidaUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BajaVidaUtil.FormattingEnabled = true;
            this.cb_BajaVidaUtil.Location = new System.Drawing.Point(353, 29);
            this.cb_BajaVidaUtil.Name = "cb_BajaVidaUtil";
            this.cb_BajaVidaUtil.Size = new System.Drawing.Size(47, 21);
            this.cb_BajaVidaUtil.TabIndex = 59;
            // 
            // cb_FueraServicio
            // 
            this.cb_FueraServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FueraServicio.FormattingEnabled = true;
            this.cb_FueraServicio.Location = new System.Drawing.Point(353, 6);
            this.cb_FueraServicio.Name = "cb_FueraServicio";
            this.cb_FueraServicio.Size = new System.Drawing.Size(47, 21);
            this.cb_FueraServicio.TabIndex = 60;
            // 
            // FormModifMicro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 223);
            this.Controls.Add(this.cb_FueraServicio);
            this.Controls.Add(this.cb_BajaVidaUtil);
            this.Controls.Add(this.lb_BajaVidaUtil);
            this.Controls.Add(this.lb_FueraServicio);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.cb_Marca);
            this.Controls.Add(this.cb_TipoServicio);
            this.Controls.Add(this.tb_Patente);
            this.Controls.Add(this.tb_Modelo);
            this.Controls.Add(this.lb_TipoServicio);
            this.Controls.Add(this.lb_Marca);
            this.Controls.Add(this.lb_Patente);
            this.Controls.Add(this.lb_Modelo);
            this.Controls.Add(this.nud_Nro);
            this.Controls.Add(this.lb_Nro);
            this.Name = "FormModifMicro";
            this.Text = "Modificar un micro";
            this.Load += new System.EventHandler(this.FormModifMicro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Nro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTipoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox cb_Marca;
        protected System.Windows.Forms.ComboBox cb_TipoServicio;
        protected System.Windows.Forms.TextBox tb_Patente;
        protected System.Windows.Forms.TextBox tb_Modelo;
        protected System.Windows.Forms.Label lb_TipoServicio;
        protected System.Windows.Forms.Label lb_Marca;
        protected System.Windows.Forms.Label lb_Patente;
        protected System.Windows.Forms.Label lb_Modelo;
        protected System.Windows.Forms.NumericUpDown nud_Nro;
        protected System.Windows.Forms.Label lb_Nro;
        protected System.Windows.Forms.Button botonVolver;
        protected System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.ErrorProvider errorProviderNro;
        private System.Windows.Forms.ErrorProvider errorProviderModelo;
        private System.Windows.Forms.ErrorProvider errorProviderPatente;
        private System.Windows.Forms.ErrorProvider errorProviderMarca;
        private System.Windows.Forms.ErrorProvider errorProviderTipoServicio;
        protected System.Windows.Forms.ComboBox cb_FueraServicio;
        protected System.Windows.Forms.ComboBox cb_BajaVidaUtil;
        protected System.Windows.Forms.Label lb_BajaVidaUtil;
        protected System.Windows.Forms.Label lb_FueraServicio;
    }
}