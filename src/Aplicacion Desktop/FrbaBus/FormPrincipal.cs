using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Login;
using FrbaBus.Compra_de_Pasajes;
using FrbaBus.Consulta_Puntos_Adquiridos;
using FrbaBus.Canje_de_Ptos;
using FrbaBus.Listados_Estadisticos;
using FrbaBus.GenerarViaje;
using FrbaBus.Abm_Permisos;
using FrbaBus.Abm_Recorrido;
using FrbaBus.Registrar_LLegada_Micro;
using FrbaBus.AbmMicros;
using FrbaBus.Devoluciones;

namespace FrbaBus
{
    public partial class FormPrincipal : Form
    {   

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioBasico_Load(object sender, EventArgs e)
        {

        }

        private void botonLogin_click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.Show();
        }


        private void botonCompra_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra();
            formCompra.Show();
        }

        private void botonConsultaPuntos_Click(object sender, EventArgs e)
        {
            FormConsultaPuntos formConsultaPuntos = new FormConsultaPuntos();
            formConsultaPuntos.Show();
        }

        private void botonDevolucion_Click(object sender, EventArgs e)
        {
            FormDevoluciones formDevoluciones = new FormDevoluciones();
            formDevoluciones.Show();
        }

        private void botonCanjePuntos_Click(object sender, EventArgs e)
        {
            FormCanjePuntos formCanjePuntos = new FormCanjePuntos();
            formCanjePuntos.Show();
        }

        private void botonListados_Click(object sender, EventArgs e)
        {
            FormListadosEstadisticos formListadosEstadisticos = new FormListadosEstadisticos();
            formListadosEstadisticos.Show();
        }

        private void botonGenerarViaje_Click(object sender, EventArgs e)
        {
            FormGenerarViaje formGenerarViaje = new FormGenerarViaje();
            formGenerarViaje.Show();
        }

        private void botonABMRol_Click(object sender, EventArgs e)
        {
            FormAbmRol formAbmRol = new FormAbmRol();
            formAbmRol.Show();
        }

        private void botonABMMicro_Click(object sender, EventArgs e)
        {
            FormAbmMicros formAbmMicros = new FormAbmMicros();
            formAbmMicros.Show();
        }

        private void botonABMRecorrido_Click(object sender, EventArgs e)
        {
            FormAbmRecorrido formAbmRecorrido = new FormAbmRecorrido();
            formAbmRecorrido.Show();
        }

        private void botonRegistroLlegada_Click(object sender, EventArgs e)
        {
            FormRegistroLlegada formRegistroLlegada = new FormRegistroLlegada();
            formRegistroLlegada.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        public void inhabilitarLogin()
        {
            this.botonLogin.Visible = false;
        }



    }
}
