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
using System.Text.RegularExpressions;

namespace FrbaBus.Consulta_Puntos_Adquiridos
{
    public partial class FormConsultaPuntos : Form
    {
        public FormConsultaPuntos()
        {
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;

            try
            {
                ClienteDAO clienteDAO = ClienteDAO.getInstance();
                this.validarEntrada();
                int puntos = clienteDAO.getPuntos(Convert.ToInt64(tb_DNI.Text));
                lb_CantidadPuntos.Text = puntos.ToString();
                this.dataGridRegistro.DataSource = clienteDAO.getPasajesEncomiendasParaPuntos(Convert.ToInt64(tb_DNI.Text));
                this.dataGridCanjes.DataSource = clienteDAO.getCanjesParaPuntos(Convert.ToInt64(tb_DNI.Text)); 
            }
            catch(Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }

        }

        private void validarEntrada()
        {
            Boolean errores = false;
            Regex regex = new Regex(@"^[0-9]{1,10}$");
            String dni = tb_DNI.Text;

            this.errorProviderDNI.Clear();

            if(String.IsNullOrEmpty(dni))
            {
                errorProviderDNI.SetError(tb_DNI, "Campo obligatorio");
            }
            else if (!regex.IsMatch(dni))
            {
                errorProviderDNI.SetError(tb_DNI, "Solo pueden ser números (máximo 10 dígitos)");
            }

            if (errores)
            {
                throw new SystemException("Debe corregir los errores para ver los puntos.");
            }
        }

        private void FormConsultaPuntos_Load(object sender, EventArgs e)
        {
            //Nada
        }
        

    }
}
