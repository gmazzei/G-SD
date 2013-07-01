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
using System.Data.SqlClient;

namespace FrbaBus.Canje_de_Ptos
{
    public partial class FormCanjePuntos : Form
    {
        public FormCanjePuntos()
        {
            InitializeComponent();
            this.inicializar();
        }

        private void botonCanjear_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;

            try
            {
                this.validarEntrada();
                long DNI = (long)Convert.ToDouble(tb_DNI.Text);
                Producto producto = (Producto) cb_Producto.SelectedItem;
                int cantidad = (int)nud_Cantidad.Value;
                ProductoDAO.getInstance().realizarCanje(DNI, producto.ID, cantidad);
                mensaje.mostrarNormal("Canje realizado satisfactoriamente.");
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

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void limpiar()
        {
            tb_DNI.ResetText();
            cb_Producto.Text = "";
            nud_Cantidad.Value = 1;
        }


        private void inicializar()
        {
            List<Producto> productos = ProductoDAO.getInstance().getProductos();
            cb_Producto.Items.Add("");
            cb_Producto.Items.AddRange(productos.ToArray());
        }

        private void FormCanjePuntos_Load(object sender, EventArgs e)
        {
            
        }

        private void validarEntrada()
        {
            Boolean errores = false;
            long result;

            this.errorProviderDNI.Clear();
            this.errorProviderProducto.Clear();

            if(String.IsNullOrEmpty(this.tb_DNI.Text))
            {
                this.errorProviderDNI.SetError(this.tb_DNI, "Campo obligatorio");
                errores = true;
            } else if (!Int64.TryParse(this.tb_DNI.Text, out result))
            {
                this.errorProviderDNI.SetError(this.tb_DNI, "Solo pueden ingresarse números");
                errores = true;
            }
            
            if(String.IsNullOrEmpty(cb_Producto.Text))
            {
                this.errorProviderProducto.SetError(this.cb_Producto, "Debe elegir un producto");
                errores = true;
            }

            if(errores)
            {
                throw new SystemException("Por favor, corrija los errores marcados.");
            }
        }
    }
}
