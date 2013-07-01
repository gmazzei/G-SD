using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Dao;
using FrbaBus.Mensajes;
using FrbaBus.Dominio;

namespace FrbaBus.AbmMicros
{
    public partial class FormListadoMicro : Form
    {
        public FormListadoMicro()
        {
            InitializeComponent();
            this.cargarDatos();
            this.cargarTablaConTodosLosMicros();
        }

        protected void cargarDatos()
        {
            ServicioDAO servicioDAO = ServicioDAO.getInstance();
            String[] opcionSiNoNada = { "", "Si", "No" };
            
            this.cb_BajaFueraServicio.Items.AddRange(opcionSiNoNada);
            this.cb_BajaFueraServicio.Text = "";

            this.cb_BajaVidaUtil.Items.AddRange(opcionSiNoNada);
            this.cb_BajaVidaUtil.Text = "";

            List<TipoServicio> servicios = servicioDAO.getServicios();
            this.cb_TipoServicio.Items.AddRange(servicios.ToArray());
            this.cb_TipoServicio.Items.Add("");
            this.cb_TipoServicio.Text = "";
        }

        public void cargarTablaConTodosLosMicros()
        {
            MicroDAO microDAO = MicroDAO.getInstance();
            this.dataGridMicro.DataSource = microDAO.getMicros();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.tb_Patente.ResetText();
            this.tb_Nro.ResetText();
            this.cb_TipoServicio.Text = "";
            this.cb_BajaVidaUtil.Text = "";
            this.cb_BajaFueraServicio.Text = "";
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            MicroDAO microDAO = MicroDAO.getInstance();

            String patente = this.tb_Patente.Text;
            String nro = this.tb_Nro.Text;
            String tipoServicio = this.cb_TipoServicio.Text;
            String bajaFueraServicio = this.cb_BajaFueraServicio.Text;
            String bajaVidaUtil = this.cb_BajaVidaUtil.Text;

            DataTable tabla = microDAO.getMicro(patente, nro, tipoServicio, bajaFueraServicio, bajaVidaUtil);
            dataGridMicro.DataSource = tabla;
        }

        private void dataGridMicro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            MicroDAO microDAO = MicroDAO.getInstance();
            DataGridViewRow fila = dataGridMicro.Rows[e.RowIndex];
            String microPatente = (String)fila.Cells["Patente"].Value;


            if (e.ColumnIndex == dataGridMicro.Columns["columnBaja"].Index)
            {
                new FormBajaMicro(microPatente, this).Show();
            }
            else if (e.ColumnIndex == dataGridMicro.Columns["columnModificar"].Index)
            {
                FormModifMicro formModificarMicro = new FormModifMicro(microPatente, this);
                formModificarMicro.Show();
            }

            this.cargarTablaConTodosLosMicros();
        }


        private void FormListadoMicro_Load(object sender, EventArgs e)
        {
            //Nada
        }
    }
}
