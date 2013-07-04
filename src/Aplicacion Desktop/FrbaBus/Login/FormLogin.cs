using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Mensajes;
using FrbaBus.Dominio;
using FrbaBus.Dao;
using FrbaBus.Global;
using System.Text.RegularExpressions;

namespace FrbaBus.Login
{
    public partial class FormLogin : Form
    {
        FormPrincipal formPrincipal;

        public FormLogin(FormPrincipal formularioPrincipal)
        {
            InitializeComponent();
            Aplicacion.getFecha();
            this.formPrincipal = formularioPrincipal;
        }


        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonLoguearse_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = UsuarioDAO.getInstance();
            Mensaje mensaje = Mensaje.Instance;

            try
            {
                this.quitarAcceso();
                this.validarEntrada(tb_username.Text, tb_password.Text);
                Usuario usuario = usuarioDAO.login(tb_username.Text, tb_password.Text);

                if (usuario != null)
                {
                    this.darAcceso(usuario.rol.ID);
                    UsuarioLogueado.usuario = usuario;
                    Aplicacion.resetearIntentosFallidos();
                    mensaje.mostrarNormal("Acceso autorizado.\nBienvenido a FRBA Bus.");
                    this.Close();
                }
                else
                {
                    this.quitarAcceso();
                    UsuarioLogueado.usuario = null;
                    Aplicacion.aumentarIntentosFallidos();

                    if (Aplicacion.getIntentosFallidos() < 3)
                    {
                        mensaje.mostrarNormal("Usuario y password no válidos.");
                    }
                    else
                    {
                        this.Close();
                        this.formPrincipal.inhabilitarLogin();
                        throw new SystemException("Ha superado los 3 intentos de Login. Ésta funcionalidad será deshabilitada por seguridad.");
                    }

                }

            }
            catch(Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
            
        }


        private void quitarAcceso()
        {
            formPrincipal.botonABMRol.Visible = false;
            formPrincipal.botonABMRecorrido.Visible = false;
            formPrincipal.botonABMMicro.Visible = false;
            formPrincipal.botonGenerarViaje.Visible = false;
            formPrincipal.botonRegistroLlegada.Visible = false;
            formPrincipal.botonListados.Visible = false;   
            formPrincipal.botonDevolucion.Visible = false;
        }

        private void darAcceso(int rolID)
        {
            RolDAO rolDAO = RolDAO.getInstance();
            Rol rol = rolDAO.getRolHabilitado(rolID);

            foreach (Funcionalidad funcionalidad in rol.funcionalidades)
            { 
                if (funcionalidad.nombre.Equals("ABM Rol"))
                {
                    formPrincipal.botonABMRol.Visible = true;
                }

                if (funcionalidad.nombre.Equals("ABM Recorrido"))
                {
                    formPrincipal.botonABMRecorrido.Visible = true;
                }

                if (funcionalidad.nombre.Equals("ABM Micro"))
                {
                    formPrincipal.botonABMMicro.Visible = true;
                }

                if (funcionalidad.nombre.Equals("Generar Viaje"))
                {
                    formPrincipal.botonGenerarViaje.Visible = true;
                }

                if (funcionalidad.nombre.Equals("Registro de llegada a Destino"))
                {
                    formPrincipal.botonRegistroLlegada.Visible = true;
                }

                if (funcionalidad.nombre.Equals("Listado estadistico"))
                {
                    formPrincipal.botonListados.Visible = true;
                }

                if (funcionalidad.nombre.Equals("Cancelacion de pasaje/encomienda"))
                {
                    formPrincipal.botonDevolucion.Visible = true;
                }
            }
            
        }

        private void validarEntrada(String username, String password)
        {
            Regex reg = new Regex(@"^[a-zA-Z0-9]{1,30}$");
            Boolean errores = false;

            errorProviderUsername.Clear();
            errorProviderPassword.Clear();

            if (String.IsNullOrEmpty(username))
            {
                errorProviderUsername.SetError(tb_username, "Campo obligatorio");
                errores = true;
            }
            else if (!reg.IsMatch(username))
            {
                errorProviderUsername.SetError(tb_username, "No se permiten símbolos especiales, solo letras y números");
                errores = true;
            }

            if (String.IsNullOrEmpty(password))
            {
                errorProviderPassword.SetError(tb_password, "Campo obligatorio");
                errores = true;
            }
            else if (!reg.IsMatch(password))
            {
                errorProviderPassword.SetError(tb_password, "No se permiten símbolos especiales, solo letras y números");
                errores = true;
            }

            if (errores)
            {
                Aplicacion.aumentarIntentosFallidos();

                if (Aplicacion.getIntentosFallidos() < 3)
                {
                    throw new SystemException("Se ha producido un error con sus credenciales de acceso. Por favor, corrija los errores.");
                }
                else
                {
                    this.Close();
                    this.formPrincipal.inhabilitarLogin();
                    throw new SystemException("Ha superado los 3 intentos de Login. Ésta funcionalidad será deshabilitada por seguridad.");
                }
                
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //Nada
        }

    }
}
