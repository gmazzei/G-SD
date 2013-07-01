using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Compra_de_Pasajes
{
    public class Tarjeta
    {
        public long numero { get; set; }
        public String codigoSeguridad { get; set; }
        public int vencimiento { get; set; }
        public String tipo { get; set; }
        public long clienteDNI { get; set; }

    }
}
