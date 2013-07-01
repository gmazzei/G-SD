using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Dominio;
using FrbaBus.Dao;
using FrbaBus.Mensajes;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace FrbaBus.Devoluciones
{
    public partial class FormDevoluciones : Form
    {
        private List<Pasaje> pasajes;
        private List<Encomienda> encomiendas;

        public FormDevoluciones()
        {
            InitializeComponent();
            this.inicializar();
        }

        private void inicializar()
        {
            String[] opciones = { "Pasaje", "Encomienda" };
            this.cb_Tipo.Items.AddRange(opciones);
            this.cb_Tipo.Text = "Pasaje";
            
            this.inicializarListas();
        }

        private void inicializarListas()
        {
            this.pasajes = new List<Pasaje>();
            this.encomiendas = new List<Encomienda>();
        }


        private void botonRealizarDevolucion_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            CompraDAO compraDAO = CompraDAO.getInstance();

            try
            {
                this.validarEntrada(this.tb_CompraNro.Text, this.tb_Motivo.Text);
                compraDAO.realizarDevolucion(Convert.ToInt32(tb_CompraNro.Text), tb_Motivo.Text, this.pasajes, this.encomiendas);
                mensaje.mostrarNormal("La devolucion se ha realizado satisfactoriamente");
                this.limpiar();
            }
            catch (SqlException sqlEx)
            {
                mensaje.mostrarNormal(sqlEx.Errors[0].Message);
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }


        private void FormDevoluciones_Load(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            try
            {
                this.validarNro(tb_Codigo.Text);
                if (this.cb_Tipo.Text.Equals("Pasaje"))
                {
                    Pasaje pasaje = new Pasaje();
                    pasaje.ID = Convert.ToInt32(tb_Codigo.Text);

                    this.pasajes.Add(pasaje);
                    this.lb_CantidadPasajes.Text = this.pasajes.Count.ToString();
                    mensaje.mostrarNormal("Pasaje agregado");
                }
                else
                {
                    Encomienda encomienda = new Encomienda();
                    encomienda.ID = Convert.ToInt32(tb_Codigo.Text);

                    this.encomiendas.Add(encomienda);
                    this.lb_CantidadEncomiendas.Text = this.encomiendas.Count.ToString();
                    mensaje.mostrarNormal("Encomienda agregada");
                }

                tb_Codigo.ResetText();
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
        }

        private void validarNro(String textoNro)
        {
            int result;
            Boolean errores = false;

            this.errorProviderNumero.Clear();

            if (String.IsNullOrEmpty(textoNro))
            {
                this.errorProviderNumero.SetError(this.tb_Codigo, "Debe especificar un nro para agregar un pasaje/encomienda");
                errores = true;
            } 
            else if (!Int32.TryParse(textoNro, out result))
            {
                this.errorProviderNumero.SetError(this.tb_Codigo, "Solo se permiten números");
                errores = true;
            }

            if (errores)
            {
                throw new SystemException("Por favor, corrija los errores para agregar un nuevo pasaje o encomienda.");
            }
        }

        private void validarEntrada(String nroCompra, String motivo)
        {
            long result;
            Boolean errores = false;
            Regex reg = new Regex(@"^[a-zA-Z0-9]{1,200}$");

            this.errorProviderNroCompra.Clear();
            this.errorProviderMotivo.Clear();

            if (String.IsNullOrEmpty(nroCompra))
            {
                this.errorProviderNroCompra.SetError(this.tb_CompraNro, "Campo obligatorio");
                errores = true;
            }
            else if (!Int64.TryParse(nroCompra, out result))
            {
                this.errorProviderNroCompra.SetError(this.tb_CompraNro, "Solo se permiten números");
                errores = true;
            }

            if (String.IsNullOrEmpty(motivo))
            {
                this.errorProviderMotivo.SetError(this.tb_Motivo, "Campo obligatorio");
                errores = true;
            }
            else if (!reg.IsMatch(motivo))
            {
                this.errorProviderMotivo.SetError(this.tb_Motivo, "Solo se permiten letras y números");
                errores = true;
            }


            if (errores)
            {
                throw new SystemException("Por favor, corrija los errores para realizar la devolución.");
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void limpiar()
        {
            this.inicializarListas();
            this.tb_CompraNro.ResetText();
            this.tb_Motivo.ResetText();
            this.tb_Codigo.ResetText();
            this.cb_Tipo.Text = "Pasaje";
            this.lb_CantidadPasajes.Text = this.pasajes.Count.ToString();
            this.lb_CantidadEncomiendas.Text = this.encomiendas.Count.ToString();
        }
    }
}
