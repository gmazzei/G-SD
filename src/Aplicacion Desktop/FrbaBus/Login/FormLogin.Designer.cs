using System.Windows.Forms;
using System.Drawing;
namespace FrbaBus.Login
{
    partial class FormLogin
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
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.mensajeLogin = new System.Windows.Forms.Label();
            this.botonLoguearse = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.labelErrores = new System.Windows.Forms.Label();
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(12, 40);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(61, 13);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username: ";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(79, 37);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(126, 20);
            this.tb_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(79, 63);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(126, 20);
            this.tb_password.TabIndex = 3;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // mensajeLogin
            // 
            this.mensajeLogin.AutoSize = true;
            this.mensajeLogin.Location = new System.Drawing.Point(12, 9);
            this.mensajeLogin.Name = "mensajeLogin";
            this.mensajeLogin.Size = new System.Drawing.Size(350, 13);
            this.mensajeLogin.TabIndex = 4;
            this.mensajeLogin.Text = "Por favor, ingrese su username y password para tener acceso al sistema.";
            // 
            // botonLoguearse
            // 
            this.botonLoguearse.Location = new System.Drawing.Point(15, 98);
            this.botonLoguearse.Name = "botonLoguearse";
            this.botonLoguearse.Size = new System.Drawing.Size(122, 23);
            this.botonLoguearse.TabIndex = 5;
            this.botonLoguearse.Text = "Login";
            this.botonLoguearse.UseVisualStyleBackColor = true;
            this.botonLoguearse.Click += new System.EventHandler(this.botonLoguearse_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(15, 127);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(122, 23);
            this.botonCancelar.TabIndex = 6;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // labelErrores
            // 
            this.labelErrores.AutoSize = true;
            this.labelErrores.Location = new System.Drawing.Point(12, 173);
            this.labelErrores.Name = "labelErrores";
            this.labelErrores.Size = new System.Drawing.Size(0, 13);
            this.labelErrores.TabIndex = 7;
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 192);
            this.Controls.Add(this.labelErrores);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonLoguearse);
            this.Controls.Add(this.mensajeLogin);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_username);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_username;
        private TextBox tb_username;
        private Label label1;
        private TextBox tb_password;
        private Label mensajeLogin;
        private Button botonLoguearse;
        private Button botonCancelar;
        private Label labelErrores;
        private ErrorProvider errorProviderUsername;
        private ErrorProvider errorProviderPassword;
    }
}