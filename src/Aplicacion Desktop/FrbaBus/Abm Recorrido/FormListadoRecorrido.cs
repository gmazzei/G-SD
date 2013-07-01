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
using FrbaBus.Mensajes;
using System.Text.RegularExpressions;

namespace FrbaBus.Abm_Recorrido
{
    public partial class FormListadoRecorrido : Form
    {
        public FormListadoRecorrido()
        {
            InitializeComponent();
            this.cargarDatos();
            this.cargarTabla();
        }

        private void FormListadoRecorrido_Load(object sender, EventArgs e)
        {

        }

        protected void cargarDatos()
        {
            List<TipoServicio> servicios = ServicioDAO.getInstance().getServicios();
            cb_TipoServicio.Items.Add("");
            cb_TipoServicio.Items.AddRange(servicios.ToArray());
            
            String[] opcionSiNo = { "", "Si", "No" };
            cb_Habilitado.Items.AddRange(opcionSiNo);
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            tb_Codigo.ResetText();
            tb_CiudadOrigen.ResetText();
            tb_CiudadDestino.ResetText();

            cb_TipoServicio.Text = "";
            cb_Habilitado.Text = "";

            this.cargarTabla();
        }

        public void cargarTabla()
        {
            RecorridoDAO recorridoDAO = RecorridoDAO.getInstance();

            DataTable recorridos = recorridoDAO.getRecorridos();
            dataGridRecorrido.DataSource = recorridos;            
        
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;

            try
            {
                this.validarEntrada();
                DataTable recorridos = this.buscar();
                dataGridRecorrido.DataSource = recorridos;
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }

        }

        private DataTable buscar()
        { 
            RecorridoDAO recorridoDAO = RecorridoDAO.getInstance();
            DataTable recorridos = recorridoDAO.getRecorridos(tb_Codigo.Text, tb_CiudadOrigen.Text, tb_CiudadDestino.Text, cb_TipoServicio.Text, cb_Habilitado.Text);

            return recorridos;
        }

        private void validarEntrada()
        {
            long lresult;
            Boolean errores = false;

            this.errorProviderCodigo.Clear();

            if (!String.IsNullOrEmpty(tb_Codigo.Text) && !long.TryParse(tb_Codigo.Text, out lresult))
            {
                errorProviderCodigo.SetError(tb_Codigo, "El valor debe ser un numero");
                errores = true;
            }

            //Dejo esta estructura de if's por si quisiera agregar mas validaciones en el futuro.

            if (errores)
            {
                throw new SystemException("Debe corregir los errores marcados para realizar la búsqueda.");
            }
        }

        private void dataGridRecorrido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Mensaje mensaje = Mensaje.Instance;
            RecorridoDAO recorridoDAO = RecorridoDAO.getInstance();
            DataGridViewRow fila = dataGridRecorrido.Rows[e.RowIndex];
            long recorridoID = Convert.ToInt64(fila.Cells["ID"].Value);
            

            if (e.ColumnIndex == dataGridRecorrido.Columns["columnBaja"].Index)
            {
                DialogResult respuesta = mensaje.mostrarPreguntaSiNo("¿Esta seguro de que quiere dar de baja el Recorrido?");

                if (respuesta.ToString().Equals("Yes"))
                {
                    recorridoDAO.bajaRecorrido(recorridoID);
                    mensaje.mostrarNormal("El recorrido fue dado de baja.");
                }

            }
            else if (e.ColumnIndex == dataGridRecorrido.Columns["columnModificar"].Index)
            {
                FormModificarRecorrido formModificarRecorrido = new FormModificarRecorrido(recorridoID, this);
                formModificarRecorrido.Show();
            }

            this.cargarTabla();
        }

        private void botonCiudadOrigen_Click(object sender, EventArgs e)
        {
            new FormBusquedaCiudades(this.tb_CiudadOrigen).Show();
        }

        private void botonCiudadDestino_Click(object sender, EventArgs e)
        {
            new FormBusquedaCiudades(this.tb_CiudadDestino).Show();
        }

        private void botonLimpiarCiudadOrigen_Click(object sender, EventArgs e)
        {
            this.tb_CiudadOrigen.ResetText();
        }

        private void botonLimpiarCiudadDestino_Click(object sender, EventArgs e)
        {
            this.tb_CiudadDestino.ResetText();
        }


    }
}
