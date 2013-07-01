using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FrbaBus.Dao;
using FrbaBus.Mensajes;

namespace FrbaBus.Abm_Recorrido
{
    public partial class FormBusquedaCiudades : Form
    {
        private TextBox textBox;

        public FormBusquedaCiudades(TextBox textBox)
        {
            InitializeComponent();
            this.textBox = textBox;
            this.cargarTablaConTodasLasCiudades();
        }

        private void cargarTablaConTodasLasCiudades()
        {
            CiudadDAO ciudadDAO = CiudadDAO.getInstance();
            DataTable tabla = ciudadDAO.getTodasLasCiudadesComoTabla();
            this.dataGridCiudades.DataSource = tabla;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.tb_Nombre.ResetText();
            this.errorProviderNombre.Clear();
            this.cargarTablaConTodasLasCiudades();
        }

        private void validarEntrada()
        {
            String nombre = tb_Nombre.Text;
            Regex reg = new Regex(@"^[a-zA-Z0-9\s]{1,255}$");
            Boolean errores = false;

            this.errorProviderNombre.Clear();

            if(!String.IsNullOrEmpty(nombre) && !reg.IsMatch(nombre))
            {
                this.errorProviderNombre.SetError(tb_Nombre, "Solo se permiten letras y números.");
                errores = true;
            }

            //Dejo esta estructura de if's por si se quieren agregar nuevas validaciones en el futuro

            if (errores)
            {
                throw new SystemException("Debe corregir los errores marcados para realizar la búsqueda.");
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            CiudadDAO ciudadDAO = CiudadDAO.getInstance();
            try
            { 
                this.validarEntrada();
                String nombre = this.tb_Nombre.Text;
                DataTable tabla = ciudadDAO.buscarCiudades(nombre);
                this.dataGridCiudades.DataSource = tabla;
            }
            catch(Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private void dataGridCiudades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;

            DataGridViewRow fila = dataGridCiudades.Rows[e.RowIndex];
            int ciudadID = (int)fila.Cells["ID"].Value;
            String ciudadNombre = (String)fila.Cells["Nombre"].Value;

            if (e.ColumnIndex == dataGridCiudades.Columns["columnSeleccionar"].Index)
            {
                this.textBox.Text = ciudadNombre;
                this.Close();
            }
        }

        private void FormBusquedaCiudades_Load(object sender, EventArgs e)
        {
            //Nada
        }
    }
}
