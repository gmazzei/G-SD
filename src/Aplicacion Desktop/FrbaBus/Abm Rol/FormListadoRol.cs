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
using FrbaBus.Mensajes;
using System.Text.RegularExpressions;

namespace FrbaBus.Abm_Rol
{
    public partial class FormListadoRol : Form
    {
        public FormListadoRol()
        {
            InitializeComponent();
            this.inicializar();
        }

        private void inicializar()
        {
            this.cargarTablaConTodosLosRoles();

            String[] opcionNadaSiNo = { "", "Si", "No" };
            cb_Habilitado.Items.AddRange(opcionNadaSiNo);
        }

        private void ListadoRol_Load(object sender, EventArgs e)
        {
            //Nada
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.tb_Nombre.ResetText();
            this.cb_Habilitado.Text = "";
            this.errorProviderNombre.Clear();
            this.cargarTablaConTodosLosRoles();
        }


        public void cargarTablaConTodosLosRoles() 
        {
            RolDAO rolDAO = RolDAO.getInstance();

            DataTable roles = rolDAO.getRoles();
            dataGridRol.DataSource = roles;            
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            RolDAO rolDAO = RolDAO.getInstance();

            try
            {
                this.validarEntrada();
                DataTable roles = rolDAO.getRoles(tb_Nombre.Text, cb_Habilitado.Text);
                dataGridRol.DataSource = roles;
            }
            catch(Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        protected void validarEntrada()
        {
            Boolean errores = false;
            Regex reg = new Regex(@"^[a-zA-Z0-9\s]{1,255}$");
            String nombre = tb_Nombre.Text;

            this.errorProviderNombre.Clear();

            if (!String.IsNullOrEmpty(nombre) && !reg.IsMatch(nombre))
            {
                errores = true;
                this.errorProviderNombre.SetError(this.tb_Nombre, "Utilice solo letras, números y espacios.");
            }

            //Dejo esta estructura de if's por si en el futuro quisiera agregar nuevas validaciones.

            if (errores)
            {
                throw new SystemException("Debe corregir los errores marcados para poder realizar la búsqueda.");
            }
        }


        private void dataGridRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            RolDAO rolDAO = RolDAO.getInstance();

            DataGridViewRow fila = dataGridRol.Rows[e.RowIndex];
            int rolID = (int)fila.Cells["ID"].Value;

            if (e.ColumnIndex == dataGridRol.Columns["columnBaja"].Index)
            {
                DialogResult respuesta = mensaje.mostrarPreguntaSiNo("¿Está seguro de que quiere dar de baja el Rol?");
                
                if(respuesta.ToString().Equals("Yes"))
                {
                    rolDAO.bajaRol(rolID);
                    this.cargarTablaConTodosLosRoles();
                }
           
            } else if (e.ColumnIndex == dataGridRol.Columns["columnModificar"].Index) {
                FormModificarRol formModificarRol = new FormModificarRol(rolID, this);
                formModificarRol.Show();

                this.cargarTablaConTodosLosRoles();
            }
            
        }


    }
}
