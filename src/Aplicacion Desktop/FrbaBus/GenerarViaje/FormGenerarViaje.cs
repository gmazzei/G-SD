using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Mensajes;
using FrbaBus.Dominio;
using FrbaBus.Dao;
using System.Data.SqlClient;

namespace FrbaBus.GenerarViaje
{
    public partial class FormGenerarViaje : Form
    {
        public FormGenerarViaje()
        {
            InitializeComponent();
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            MicroDAO microDAO = MicroDAO.getInstance();
            List<String> patentesHabilitadas = microDAO.getPatentesHabilitadas();

            cb_PatenteMicro.Items.AddRange(patentesHabilitadas.ToArray());

            RecorridoDAO recorridoDAO = RecorridoDAO.getInstance();
            List<Recorrido> recorridosHabilitados = recorridoDAO.getRecorridosHabilitados();

            cb_RecorridoCodigo.Items.AddRange(recorridosHabilitados.ToArray());
        }

        private void FormGenerarViaje_Load(object sender, EventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            ViajeDAO viajeDAO = ViajeDAO.getInstance();

            try
            {
                this.validarEntrada();
                Viaje viaje = this.armarViaje();
                viajeDAO.guardar(viaje);
                mensaje.mostrarNormal("El Viaje se ha generado satisfactoriamente.");
                this.Close();
            }
            catch (SqlException sqlEx)
            {
                mensaje.mostrarNormal(sqlEx.Errors[0].Message);
            }
            catch(Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
            
        }

        private void validarEntrada()
        { 
            Boolean errores = false;

            errorProviderCodigoRecorrido.Clear();
            errorProviderMicroPatente.Clear();

            if (String.IsNullOrEmpty(cb_PatenteMicro.Text))
            {
                errorProviderCodigoRecorrido.SetError(cb_RecorridoCodigo, "Campo obligatorio");
                errores = true;
            }
            if (String.IsNullOrEmpty(cb_RecorridoCodigo.Text))
            {
                errorProviderMicroPatente.SetError(cb_PatenteMicro, "Campo obligatorio");
                errores = true;
            }


            if (dtp_FechaSalida.Value < DateTime.Now.AddMinutes(-1))
            {
                throw new SystemException("La fecha de salida debe ser posterior a la fecha actual.");            
            }

            if (dtp_FechaSalida.Value >= dtp_FechaLlegadaEstimada.Value)
            {
                throw new SystemException("La fecha de salida no puede ser posterior o igual a la fecha de llegada estimada.");
            }

            if (errores)
            {
                throw new SystemException("Por favor, complete todos los campos antes de continuar.");
            }

        }

        private Viaje armarViaje()
        {
            Viaje viaje = new Viaje();

            viaje.recorridoID = Convert.ToInt32(cb_RecorridoCodigo.Text);
            viaje.microPatente = cb_PatenteMicro.Text;
            viaje.fechaSalida = dtp_FechaSalida.Value;
            viaje.fechaLlegadaEstimada = dtp_FechaLlegadaEstimada.Value;
            viaje.estado = "Vigente";

            return viaje;
        }

    }
}
