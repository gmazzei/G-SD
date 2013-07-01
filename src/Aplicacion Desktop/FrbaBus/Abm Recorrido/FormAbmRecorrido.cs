using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Abm_Recorrido
{
    public partial class FormAbmRecorrido : Form
    {
        public FormAbmRecorrido()
        {
            InitializeComponent();
        }

        private void FormAbmRecorrido_Load(object sender, EventArgs e)
        {

        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            FormAltaRecorrido formAltaRecorrido = new FormAltaRecorrido();
            formAltaRecorrido.Show();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            FormModificacionRecorridoListado formModificarRecorrido = new FormModificacionRecorridoListado();
            formModificarRecorrido.Show();
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            FormBajaRecorrido formBajaRecorrido = new FormBajaRecorrido();
            formBajaRecorrido.Show();
        }

        private void botonListado_Click(object sender, EventArgs e)
        {
            FormListadoRecorrido formListadoRecorrido = new FormListadoRecorrido();
            formListadoRecorrido.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
