using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class Micro
    {
        public String patente { get; set; }
        public int numero { get; set; }
        public String marca { get; set; }
        public String modelo { get; set; }
        public TipoServicio tipoServicio { get; set; }
        public Boolean bajaFueraServicio { get; set; }
        public Boolean bajaVidaUtil { get; set; }
        public int cantidadButacas { get; set; }
        public int kgDisponibles { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaFueraServicio { get; set; }
        public DateTime fechaReinicioServicio { get; set; }
        public DateTime fechaBajaDefinitiva { get; set; }

    }
}
