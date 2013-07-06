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
using System.Text.RegularExpressions;

namespace FrbaBus.Listados_Estadisticos
{
    public partial class FormListadosEstadisticos : Form
    {
        public FormListadosEstadisticos()
        {
            InitializeComponent();
            this.inicializar();
        }

        private void inicializar()
        { 
            object[] opSemestre = {1,2};
            this.cb_Semestre.Items.AddRange(opSemestre);
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonDestinosConMasPasajesComprados_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            CompraDAO compraDAO = CompraDAO.getInstance();
            try
            {
                this.validarEntrada();

                int anio = Convert.ToInt32(tb_Anio.Text);
                int semestre = Convert.ToInt32(cb_Semestre.Text); 

                DataTable tabla = compraDAO.getDestinosConMasPasajesComprados(anio, semestre);
                dataGrid.DataSource = tabla;
            }
            catch(Exception ex) 
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private void botonDestinosConMasMicrosVacios_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            CompraDAO compraDAO = CompraDAO.getInstance();
            try
            {
                this.validarEntrada();

                int anio = Convert.ToInt32(tb_Anio.Text);
                int semestre = Convert.ToInt32(cb_Semestre.Text);

                DataTable tabla = compraDAO.getDestinosConMicrosMasVacios(anio, semestre);
                dataGrid.DataSource = tabla;
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private void botonClientesConMasPuntos_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            ClienteDAO clienteDAO = ClienteDAO.getInstance();
            try
            {
                this.validarEntrada();

                int anio = Convert.ToInt32(tb_Anio.Text);
                int semestre = Convert.ToInt32(cb_Semestre.Text);

                DataTable tabla = clienteDAO.getClientesConMasPuntosHastaLaFecha(anio, semestre);
                dataGrid.DataSource = tabla;
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private void botonDestinosConMasPasajesCancelados_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            CompraDAO compraDAO = CompraDAO.getInstance();
            try
            {
                this.validarEntrada();

                int anio = Convert.ToInt32(tb_Anio.Text);
                int semestre = Convert.ToInt32(cb_Semestre.Text);

                DataTable tabla = compraDAO.getDestinosConMasPasajesCancelados(anio, semestre);
                dataGrid.DataSource = tabla;
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private void botonMicrosConMasDiasFueraDeServicio_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            MicroDAO microDAO = MicroDAO.getInstance();
            try
            {
                this.validarEntrada();

                int anio = Convert.ToInt32(tb_Anio.Text);
                int semestre = Convert.ToInt32(cb_Semestre.Text);

                DataTable tabla = microDAO.getMicrosConMasDiasFueraDeServicio(anio, semestre);
                dataGrid.DataSource = tabla;
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private void FormListadosEstadisticos_Load(object sender, EventArgs e)
        {
            //Nada
        }

        private void validarEntrada()
        {
            Boolean errores = false;
            Regex reg = new Regex(@"^[0-9]{1,4}$");

            this.errorProviderAnio.Clear();
            this.errorProviderSemestre.Clear();

            if (String.IsNullOrEmpty(this.tb_Anio.Text))
            {
                this.errorProviderAnio.SetError(this.tb_Anio, "Campo obligatorio");
                errores = true;
            } 
            else if (!reg.IsMatch(this.tb_Anio.Text))
            {
                this.errorProviderAnio.SetError(this.tb_Anio, "Debe ser un año");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.cb_Semestre.Text))
            {
                this.errorProviderAnio.SetError(this.cb_Semestre, "Campo obligatorio");
                errores = true;
            }

            if (errores)
            {
                throw new SystemException("Debe corregir los errores para continuar.");
            }
        }

        

 
    }
}
