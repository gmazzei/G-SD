using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Dao;
using FrbaBus.Dominio;
using FrbaBus.Global;
using FrbaBus.Mensajes;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class FormCompraComprador : Form
    {
        private FormCompra formPrincipal;
        private FormCompraPasajeros formPasajeros;
        private long dniClienteActual;
        

        public FormCompraComprador(FormCompra formCompra, FormCompraPasajeros formCompraPasajeros)
        {
            InitializeComponent();
            this.formPrincipal = formCompra;
            this.formPasajeros = formCompraPasajeros;
            this.cargarComponentes();
        }

        private void FormCompraComprador_Load(object sender, EventArgs e)
        {
            //Nada
        }

        private void cargarComponentes()
        {
            String[] opcionSiNo = { "Si", "No" };
            String[] opcionGenero = { "M", "F" };
            this.cb_Discapacitado.Items.AddRange(opcionSiNo);
            this.cb_Genero.Items.AddRange(opcionGenero);
            this.cargarFormasDePago();
        }

        
        private void cargarFormasDePago()
        {
            Usuario usuario = UsuarioLogueado.usuario;
            String[] opcionesCliente = { "Tarjeta" };
            String[] opcionesAdministrador = { "Tarjeta", "Efectivo" };

            if (usuario != null)
            {
                this.cb_FormaDePago.Items.AddRange(opcionesAdministrador);
            }
            else
            {
                this.cb_FormaDePago.Items.AddRange(opcionesCliente);
            }
            //Inicialmente:
            this.cb_FormaDePago.Text = "Tarjeta";
        }


        private void tb_DNI_TextChanged(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = ClienteDAO.getInstance();
            long dni = 0;

            if (!String.IsNullOrEmpty(tb_DNI.Text))
            {
                dni = Convert.ToInt64(tb_DNI.Text);
            }

            Cliente cliente = clienteDAO.getCliente(dni);
            if (cliente != null)
            {
                this.cargarCliente(cliente);
            }
        }

        private void cargarCliente(Cliente cliente)
        {
            this.dniClienteActual = cliente.dni;
            this.tb_Nombre.Text = cliente.nombre;
            this.tb_Apellido.Text = cliente.apellido;
            this.tb_Direccion.Text = cliente.direccion;
            this.tb_Mail.Text = cliente.mail;
            this.cb_Genero.Text = cliente.genero;
            this.cb_Discapacitado.Text = cliente.esDiscapacitado;
            this.dtp_FechaNacimiento.Value = cliente.fechaNacimiento;
            this.tb_Telefono.Text = cliente.telefono;
        }

        private void cb_FormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_FormaDePago.Text.Equals("Efectivo"))
            {
                this.lb_NumeroTarjetaCredito.Visible = false;
                this.lb_CodigoDeSeguridad.Visible = false;
                this.lb_FechaVencimiento.Visible = false;
                this.lb_MMAA.Visible = false;
                this.lb_TipoTarjeta.Visible = false;
                this.tb_NumeroTarjetaDeCredito.Visible = false;
                this.tb_CodigoDeSeguridad.Visible = false;
                this.tb_FechaDeVencimiento.Visible = false;
                this.tb_TipoTarjeta.Visible = false;
            }
            else
            {
                this.lb_NumeroTarjetaCredito.Visible = true;
                this.lb_CodigoDeSeguridad.Visible = true;
                this.lb_FechaVencimiento.Visible = true;
                this.lb_MMAA.Visible = true;
                this.lb_TipoTarjeta.Visible = true;
                this.tb_NumeroTarjetaDeCredito.Visible = true;
                this.tb_CodigoDeSeguridad.Visible = true;
                this.tb_FechaDeVencimiento.Visible = true;
                this.tb_TipoTarjeta.Visible = true;
            }

        }


        private void validarTarjeta()
        {
            Boolean errores = false;
            Regex reg = new Regex(@"^[a-zA-Z0-9ñáéíóú]{1,30}$");
            Regex regFechaVencimiento = new Regex(@"^((0[1-9])|(1[0-2]))([0-9]{2})$");
            long result;

            this.errorProviderNroTarjeta.Clear();
            this.errorProviderTipoTarjeta.Clear();
            this.errorProviderCodigoSeguridad.Clear();
            this.errorProviderFechaVencimiento.Clear();


            if (String.IsNullOrEmpty(this.tb_NumeroTarjetaDeCredito.Text))
            {
                this.errorProviderNroTarjeta.SetError(tb_NumeroTarjetaDeCredito, "Campo obligatorio");
                errores = true;
            }
            else if (!Int64.TryParse(this.tb_NumeroTarjetaDeCredito.Text, out result))
            {
                this.errorProviderNroTarjeta.SetError(tb_NumeroTarjetaDeCredito, "Solo se permiten números");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.tb_TipoTarjeta.Text))
            {
                this.errorProviderTipoTarjeta.SetError(tb_TipoTarjeta, "Campo obligatorio");
                errores = true;
            } 
            else if (!reg.IsMatch(this.tb_TipoTarjeta.Text))
            {
                this.errorProviderTipoTarjeta.SetError(tb_TipoTarjeta, "Solo se permiten letras y números");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.tb_CodigoDeSeguridad.Text))
            {
                this.errorProviderCodigoSeguridad.SetError(tb_CodigoDeSeguridad, "Campo obligatorio");
                errores = true;
            }
            else if (!reg.IsMatch(this.tb_CodigoDeSeguridad.Text))
            {
                this.errorProviderCodigoSeguridad.SetError(tb_CodigoDeSeguridad, "Solo se permiten letras y números");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.tb_FechaDeVencimiento.Text))
            {
                this.errorProviderFechaVencimiento.SetError(tb_FechaDeVencimiento, "Campo obligatorio");
                errores = true;
            }
            else if (!regFechaVencimiento.IsMatch(this.tb_FechaDeVencimiento.Text))
            {
                this.errorProviderFechaVencimiento.SetError(tb_FechaDeVencimiento, "Formato incorrecto");
                errores = true;
            }

            if (errores)
            {
                throw new SystemException("Debe corregir los errores marcados para continuar.");
            }

        }

        private void botonFinalizar_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            CompraDAO compraDAO = CompraDAO.getInstance();
            String mensajeFinal;
            double total;

            try
            {
                this.validarEntrada();
                this.actualizarCliente();
                Compra compra = this.armarCompra();

                if (this.cb_FormaDePago.Text.Equals("Tarjeta"))
                {
                    this.validarTarjeta();
                    Tarjeta tarjeta = this.armarTarjeta();
                    compraDAO.guardarDatosTarjeta(tarjeta);
                }

                compra.numero = compraDAO.efectuarCompra(compra, this.formPrincipal.viajeSeleccionado.ID, this.formPasajeros.pasajes, this.formPasajeros.encomiendas);
                total = compraDAO.calcularPrecio(compra);

                mensajeFinal = "La compra se ha realizado satisfactoriamente. \nNro de compra/Voucher: "+ compra.numero +" \nTotal a pagar: $" + total;
                mensaje.mostrarNormal(mensajeFinal);
                this.Close();
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


        private void validarEntrada()
        {
            Boolean erroresCliente = this.validarCliente();
            
            if (erroresCliente)
            {
                throw new SystemException("Debe corregir los errores antes de continuar.");
            }
        
        }

        private Compra armarCompra()
        {
            Compra compra = new Compra();
            compra.clienteDNI = Convert.ToInt64(this.tb_DNI.Text);
            compra.medioPago = this.cb_FormaDePago.Text;

            return compra;
        }

        private Tarjeta armarTarjeta()
        {
            Tarjeta tarjeta = new Tarjeta();
            tarjeta.numero = Convert.ToInt64(this.tb_NumeroTarjetaDeCredito.Text);
            tarjeta.tipo = this.tb_TipoTarjeta.Text;
            tarjeta.vencimiento = Convert.ToInt32(this.tb_FechaDeVencimiento.Text);
            tarjeta.codigoSeguridad = this.tb_CodigoDeSeguridad.Text;
            tarjeta.clienteDNI = Convert.ToInt64(this.tb_DNI.Text);
            return tarjeta;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void limpiar()
        {
            this.dniClienteActual = 0;
            this.tb_DNI.Text = "";
            this.tb_Nombre.Text = "";
            this.tb_Apellido.Text = "";
            this.tb_Direccion.Text = "";
            this.tb_Mail.Text = "";
            this.cb_Genero.Text = "";
            this.cb_Discapacitado.Text = "";
            this.dtp_FechaNacimiento.ResetText();
            this.tb_Telefono.Text = "";
            this.tb_NumeroTarjetaDeCredito.Text = "";
            this.tb_CodigoDeSeguridad.Text = "";
            this.tb_FechaDeVencimiento.Text = "";
        }

        private void actualizarCliente()
        {
            ClienteDAO clienteDAO = ClienteDAO.getInstance();
            Cliente cliente = this.armarCliente();
            clienteDAO.actualizarCliente(cliente, this.dniClienteActual);
        }

        private Cliente armarCliente()
        {
            Cliente cliente = new Cliente();
            cliente.dni = Convert.ToInt64(this.tb_DNI.Text);
            cliente.nombre = this.tb_Nombre.Text;
            cliente.apellido = this.tb_Apellido.Text;
            cliente.direccion = this.tb_Direccion.Text;
            cliente.mail = this.tb_Mail.Text;
            cliente.genero = this.cb_Genero.Text;
            cliente.esDiscapacitado = this.cb_Discapacitado.Text;
            cliente.fechaNacimiento = this.dtp_FechaNacimiento.Value;
            cliente.telefono = this.tb_Telefono.Text;

            return cliente;
        }


        private Boolean validarCliente()
        {
            Boolean errores = false;
            Regex reg = new Regex(@"^[a-zA-Z0-9ñáéíóú]{1,30}$");
            Regex regApellido = new Regex(@"^[A-ZÑÁÉÍÓÚ\s]{1}[a-zñáéíóú]{1,30}$");
            Regex regNombre = new Regex(@"^[A-ZÑÁÉÍÓÚ\s]{1,30}$");
            Regex regDir = new Regex(@"^[a-zA-Zñáéíóú\s]+([0-9]){1,6}$");
            Regex regMail = new Regex(@"^[a-zA-Z0-9._ñáéíóú]+@[a-zA-Z0-9._-ñáéíóú]+\.[a-zA-Zñáéíóú]{2,4}$");
            long result;

            this.errorProviderDNI.Clear();
            this.errorProviderApellido.Clear();
            this.errorProviderNombre.Clear();
            this.errorProviderTelefono.Clear();
            this.errorProviderMail.Clear();
            this.errorProviderDireccion.Clear();
            this.errorProviderGenero.Clear();
            this.errorProviderDiscapacitado.Clear();

            if (String.IsNullOrEmpty(this.tb_DNI.Text))
            {
                this.errorProviderDNI.SetError(this.tb_DNI, "Campo obligatorio");
                errores = true;
            }
            else if (!Int64.TryParse(tb_DNI.Text, out result))
            {
                this.errorProviderDNI.SetError(this.tb_DNI, "Solo se permiten números");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.tb_Apellido.Text))
            {
                this.errorProviderApellido.SetError(this.tb_Apellido, "Campo obligatorio");
                errores = true;
            }
            else if (!regApellido.IsMatch(tb_Apellido.Text))
            {
                this.errorProviderApellido.SetError(this.tb_Apellido, "Debe ser la primer letra mayúscula y las demás en minúscula");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.tb_Nombre.Text))
            {
                this.errorProviderNombre.SetError(this.tb_Nombre, "Campo obligatorio");
                errores = true;
            }
            else if (!regNombre.IsMatch(tb_Nombre.Text))
            {
                this.errorProviderNombre.SetError(this.tb_Nombre, "Deben ser todas letras mayúsculas");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.tb_Telefono.Text))
            {
                this.errorProviderTelefono.SetError(this.tb_Telefono, "Campo obligatorio");
                errores = true;
            }
            else if (!Int64.TryParse(tb_Telefono.Text, out result))
            {
                this.errorProviderTelefono.SetError(this.tb_Telefono, "Deben ser solo números");
                errores = true;
            }

            if (String.IsNullOrEmpty(this.tb_Direccion.Text))
            {
                this.errorProviderDireccion.SetError(this.tb_Direccion, "Campo obligatorio");
                errores = true;
            }
            else if (!regDir.IsMatch(tb_Direccion.Text))
            {
                this.errorProviderDireccion.SetError(this.tb_Direccion, "Formato incorrecto");
                errores = true;
            }


            if (!regMail.IsMatch(tb_Mail.Text) && !String.IsNullOrEmpty(tb_Mail.Text))
            {
                this.errorProviderMail.SetError(this.tb_Mail, "Formato incorrecto");
                errores = true;
            }

            if (String.IsNullOrEmpty(cb_Genero.Text))
            {
                this.errorProviderGenero.SetError(this.cb_Genero, "Campo obligatorio");
                errores = true;
            }

            if (String.IsNullOrEmpty(cb_Discapacitado.Text))
            {
                this.errorProviderDiscapacitado.SetError(this.cb_Discapacitado, "Campo obligatorio");
                errores = true;
            }

            return errores;
        }
    }
}
