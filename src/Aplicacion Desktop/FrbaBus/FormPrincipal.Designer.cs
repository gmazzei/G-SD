using System.Windows.Forms;
using System.Drawing;
using System;
namespace FrbaBus
{
    partial class FormPrincipal
    {


        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.
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

        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        private void InitializeComponent()
        {
            this.botonLogin = new System.Windows.Forms.Button();
            this.botonABMRol = new System.Windows.Forms.Button();
            this.botonCompra = new System.Windows.Forms.Button();
            this.botonDevolucion = new System.Windows.Forms.Button();
            this.botonABMMicro = new System.Windows.Forms.Button();
            this.botonRegistroLlegada = new System.Windows.Forms.Button();
            this.botonConsultaPuntos = new System.Windows.Forms.Button();
            this.botonCanjePuntos = new System.Windows.Forms.Button();
            this.botonListados = new System.Windows.Forms.Button();
            this.botonABMRecorrido = new System.Windows.Forms.Button();
            this.botonGenerarViaje = new System.Windows.Forms.Button();
            this.mensajeBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonLogin
            // 
            this.botonLogin.Location = new System.Drawing.Point(239, 314);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(114, 23);
            this.botonLogin.TabIndex = 0;
            this.botonLogin.Text = "Login";
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_click);
            // 
            // botonABMRol
            // 
            this.botonABMRol.Location = new System.Drawing.Point(24, 193);
            this.botonABMRol.Name = "botonABMRol";
            this.botonABMRol.Size = new System.Drawing.Size(155, 23);
            this.botonABMRol.TabIndex = 1;
            this.botonABMRol.Text = "ABM Rol";
            this.botonABMRol.Visible = false;
            this.botonABMRol.Click += new System.EventHandler(this.botonABMRol_Click);
            // 
            // botonCompra
            // 
            this.botonCompra.Location = new System.Drawing.Point(64, 38);
            this.botonCompra.Name = "botonCompra";
            this.botonCompra.Size = new System.Drawing.Size(237, 24);
            this.botonCompra.TabIndex = 2;
            this.botonCompra.Text = "Compra Pasaje/Encomienda";
            this.botonCompra.Click += new System.EventHandler(this.botonCompra_Click);
            // 
            // botonDevolucion
            // 
            this.botonDevolucion.Location = new System.Drawing.Point(24, 151);
            this.botonDevolucion.Name = "botonDevolucion";
            this.botonDevolucion.Size = new System.Drawing.Size(155, 36);
            this.botonDevolucion.TabIndex = 3;
            this.botonDevolucion.Text = "Devolucion de Pasaje/Encomienda";
            this.botonDevolucion.Visible = false;
            this.botonDevolucion.Click += new System.EventHandler(this.botonDevolucion_Click);
            // 
            // botonABMMicro
            // 
            this.botonABMMicro.Location = new System.Drawing.Point(185, 193);
            this.botonABMMicro.Name = "botonABMMicro";
            this.botonABMMicro.Size = new System.Drawing.Size(150, 23);
            this.botonABMMicro.TabIndex = 4;
            this.botonABMMicro.Text = "ABM Micros";
            this.botonABMMicro.Visible = false;
            this.botonABMMicro.Click += new System.EventHandler(this.botonABMMicro_Click);
            // 
            // botonRegistroLlegada
            // 
            this.botonRegistroLlegada.Location = new System.Drawing.Point(185, 151);
            this.botonRegistroLlegada.Name = "botonRegistroLlegada";
            this.botonRegistroLlegada.Size = new System.Drawing.Size(150, 36);
            this.botonRegistroLlegada.TabIndex = 5;
            this.botonRegistroLlegada.Text = "Registrar Llegada de Micro";
            this.botonRegistroLlegada.Visible = false;
            this.botonRegistroLlegada.Click += new System.EventHandler(this.botonRegistroLlegada_Click);
            // 
            // botonConsultaPuntos
            // 
            this.botonConsultaPuntos.Location = new System.Drawing.Point(64, 68);
            this.botonConsultaPuntos.Name = "botonConsultaPuntos";
            this.botonConsultaPuntos.Size = new System.Drawing.Size(237, 23);
            this.botonConsultaPuntos.TabIndex = 6;
            this.botonConsultaPuntos.Text = "Consulta de Puntos";
            this.botonConsultaPuntos.Click += new System.EventHandler(this.botonConsultaPuntos_Click);
            // 
            // botonCanjePuntos
            // 
            this.botonCanjePuntos.Location = new System.Drawing.Point(64, 97);
            this.botonCanjePuntos.Name = "botonCanjePuntos";
            this.botonCanjePuntos.Size = new System.Drawing.Size(237, 23);
            this.botonCanjePuntos.TabIndex = 7;
            this.botonCanjePuntos.Text = "Canje de Puntos";
            this.botonCanjePuntos.Click += new System.EventHandler(this.botonCanjePuntos_Click);
            // 
            // botonListados
            // 
            this.botonListados.Location = new System.Drawing.Point(96, 251);
            this.botonListados.Name = "botonListados";
            this.botonListados.Size = new System.Drawing.Size(174, 23);
            this.botonListados.TabIndex = 8;
            this.botonListados.Text = "Listados Estadisticos";
            this.botonListados.Visible = false;
            this.botonListados.Click += new System.EventHandler(this.botonListados_Click);
            // 
            // botonABMRecorrido
            // 
            this.botonABMRecorrido.Location = new System.Drawing.Point(24, 222);
            this.botonABMRecorrido.Name = "botonABMRecorrido";
            this.botonABMRecorrido.Size = new System.Drawing.Size(155, 23);
            this.botonABMRecorrido.TabIndex = 9;
            this.botonABMRecorrido.Text = "ABM Recorrido";
            this.botonABMRecorrido.Visible = false;
            this.botonABMRecorrido.Click += new System.EventHandler(this.botonABMRecorrido_Click);
            // 
            // botonGenerarViaje
            // 
            this.botonGenerarViaje.Location = new System.Drawing.Point(185, 222);
            this.botonGenerarViaje.Name = "botonGenerarViaje";
            this.botonGenerarViaje.Size = new System.Drawing.Size(150, 23);
            this.botonGenerarViaje.TabIndex = 10;
            this.botonGenerarViaje.Text = "Generar Viaje";
            this.botonGenerarViaje.Visible = false;
            this.botonGenerarViaje.Click += new System.EventHandler(this.botonGenerarViaje_Click);
            // 
            // mensajeBienvenida
            // 
            this.mensajeBienvenida.AutoSize = true;
            this.mensajeBienvenida.Location = new System.Drawing.Point(12, 9);
            this.mensajeBienvenida.Name = "mensajeBienvenida";
            this.mensajeBienvenida.Size = new System.Drawing.Size(124, 13);
            this.mensajeBienvenida.TabIndex = 11;
            this.mensajeBienvenida.Text = "Bienvenido a FRBA Bus!";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 349);
            this.Controls.Add(this.mensajeBienvenida);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.botonABMRol);
            this.Controls.Add(this.botonCompra);
            this.Controls.Add(this.botonDevolucion);
            this.Controls.Add(this.botonABMMicro);
            this.Controls.Add(this.botonRegistroLlegada);
            this.Controls.Add(this.botonConsultaPuntos);
            this.Controls.Add(this.botonCanjePuntos);
            this.Controls.Add(this.botonListados);
            this.Controls.Add(this.botonABMRecorrido);
            this.Controls.Add(this.botonGenerarViaje);
            this.Name = "FormPrincipal";
            this.Text = "FRBA Bus - Ventana Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mensajeBienvenida;
        public Button botonABMRol;
        public Button botonABMMicro;
        public Button botonABMRecorrido;
        public Button botonGenerarViaje;
        public Button botonRegistroLlegada;
        public Button botonLogin;
        public Button botonConsultaPuntos;
        public Button botonCanjePuntos;
        public Button botonCompra;
        public Button botonDevolucion;
        public Button botonListados;


    }
}