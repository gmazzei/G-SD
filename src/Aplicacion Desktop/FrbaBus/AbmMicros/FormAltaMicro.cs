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
using FrbaBus.Global;

namespace FrbaBus.AbmMicros
{

    public partial class FormAltaMicro : Form
    {

        public List<Butaca> butacas = new List<Butaca>();

        public FormAltaMicro()
        {
            InitializeComponent();
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            ServicioDAO servicioDAO = ServicioDAO.getInstance();
            List<TipoServicio> servicios = servicioDAO.getServicios();
            this.cb_TipoServicio.Items.AddRange(servicios.ToArray());
            this.cb_TipoServicio.Text = "Cama";
            
            String[] opcionButaca = { "Ventanilla", "Pasillo" };
            this.cb_TipoButaca.Items.AddRange(opcionButaca);
            this.cb_TipoButaca.Text = "Ventanilla";

            String[] opcionesMarca = { "", "Marcopolo", "Mercedez Bens", "Renault", "Volvo" };
            cb_Marca.Items.AddRange(opcionesMarca);

        }


        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void limpiar()
        {
            this.butacas = new List<Butaca>();

            this.nud_Nro.Value = 1;
            this.nud_CantidadButacas.Value = 1;
            this.nud_CantidadKg.Value = 1;
            this.tb_Modelo.ResetText();
            this.tb_Patente.ResetText();
            this.cb_Marca.Text = "";
            this.cb_TipoServicio.Text = "Ventanilla";
            this.lb_ButacasActuales.Text = this.butacas.Count.ToString();
        }

        private void botonAgregarButaca_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            try
            {
                this.validarButaca();
                Butaca butaca = this.armarButaca();
                this.butacas.Add(butaca);
                this.lb_ButacasActuales.Text = this.butacas.Count.ToString();
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private Butaca armarButaca()
        {
            Butaca butaca = new Butaca();
            butaca.nro = this.butacas.Count();
            butaca.piso = Convert.ToInt32(this.nud_Piso.Value);
            butaca.tipo = this.cb_TipoButaca.Text;

            return butaca;
        }

        private void validarButaca()
        {
            if (this.butacas.Count == this.nud_CantidadButacas.Value)
            {
                throw new SystemException("Ya ha definido las " + this.nud_CantidadButacas.Value + " butaca(s). \nPara agregar una nueva, aumente la cantidad especificada.");
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            MicroDAO microDAO = MicroDAO.getInstance();

            try
            {
                this.validarEntrada();
                Micro micro = this.crearMicro();
                microDAO.guardarNuevoMicro(micro, this.butacas);
                mensaje.mostrarNormal("El micro se ha guardado satisfactoriamente");
                this.limpiar();
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        protected Micro crearMicro()
        {
            Micro micro = new Micro();

            micro.fechaAlta = Aplicacion.getFecha();
            micro.numero = Convert.ToInt32(this.nud_Nro.Value);
            micro.modelo = this.tb_Modelo.Text;
            micro.marca = this.cb_Marca.Text;
            micro.patente = this.tb_Patente.Text;
            micro.cantidadButacas = Convert.ToInt32(nud_CantidadButacas.Value);
            micro.kgDisponibles = Convert.ToInt32(nud_CantidadKg.Value);
            micro.tipoServicio = new TipoServicio();
            micro.tipoServicio.nombre = this.cb_TipoServicio.Text;
            
            return micro;
        }

        protected void validarEntrada()
        {
            Boolean errores = false;
            Regex regexPatente = new Regex(@"^([A-Z]{3})\-([0-9]{3})$");
            Regex reg = new Regex(@"^[a-zA-Z0-9\s]{1,255}$");

            this.errorProviderMarca.Clear();
            this.errorProviderModelo.Clear();
            this.errorProviderNro.Clear();
            this.errorProviderPatente.Clear();
            this.errorProviderTipoServicio.Clear();
            this.errorProviderFechaFueraServicio.Clear();
            this.errorProviderButacas.Clear();


            //Patente
            if(String.IsNullOrEmpty(this.tb_Patente.Text))
            {
                this.errorProviderPatente.SetError(tb_Patente, "Campo obligatorio");
                errores = true;

            } else if (!regexPatente.IsMatch(this.tb_Patente.Text)) {

                this.errorProviderPatente.SetError(tb_Patente, "El formato debe ser AAA-111");
                errores = true;

            }

            //Modelo
            if (String.IsNullOrEmpty(this.tb_Modelo.Text)) {

                this.errorProviderModelo.SetError(tb_Modelo, "Campo obligatorio");
                errores = true;

            } else if (!reg.IsMatch(this.tb_Modelo.Text)) {

                this.errorProviderModelo.SetError(tb_Modelo, "Solo se permiten letras, números y espacios");
                errores = true;

            }

            //Marca
            if (String.IsNullOrEmpty(this.cb_Marca.Text))
            {
                this.errorProviderMarca.SetError(cb_Marca, "Campo obligatorio");
                errores = true;
            }

            //Tipo de servicio
            if (String.IsNullOrEmpty(this.cb_TipoServicio.Text))
            {
                this.errorProviderTipoServicio.SetError(cb_TipoServicio, "Campo obligatorio");
                errores = true;
            }

            //Cantidad de butacas
            if (this.butacas.Count < this.nud_CantidadButacas.Value)
            {
                this.errorProviderButacas.SetError(this.lb_Mensaje, "Faltan " + (this.nud_CantidadButacas.Value - this.butacas.Count) + " butaca(s)");
                errores = true;
            }
            else if (this.butacas.Count > this.nud_CantidadButacas.Value)
            {
                this.errorProviderButacas.SetError(this.lb_Mensaje, "La cantidad de butacas agregadas es mayor a la cantidad de butacas definida. \nPulse limpiar si quiere reiniciar el conteo o aumente la cantidad total de butacas");
                errores = true;
            }
            

            if (errores)
            {
                throw new SystemException("Debe corregir los errores para continuar.");
            }

        }

        private void FormAltaMicro_Load(object sender, EventArgs e)
        {

        }

    }
}
