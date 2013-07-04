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
using System.Data.SqlClient;

namespace FrbaBus.Abm_Recorrido
{
    public partial class FormAltaRecorrido : Form
    {
        public FormAltaRecorrido()
        {
            InitializeComponent();
            this.cargarDatos();
        }

        private void FormAltaRecorrido_Load(object sender, EventArgs e)
        {
            //Nada
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        protected void limpiar()
        {
            this.tb_Codigo.ResetText();
            this.tb_PrecioKg.ResetText();
            this.tb_PrecioPasaje.ResetText();
            this.tb_CiudadOrigen.ResetText();
            this.tb_CiudadDestino.ResetText();

            this.cb_TipoServicio.Text = "";
            this.cb_Habilitado.Text = "Si";
        }

        protected void cargarDatos()
        {   
            List<TipoServicio> servicios = ServicioDAO.getInstance().getServicios();
            this.cb_TipoServicio.Items.Add("");
            this.cb_TipoServicio.Items.AddRange(servicios.ToArray());
            
            String[] opcionSiNo = { "Si", "No" };
            cb_Habilitado.Items.AddRange(opcionSiNo);
            cb_Habilitado.Text = "Si";
        }

        public void botonGuardar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;

            try
            {
                this.validarEntrada();
                Recorrido recorrido = this.armarRecorrido();
                this.guardar(recorrido);
                mensaje.mostrarNormal("El Recorrido se ha guardado satisfactoriamente.");
                this.finalizar();
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        protected virtual void finalizar()
        {
            this.limpiar();
        }


        protected virtual void guardar(Recorrido recorrido) 
        {
            RecorridoDAO recorridoDAO = RecorridoDAO.getInstance();
            recorridoDAO.guardarNuevo(recorrido);
        }

        public Recorrido armarRecorrido() 
        {
            CiudadDAO ciudadDAO = CiudadDAO.getInstance();
            Recorrido recorrido = new Recorrido();

            recorrido.codigo = Convert.ToInt32(tb_Codigo.Text);
            recorrido.tipoServicio = (TipoServicio)cb_TipoServicio.SelectedItem;
            recorrido.ciudadOrigen = ciudadDAO.getCiudad(tb_CiudadOrigen.Text);
            recorrido.ciudadDestino = ciudadDAO.getCiudad(tb_CiudadDestino.Text);
            recorrido.precioPasaje = Convert.ToDouble(tb_PrecioPasaje.Text.Replace('.', ','));
            recorrido.precioKg = Convert.ToDouble(tb_PrecioKg.Text.Replace('.', ','));
            recorrido.habilitado = cb_Habilitado.Text.Equals("Si");

            return recorrido;
        }


        public void validarEntrada()
        {
            long lresult;
            double dresult;
            Boolean errores = false;


            this.errorProviderCodigo.Clear();
            this.errorProviderDestino.Clear();
            this.errorProviderCiudades.Clear();
            this.errorProviderHabilitado.Clear();
            this.errorProviderKg.Clear();
            this.errorProviderOrigen.Clear();
            this.errorProviderPasaje.Clear();
            this.errorProviderServicio.Clear();
            
            //Codigo
            if (String.IsNullOrEmpty(tb_Codigo.Text))
            {
                errorProviderCodigo.SetError(tb_Codigo, "Campo requerido");
                errores = true;
            }
            else if (!long.TryParse(tb_Codigo.Text, out lresult))
            {
                errorProviderCodigo.SetError(tb_Codigo, "El valor debe ser un número");
                errores = true;
            }

            //Precio pasaje
            if (String.IsNullOrEmpty(tb_PrecioPasaje.Text))
            {
                errorProviderPasaje.SetError(tb_PrecioPasaje, "Campo requerido");
                errores = true;
            }
            else if (!double.TryParse(tb_PrecioPasaje.Text, out dresult))
            {
                errorProviderPasaje.SetError(tb_PrecioPasaje, "El valor debe ser un numero");
                errores = true;
            }

            //Precio Kg
            if (String.IsNullOrEmpty(tb_PrecioKg.Text))
            {
                errorProviderKg.SetError(tb_PrecioKg, "Campo requerido");
                errores = true;
            }
            else if (!double.TryParse(tb_PrecioKg.Text, out dresult))
            {
                errorProviderKg.SetError(tb_PrecioKg, "El valor debe ser un número");
                errores = true;
            }

            //Tipo de servicio
            if (String.IsNullOrEmpty(cb_TipoServicio.Text))
            {
                errorProviderServicio.SetError(cb_TipoServicio, "Campo requerido");
                errores = true;
            }

            //Ciudad origen
            if (String.IsNullOrEmpty(tb_CiudadOrigen.Text))
            {
                errorProviderOrigen.SetError(tb_CiudadOrigen, "Campo requerido");
                errores = true;
            }

            //Ciudad destino
            if (String.IsNullOrEmpty(tb_CiudadDestino.Text))
            {
                errorProviderDestino.SetError(tb_CiudadDestino, "Campo requerido");
                errores = true;
            }

            if ((!String.IsNullOrEmpty(tb_CiudadOrigen.Text)) && (!String.IsNullOrEmpty(tb_CiudadDestino.Text)) && tb_CiudadOrigen.Text.Equals(tb_CiudadDestino.Text))
            {
                errorProviderCiudades.SetError(tb_CiudadOrigen, "No se puede ingresar la misma ciudad para el origen y el destino");
                errores = true;
            }

            if (errores)
            {
                throw new SystemException("Debe corregir los errores marcados para guardar el nuevo recorrido.");
            }
        }

        private void botonCiudadOrigen_Click(object sender, EventArgs e)
        {
            new FormBusquedaCiudades(this.tb_CiudadOrigen).Show();
        }

        private void botonCiudadDestino_Click(object sender, EventArgs e)
        {
            new FormBusquedaCiudades(this.tb_CiudadDestino).Show();
        }

    }
}
