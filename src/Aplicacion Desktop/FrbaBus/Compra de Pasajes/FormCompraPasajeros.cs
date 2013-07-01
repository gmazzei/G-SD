using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaBus.Mensajes;
using FrbaBus.Dominio;
using FrbaBus.Dao;
using FrbaBus.Global;
using System.Text.RegularExpressions;

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class FormCompraPasajeros : Form
    {
        private FormCompra formPrincipal;
        private Butaca butacaSeleccionada;
        public List<Pasaje> pasajes = new List<Pasaje>();
        public List<Encomienda> encomiendas = new List<Encomienda>();
        private Boolean hayDiscapacitado = false;
        private long dniClienteActual;

        public FormCompraPasajeros(FormCompra formCompraPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formCompraPrincipal;
            this.inicializar();
        }


        private void inicializar()
        {
            if (this.formPrincipal.cantidadPasajes != 0)
            {
                this.Text = "Ingreso de datos - Pasaje";
                this.lb_Inicio.Text = "Pasaje " + (this.pasajes.Count + 1);
                this.dataGridButacas.Visible = true;
                this.lb_KgAEnviar.Visible = false;
                this.nud_Kg.Visible = false;
            }
            else if (this.formPrincipal.cantidadKg != 0)
            {
                this.Text = "Ingreso de datos - Encomienda";
                this.lb_Inicio.Text = "Encomienda - Kg disponibles: " + this.formPrincipal.cantidadKg;
                this.lb_KgAEnviar.Visible = true;
                this.nud_Kg.Visible = true;
                this.dataGridButacas.Visible = false;
            }

            this.cargarComponentes();
            this.cargarTablaButacas();
        }

        private void cargarComponentes()
        {
            String[] opcionSiNo = { "Si", "No" };
            String[] opcionGenero = { "M", "F" };
            this.cb_Genero.Items.Clear();
            this.cb_Discapacitado.Items.Clear();
            this.cb_Discapacitado.Items.AddRange(opcionSiNo);
            this.cb_Genero.Items.AddRange(opcionGenero);
        }


        private void cargarTablaButacas()
        {
            ViajeDAO viajeDAO = ViajeDAO.getInstance();
            DataTable butacasLibres = viajeDAO.getButacasLibres(this.formPrincipal.viajeSeleccionado.ID, this.pasajes);
            this.dataGridButacas.DataSource = butacasLibres;
        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;
            try
            {
                
                
                if (this.formPrincipal.cantidadPasajes != 0)
                {
                    this.validarPasaje();
                    this.actualizarCliente();
                    this.guardarPasaje();
                    this.formPrincipal.cantidadPasajes = this.formPrincipal.cantidadPasajes - 1;
                }
                else if (this.formPrincipal.cantidadKg != 0)
                {
                    this.validarEncomienda();
                    this.actualizarCliente();
                    int kg = Convert.ToInt32(this.nud_Kg.Value);
                    this.formPrincipal.cantidadKg = this.formPrincipal.cantidadKg - kg;
                    this.guardarEncomienda();
                }

                this.limpiar();
                this.inicializar();

                if (this.formPrincipal.cantidadPasajes == 0 && this.formPrincipal.cantidadKg == 0)
                {
                    FormCompraComprador formCompraComprador = new FormCompraComprador(this.formPrincipal, this);
                    formCompraComprador.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                mensaje.mostrarNormal(ex.Message);
            }
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
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridButacas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mensaje mensaje = Mensaje.Instance;

            if (e.ColumnIndex == dataGridButacas.Columns["Seleccionar"].Index)
            {
                DataGridViewRow fila = dataGridButacas.Rows[e.RowIndex];
                int nroButaca = Convert.ToInt32(fila.Cells["NRO"].Value);
                this.butacaSeleccionada = new Butaca();
                this.butacaSeleccionada.nro = nroButaca;
                mensaje.mostrarNormal("Butaca seleccionada");
            }
        }

        private void validarPasaje()
        {
            Boolean errores = this.validarCliente();

            if (this.butacaSeleccionada == null)
            {
                this.errorProviderButaca.SetError(dataGridButacas, "Debe seleccionar una butaca");
                errores = true;
            }

            if (errores)
            {
                throw new SystemException("Debe corregir los errores para continuar.");
            }
        }

        private void validarEncomienda()
        {
            Boolean errores = this.validarCliente();

            if (this.nud_Kg.Value == 0)
            {
                this.errorProviderKg.SetError(this.nud_Kg, "Debe seleccionar una cantidad de Kg");
                errores = true;
            } else if (this.nud_Kg.Value > this.formPrincipal.cantidadKg)
            {
                this.errorProviderKg.SetError(this.nud_Kg, "La cantidad es más grande de lo permitido");
                errores = true;
            }

            if (errores)
            {
                throw new SystemException("Debe corregir los errores para continuar.");
            }
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

            if (this.hayDiscapacitado && this.cb_Discapacitado.Text.Equals("Si"))
            {
                this.errorProviderDiscapacitado.SetError(cb_Discapacitado, "No puede haber más de una persona discapacitada por compra.");
            }

            return errores;
        }

        private void guardarPasaje()
        {
            CompraDAO compraDAO = CompraDAO.getInstance();
            Pasaje pasaje = new Pasaje();
            
            pasaje.clienteDNI = Convert.ToInt64(this.tb_DNI.Text);
            pasaje.butacaNRO = this.butacaSeleccionada.nro;
            pasaje.viajeID = this.formPrincipal.viajeSeleccionado.ID;
            //pasaje.precio = compraDAO.calcularPrecioPasaje(this.formPrincipal.viajeSeleccionado.ID);

            if (this.cb_Discapacitado.Text.Equals("Si"))
            {
                this.hayDiscapacitado = true;
            }

            this.pasajes.Add(pasaje);

        }

        private void guardarEncomienda()
        {
            CompraDAO compraDAO = CompraDAO.getInstance();
            Encomienda encomienda = new Encomienda();

            encomienda.clienteDNI = Convert.ToInt64(this.tb_DNI.Text);
            encomienda.Kg = Convert.ToInt32(this.nud_Kg.Value);
            encomienda.viajeID = this.formPrincipal.viajeSeleccionado.ID;
            encomienda.precio = compraDAO.calcularPrecioPasaje(this.formPrincipal.viajeSeleccionado.ID);

            this.encomiendas.Add(encomienda);
        }

        private void tb_DNI_TextChanged(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = ClienteDAO.getInstance();
            long dni = 0;
            long result;

            if (!String.IsNullOrEmpty(tb_DNI.Text) && Int64.TryParse(tb_DNI.Text, out result))
            {
                dni = Convert.ToInt64(tb_DNI.Text);
                Cliente cliente = clienteDAO.getCliente(dni);
                if (cliente != null)
                {
                    this.cargarCliente(cliente);
                }
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

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void FormCompraPasajeros_Load(object sender, EventArgs e)
        {

        }

    }
}
