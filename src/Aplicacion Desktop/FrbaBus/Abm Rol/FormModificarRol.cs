using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Dao;
using FrbaBus.Dominio;
using System.Collections.ObjectModel;
using FrbaBus.Mensajes;
using System.Text.RegularExpressions;

namespace FrbaBus.Abm_Rol
{
    public partial class FormModificarRol : FormAltaRol
    {

        private Rol rol;
        private FormListadoRol formListado;

        public FormModificarRol(int rolID, FormListadoRol fListado)
        {
            InitializeComponent();

            this.formListado = fListado;
            RolDAO rolDAO = RolDAO.getInstance();
            this.rol = rolDAO.getRol(rolID);
            this.cargarDatos();
        }

        protected override void inicializar()
        {
            String[] opcionSiNo = { "Si", "No" };
            cb_Habilitado.Items.AddRange(opcionSiNo);

            List<Funcionalidad> funcionalidades = FuncionalidadDAO.getInstance().getFuncionalidades();
            clb_funcionalidad.Items.AddRange(funcionalidades.ToArray());
            
            
        }

        private void cargarDatos()
        {
            tb_nombre.Text = this.rol.nombre;

            if (this.rol.habilitado) {
                cb_Habilitado.Text = "Si";
            } else {
                cb_Habilitado.Text = "No";
            }


            //Marco el checkbox de las funcionalidades habilitadas
            List<String> funcStr = new List<String>();

            foreach (Funcionalidad func in rol.funcionalidades)
            {
                funcStr.Add(func.nombre);
            }

            for (int count = 0; count < clb_funcionalidad.Items.Count; count++)
            {
                if (funcStr.Contains(clb_funcionalidad.Items[count].ToString()))
                {
                    clb_funcionalidad.SetItemChecked(count, true);
                }
            }

        }

        protected override void botonGuardar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            RolDAO rolDAO = RolDAO.getInstance();

            try
            {
                this.validarEntrada();
                this.realizarModificacionesRol();
                
                rolDAO.modificarRol(rol);
                mensaje.mostrarNormal("El Rol se ha modificado satisfactoriamente.");
                
                this.formListado.cargarTablaConTodosLosRoles();
                this.Close();
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private void realizarModificacionesRol()
        {
            this.rol.nombre = tb_nombre.Text;
            this.rol.habilitado = cb_Habilitado.Text.Equals("Si");
            
            List<Funcionalidad> funcionalidadesRol = new List<Funcionalidad>();
            foreach (Funcionalidad unaFuncionalidad in clb_funcionalidad.CheckedItems)
            {
                funcionalidadesRol.Add(unaFuncionalidad);
            }

            this.rol.funcionalidades = funcionalidadesRol;
        }

        private void lb_Habilitado_Click(object sender, EventArgs e)
        {
            //Nada
        }

        protected override void validarEntrada()
        {
            Boolean errores = false;
            Regex reg = new Regex(@"^[a-zA-Z0-9]{1}[a-zA-Z0-9\s]{0,254}$");
            String nombre = this.tb_nombre.Text;

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
                throw new SystemException("Debe corregir los errores marcados para modificar el rol.");
            }

        }        
    }
}
