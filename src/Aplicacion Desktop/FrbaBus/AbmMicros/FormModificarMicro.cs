using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Mensajes;
using FrbaBus.Dao;
using FrbaBus.Dominio;

namespace FrbaBus.AbmMicros
{
    public partial class FormModificarMicro : FormAltaMicro
    {
        private String patente;
        private FormListadoMicro formListado;

        public FormModificarMicro(String patente, FormListadoMicro formListado)
        {
            InitializeComponent();
            /*
            this.cb_BajaVidaUtil.Visible = false;
            this.cb_BajaFueraServicio.Visible = false;
            this.dtp_FechaBajaDefinitiva.Visible = false;
            this.dtp_FechaFueraServicio.Visible = false;
            this.dtp_FechaReinicioServicio.Visible = false;
            this.lb_BajaFueraServicio.Visible = false;
            this.lb_BajaVidaUtil.Visible = false;
            this.lb_FechaBajaDefinitiva.Visible = false;
            this.lb_FechaFueraServicio.Visible = false;
            this.lb_FechaReinicioServicio.Visible = false;
             */
            this.botonLimpiar.Visible = false;
            this.botonAgregarButaca.Visible = false;
            this.lb_Mensaje.Visible = false;
            this.lb_MensajeCantidadButacas.Visible = false;
            this.lb_ButacasActuales.Visible = false;
            this.nud_Piso.Visible = false;
            this.lb_Piso.Visible = false;
            this.cb_TipoButaca.Visible = false;
            this.lb_TipoButaca.Visible = false;
            this.patente = patente;
            this.formListado = formListado;
            MicroDAO microDAO = MicroDAO.getInstance();
            this.cargarDatos(microDAO.getMicro(patente));
        }

        public void cargarDatos(Micro micro)
        {
            this.tb_Patente.Text = micro.patente;
            this.tb_Modelo.Text = micro.modelo;
            this.cb_Marca.Text = micro.marca;
            this.cb_TipoServicio.Text = micro.tipoServicio.nombre;
            this.nud_Nro.Value = micro.numero;
        }

        protected void botonGuardar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            MicroDAO microDAO = MicroDAO.getInstance();

            try
            {
                this.validarEntrada();
                Micro micro = this.crearMicro();
                //microDAO.modificarMicro(micro, this.butacas, this.patente);
                mensaje.mostrarNormal("El micro se ha guardado satisfactoriamente");
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }
    }
}
