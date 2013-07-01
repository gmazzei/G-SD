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

namespace FrbaBus.AbmMicros
{
    public partial class FormModifMicro : Form
    {

        private String patente;
        private FormListadoMicro formListado;

        public FormModifMicro(String patente, FormListadoMicro formListado)
        {
            InitializeComponent();
            this.patente = patente;
            this.formListado = formListado;
            this.cargarComponentes();
            MicroDAO microDAO = MicroDAO.getInstance();
            this.cargarDatos(microDAO.getMicro(patente));
        }

        private void cargarDatos(Micro micro)
        {
            this.tb_Patente.Text = micro.patente;
            this.tb_Modelo.Text = micro.modelo;
            this.cb_Marca.Text = micro.marca;
            this.cb_TipoServicio.Text = micro.tipoServicio.nombre;
            this.nud_Nro.Value = micro.numero;
            this.cb_FueraServicio.Text = micro.bajaFueraServicio ? "Si" : "No";
            this.cb_BajaVidaUtil.Text = micro.bajaVidaUtil ? "Si" : "No";
        }


        private void FormModifMicro_Load(object sender, EventArgs e)
        {
            //Nada
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            MicroDAO microDAO = MicroDAO.getInstance();

            try
            {
                this.validarEntrada();
                Micro micro = this.crearMicro();
                microDAO.modificarMicro(micro, this.patente);
                mensaje.mostrarNormal("El micro se ha guardado satisfactoriamente");
                this.formListado.cargarTablaConTodosLosMicros();
                this.Close();
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private Micro crearMicro()
        {
            Micro micro = new Micro();

            micro.numero = Convert.ToInt32(this.nud_Nro.Value);
            micro.modelo = this.tb_Modelo.Text;
            micro.marca = this.cb_Marca.Text;
            micro.patente = this.tb_Patente.Text;
            micro.tipoServicio = new TipoServicio();
            micro.tipoServicio.nombre = cb_TipoServicio.Text;
            micro.bajaVidaUtil = cb_BajaVidaUtil.Text.Equals("Si");
            micro.bajaFueraServicio = cb_FueraServicio.Text.Equals("Si");

            return micro;
        }

        private void validarEntrada()
        {
            Boolean errores = false;
            Regex regexPatente = new Regex(@"^([A-Z]{3})\-([0-9]{3})$");
            Regex reg = new Regex(@"^[a-zA-Z0-9\s]{1,255}$");

            this.errorProviderMarca.Clear();
            this.errorProviderModelo.Clear();
            this.errorProviderNro.Clear();
            this.errorProviderPatente.Clear();
            this.errorProviderTipoServicio.Clear();

            if (String.IsNullOrEmpty(this.tb_Patente.Text))
            {
                this.errorProviderPatente.SetError(tb_Patente, "Campo obligatorio");
                errores = true;
            }
            else if (!regexPatente.IsMatch(this.tb_Patente.Text))
            {
                this.errorProviderPatente.SetError(tb_Patente, "El formato debe ser AAA-111");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.tb_Modelo.Text))
            {
                this.errorProviderModelo.SetError(tb_Modelo, "Campo obligatorio");
                errores = true;
            }
            else if (!reg.IsMatch(this.tb_Modelo.Text))
            {
                this.errorProviderModelo.SetError(tb_Modelo, "Solo se permiten letras, números y espacios.");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.cb_Marca.Text))
            {
                this.errorProviderMarca.SetError(cb_Marca, "Campo obligatorio");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.cb_TipoServicio.Text))
            {
                this.errorProviderTipoServicio.SetError(cb_TipoServicio, "Campo obligatorio");
                errores = true;
            }


            if (errores)
            {
                throw new SystemException("Debe corregir los errores para continuar.");
            }

        }

        private void cargarComponentes()
        {
            ServicioDAO servicioDAO = ServicioDAO.getInstance();
            List<TipoServicio> servicios = servicioDAO.getServicios();
            this.cb_TipoServicio.Items.AddRange(servicios.ToArray());
        
            String[] opcionesMarca = { "Marcopolo", "Mercedez Bens", "Renault", "Volvo" };
            cb_Marca.Items.AddRange(opcionesMarca);

            String[] opcionSiNo = { "Si", "No" };
            cb_BajaVidaUtil.Items.AddRange(opcionSiNo);
            cb_FueraServicio.Items.AddRange(opcionSiNo);
        }
    }
}
