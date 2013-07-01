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
    public partial class FormModificacionMicroListado : FormListadoMicro
    {
        public FormModificacionMicroListado()
        {
            InitializeComponent();
            this.columnModificar.Visible = true;
        }

        private void FormModificacionMicroListado_Load(object sender, EventArgs e)
        {

        }
    }
}
