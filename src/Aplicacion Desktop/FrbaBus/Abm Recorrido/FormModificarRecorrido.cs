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
using System.Globalization;

namespace FrbaBus.Abm_Recorrido
{
    public partial class FormModificarRecorrido : FormAltaRecorrido
    {

        private Recorrido recorrido;
        private long codigoAnterior;
        private FormListadoRecorrido formListado;

        public FormModificarRecorrido(long idRecorrido, FormListadoRecorrido formListadoRecorrido)
        {
            InitializeComponent();
            this.codigoAnterior = idRecorrido;
            this.formListado = formListadoRecorrido;
            this.recorrido = RecorridoDAO.getInstance().getRecorrido(idRecorrido);
            this.completarValores();
        }

        private void completarValores()
        {
            tb_Codigo.Text = this.recorrido.codigo.ToString();
            tb_PrecioPasaje.Text = this.recorrido.precioPasaje.ToString();
            tb_PrecioKg.Text = this.recorrido.precioKg.ToString();

            tb_CiudadOrigen.Text = this.recorrido.ciudadOrigen.ToString();
            tb_CiudadDestino.Text = this.recorrido.ciudadDestino.ToString();
            cb_TipoServicio.Text = this.recorrido.tipoServicio.nombre;

            cb_Habilitado.Text = this.recorrido.habilitado ? "Si" : "No";

        }

        protected override void guardar(Recorrido recorrido)
        {
            RecorridoDAO recorridoDAO = RecorridoDAO.getInstance();

            recorridoDAO.modificarRecorrido(recorrido, codigoAnterior);

            formListado.cargarTabla();
        }

        protected override void finalizar()
        {
            this.Close();
        }

    }
}
