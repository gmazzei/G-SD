using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Abm_Rol
{
    public partial class FormModificacionRolListado : FormListadoRol
    {
        public FormModificacionRolListado()
        {
            InitializeComponent();
            columnModificar.Visible = true;
        }
    }
}
