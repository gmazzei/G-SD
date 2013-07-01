using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Abm_Rol;

namespace FrbaBus.Abm_Permisos
{
    public partial class FormAbmRol : Form
    {
        public FormAbmRol()
        {
            InitializeComponent();
        }

        private void botonAltaRol_Click(object sender, EventArgs e)
        {
            FormAltaRol formAltaRol = new FormAltaRol();
            formAltaRol.Show();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonListado_Click(object sender, EventArgs e)
        {
            FormListadoRol formListadoRol = new FormListadoRol();
            formListadoRol.Show();
        }

        private void botonBajaRol_Click(object sender, EventArgs e)
        {
            FormBajaRol formBajaRol = new FormBajaRol();
            formBajaRol.Show();
        }

        private void botonModificarRol_Click(object sender, EventArgs e)
        {
            FormModificacionRolListado formModificacionRol = new FormModificacionRolListado();
            formModificacionRol.Show();
        }




    }
}
