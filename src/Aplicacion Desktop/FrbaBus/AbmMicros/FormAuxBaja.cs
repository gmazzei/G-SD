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
    public partial class FormAuxBaja : Form
    {
        private FormBajaMicro formBaja;

        public FormAuxBaja(FormBajaMicro formAnterior)
        {
            InitializeComponent();
            this.formBaja = formAnterior;
        }

        private void FormAuxBaja_Load(object sender, EventArgs e)
        {
            //Nada
        }

        private void boton_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            MicroDAO microDAO = MicroDAO.getInstance();

            try
            {
                this.validar();
                Boolean existe = microDAO.existeMicro(this.tb_Patente.Text);

                if (!existe)
                {
                    String patenteNuevoMicro = tb_Patente.Text;
                    String patenteMicroAReemplazar = this.formBaja.patente;

                    microDAO.copiarMicro(patenteMicroAReemplazar, patenteNuevoMicro);

                    this.formBaja.formListado.cargarTablaConTodosLosMicros();

                    this.Close();
                }
                else
                {
                    mensaje.mostrarNormal("La patente elegida ya esta asignada a otro micro.");
                }
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private void validar()
        { 
            Regex regexPatente = new Regex(@"^([A-Z]{3})\-([0-9]{3})$");

            if(String.IsNullOrEmpty(this.tb_Patente.Text))
            {
                throw new SystemException("Debe elegir una patente.");
            } 
            else if (!regexPatente.IsMatch(this.tb_Patente.Text))
            {
                throw new SystemException("La patente debe tener formato AAA-111");
            }
        }

        
    }
}
