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
using System.Data.SqlClient;
using FrbaBus.Global;

namespace FrbaBus.Registrar_LLegada_Micro
{
    public partial class FormRegistroLlegada : Form
    {
        public FormRegistroLlegada()
        {
            InitializeComponent();
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            MicroDAO microDAO = MicroDAO.getInstance();
            List<String> patentes = microDAO.getPatentesHabilitadas();
            cb_Patente.Items.AddRange(patentes.ToArray());

            CiudadDAO ciudadDAO = CiudadDAO.getInstance();
            List<Ciudad> ciudades = ciudadDAO.getCiudades();

            cb_CiudadOrigen.Items.AddRange(ciudades.ToArray());
            cb_CiudadDestino.Items.AddRange(ciudades.ToArray());

            dtp_Fecha.Value = Aplicacion.getFecha();
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
                microDAO.registrarLlegada(cb_Patente.Text, dtp_Fecha.Value, (Ciudad)cb_CiudadOrigen.SelectedItem, (Ciudad)cb_CiudadDestino.SelectedItem);
                mensaje.mostrarNormal("Registro generado satisfactoriamente.");
                this.Close();
            }
            catch (SqlException sqlEx)
            {
                mensaje.mostrarNormal(sqlEx.Errors[0].Message);
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }


        public void validarEntrada()
        {
            Boolean errores = false;

            this.errorProviderPatente.Clear();
            this.errorProviderCiudadOrigen.Clear();
            this.errorProviderCiudadDestino.Clear();
            

            if (String.IsNullOrEmpty(cb_Patente.Text))
            {
                this.errorProviderPatente.SetError(cb_Patente, "Campo obligatorio");
                errores = true;    
            }
            if (String.IsNullOrEmpty(cb_CiudadOrigen.Text))
            {
                this.errorProviderCiudadOrigen.SetError(cb_CiudadOrigen, "Campo obligatorio");
                errores = true;
            }
            if (String.IsNullOrEmpty(cb_CiudadDestino.Text))
            {
                this.errorProviderCiudadDestino.SetError(cb_CiudadDestino, "Campo obligatorio");
                errores = true;
            }

            if (errores)
            {
                throw new SystemException("Por favor, complete todos los valores antes de continuar.");
            }

        }

        private void FormRegistroLlegada_Load(object sender, EventArgs e)
        {
            //Nada
        }
        
    }
}
