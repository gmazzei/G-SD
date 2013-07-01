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
using FrbaBus.Global;

namespace FrbaBus.AbmMicros
{
    public partial class FormBajaMicro : Form
    {
        public String patente;
        public String patenteAux;
        public FormListadoMicro formListado;

        public FormBajaMicro(String patente, FormListadoMicro form)
        {
            InitializeComponent();
            this.patente = patente;
            this.formListado = form;
            this.cargarComponentes();
        }

        private void cargarComponentes()
        {
            DateTime fechaHoy = Aplicacion.getFecha();

            this.dtp_FechaBajaDefinitiva.Value = fechaHoy;
            this.dtp_FechaFueraServicio.Value = fechaHoy;
            this.dtp_FechaReinicioServicio.Value = fechaHoy;
        }

        private void botonBajaFueraServicio_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            MicroDAO microDAO = MicroDAO.getInstance();
            try
            {
                DateTime fechaFuera = dtp_FechaFueraServicio.Value;
                DateTime fechaReinicio = dtp_FechaReinicioServicio.Value;

                this.validarFechasFueraServicio(fechaFuera, fechaReinicio);

                
                DialogResult respuesta = mensaje.mostrarPreguntaSiNo("¿Desea reemplazar el micro? Si no lo hace los pasajes y las encomiendas serán cancelados");

                if (respuesta.ToString().Equals("Yes"))
                {
                    String patenteReemplazo = microDAO.hayMicroDeReemplazo(this.patente, fechaFuera, fechaReinicio);
                    if (patenteReemplazo != null)
                    {
                        microDAO.reemplazarMicro(patente, patenteReemplazo, fechaFuera, fechaReinicio);
                    }
                    else
                    {
                        new FormAuxBaja(this).Show();
                        
                    }

                    microDAO.bajaFueraServicio(patente, fechaFuera, fechaReinicio);
                }
                else
                {
                    microDAO.cancelarMicro(this.patente, fechaFuera, fechaReinicio);
                }

                mensaje.mostrarNormal("El micro fue dado de baja satisfactoriamente");
                this.formListado.cargarTablaConTodosLosMicros();
                this.Close();
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
            
        }

        private void validarFechasFueraServicio(DateTime inicio, DateTime fin)
        {
            if(inicio >= fin)
            {
                throw new SystemException("La fecha de inicio tiene que ser anterior a la fecha de reinicio.");
            }
        }

        private void botonBajaVidaUtil_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            MicroDAO microDAO = MicroDAO.getInstance();
            try
            {
                DateTime fechaBajaVidaUtil = dtp_FechaBajaDefinitiva.Value;
                
                
               
                DialogResult respuesta = mensaje.mostrarPreguntaSiNo("¿Desea reemplazar el micro? Si no lo hace los pasajes y las encomiendas serán cancelados");

                if (respuesta.ToString().Equals("Yes"))
                {
                    String patenteReemplazo = microDAO.hayMicroDeReemplazo(this.patente, fechaBajaVidaUtil);
                    if (patenteReemplazo != null)
                    {
                        microDAO.reemplazarMicro(patente, patenteReemplazo, fechaBajaVidaUtil);
                    }
                    else
                    {
                        new FormAuxBaja(this).Show();
                    }

                    microDAO.bajaVidaUtil(patente, fechaBajaVidaUtil);
                }
                else 
                { 
                    microDAO.cancelarMicro(this.patente, fechaBajaVidaUtil);
                }

                
                mensaje.mostrarNormal("El micro fue dado de baja satisfactoriamente");
                this.Close();
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
            
        }


        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBajaMicro_Load(object sender, EventArgs e)
        {
            //Nada
        }
    }
}
