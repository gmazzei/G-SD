using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.AbmMicros
{
    public partial class FormAbmMicros : Form
    {
        public FormAbmMicros()
        {
            InitializeComponent();
        }

        private void FormAbmMicros_Load(object sender, EventArgs e)
        {

        }



        private void botonAltaMicro_Click(object sender, EventArgs e)
        {
            FormAltaMicro formAltaMicro = new FormAltaMicro();
            formAltaMicro.Show();
        }

        private void botonModificarMicro_Click(object sender, EventArgs e)
        {
            FormModificacionMicroListado formModificacionMicroListado = new FormModificacionMicroListado();
            formModificacionMicroListado.Show();
        }

        private void botonBajaMicro_Click(object sender, EventArgs e)
        {
            FormBajaMicroListado formBajaMicro = new FormBajaMicroListado();
            formBajaMicro.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonListado_Click(object sender, EventArgs e)
        {
            FormListadoMicro formListadoMicro = new FormListadoMicro();
            formListadoMicro.Show();
        }



 
    }
}
