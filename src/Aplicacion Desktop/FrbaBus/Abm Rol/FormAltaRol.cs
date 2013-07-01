using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Dominio;
using FrbaBus.Dao;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using FrbaBus.Mensajes;
using System.Data.SqlClient;

namespace FrbaBus.Abm_Rol
{
    public partial class FormAltaRol : Form
    {
        public FormAltaRol()
        {
            InitializeComponent();
            this.inicializar();
        }

        protected virtual void inicializar()
        {
            String[] opcionSiNo = { "Si", "No" };
            cb_Habilitado.Items.AddRange(opcionSiNo);
            cb_Habilitado.Text = "Si";
            
            List<Funcionalidad> funcionalidades = FuncionalidadDAO.getInstance().getFuncionalidades();
            clb_funcionalidad.Items.AddRange(funcionalidades.ToArray());
        }

        private void FormAltaRol_Load(object sender, EventArgs e)
        {
            //Nada
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void botonGuardar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            RolDAO rolDAO = RolDAO.getInstance();
            Rol rol;

            try
            {
                this.validarEntrada();
                rol = this.crearRol();
                rolDAO.guardarNuevoRol(rol);
                mensaje.mostrarNormal("El Rol se ha guardado satisfactoriamente.");
                this.limpiar();
            }
            catch(Exception ex) 
            {
                mensaje.mostrarNormal(ex.Message);
            }

        }

        private Rol crearRol()
        {
            Rol rol = new Rol();
            
            rol.nombre = tb_nombre.Text;
            rol.habilitado = cb_Habilitado.Text.Equals("Si");

            List<Funcionalidad> funcionalidadesRol = new List<Funcionalidad>();
            foreach (Funcionalidad unaFuncionalidad in clb_funcionalidad.CheckedItems)
            {
                funcionalidadesRol.Add(unaFuncionalidad);
            }

            rol.funcionalidades = funcionalidadesRol;

            return rol;
        }


        protected virtual void validarEntrada()
        {
            Boolean errores = false;
            Regex reg = new Regex(@"^[a-zA-Z0-9]{1}[a-zA-Z0-9\s]{0,254}$");
            String nombre = tb_nombre.Text;

            this.errorProviderNombre.Clear();


            if (String.IsNullOrEmpty(nombre))
            {
                errores = true;
                this.errorProviderNombre.SetError(this.tb_nombre, "Campo obligatorio");
            }
            else if (!reg.IsMatch(nombre))
            {
                errores = true;
                this.errorProviderNombre.SetError(this.tb_nombre, "Utilice solo letras, números. \nTambién puede utilizar espacios para separar palabras");
            }

            
            if (errores)
            {
                throw new SystemException("Debe corregir los errores marcados para guardar el nuevo rol.");
            }

        }


        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void limpiar()
        {
            this.tb_nombre.ResetText();
            this.cb_Habilitado.Text = "Si";

            for (int i = 0; i < clb_funcionalidad.Items.Count; i++)
            {
                clb_funcionalidad.SetItemChecked(i, false);
            }

            this.errorProviderNombre.Clear();
        }



   
    }
}
