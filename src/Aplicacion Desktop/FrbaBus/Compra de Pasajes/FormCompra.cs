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

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class FormCompra : Form
    {
        public Viaje viajeSeleccionado;
        public int cantidadPasajes;
        public int cantidadKg;

        public FormCompra()
        {
            InitializeComponent();
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            CiudadDAO ciudadDAO = CiudadDAO.getInstance();
            List<Ciudad> ciudades = ciudadDAO.getCiudades();

            this.cb_CiudadOrigen.Items.AddRange(ciudades.ToArray());
            this.cb_CiudadDestino.Items.AddRange(ciudades.ToArray());
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            ViajeDAO viajeDAO = ViajeDAO.getInstance();

            try
            {
                this.validarEntrada();
                DateTime fechaViaje = this.dtp_FechaViaje.Value;
                Ciudad ciudadOrigen = (Ciudad)this.cb_CiudadOrigen.SelectedItem;
                Ciudad ciudadDestino = (Ciudad)this.cb_CiudadDestino.SelectedItem;

                DataTable tabla = viajeDAO.buscarViajes(fechaViaje, ciudadOrigen, ciudadDestino);
                this.dataGridViajes.DataSource = tabla;
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private void validarEntrada()
        {
            Boolean errores = false;

            this.errorProviderCiudadOrigen.Clear();
            this.errorProviderCiudadDestino.Clear();

            if(String.IsNullOrEmpty(this.cb_CiudadOrigen.Text))
            {
                this.errorProviderCiudadOrigen.SetError(this.cb_CiudadOrigen, "Campo obligatorio");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.cb_CiudadDestino.Text))
            {
                this.errorProviderCiudadDestino.SetError(this.cb_CiudadDestino, "Campo obligatorio");
                errores = true;
            }

            if (errores)
            {
                throw new SystemException("Por favor, debe corregir los campos marcados.");
            }
        }

        private void dataGridViajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;

            if (e.ColumnIndex == dataGridViajes.Columns["Seleccionar"].Index)
            {
                DataGridViewRow fila = dataGridViajes.Rows[e.RowIndex];
                int viajeID = Convert.ToInt32(fila.Cells["ID"].Value);
                int butacasLibres = Convert.ToInt32(fila.Cells["Butacas libres"].Value);
                int kgLibres = Convert.ToInt32(fila.Cells["Kg Libres"].Value);

                this.viajeSeleccionado = new Viaje();
                this.viajeSeleccionado.ID = viajeID;
                this.viajeSeleccionado.butacasLibres = butacasLibres;
                this.viajeSeleccionado.kgLibres = kgLibres;

                this.lb_IDViajeSeleccionado.Text = viajeID.ToString();
                mensaje.mostrarNormal("Viaje seleccionado");
            }
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            this.cantidadPasajes = Convert.ToInt32(this.nud_Pasajes.Value);
            this.cantidadKg = Convert.ToInt32(this.nud_Kg.Value);
            
            try
            {
                this.validarEntradaSiguiente(this.cantidadPasajes, this.cantidadKg);
                new FormCompraPasajeros(this).Show();
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private void validarEntradaSiguiente(int cantidadPasajes, int cantidadKg)
        {
            Boolean errores = false;
            this.errorProviderViaje.Clear();
            this.errorProviderPasajes.Clear();
            this.errorProviderKg.Clear();

            if (cantidadPasajes == 0 && cantidadKg == 0)
            {
                this.errorProviderPasajes.SetError(nud_Pasajes, "Debe especificar una cantidad de pasajes y/o encomiendas (en Kg).");
                errores = true;
            }
            
            if (this.viajeSeleccionado == null) 
            {
                this.errorProviderViaje.SetError(lb_Mensaje, "Debe especificar un viaje");
                errores = true;
            }
            else 
            {
                if (this.viajeSeleccionado.butacasLibres < cantidadPasajes)
                {
                    this.errorProviderPasajes.SetError(nud_Pasajes, "No hay suficientes butacas libres para el viaje seleccionado");
                    errores = true;
                }

                if (this.viajeSeleccionado.kgLibres < cantidadKg)
                {
                    this.errorProviderKg.SetError(nud_Kg, "No hay suficiente espacio en Kg para el viaje seleccionado");
                    errores = true;
                }
            }

            if (errores)
            {
                throw new SystemException("Por favor, debe corregir los errores para continuar.");
            }
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
