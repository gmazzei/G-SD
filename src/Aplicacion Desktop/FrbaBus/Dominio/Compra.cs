using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class Compra
    {
        public int numero { get; set; }
        public long clienteDNI { get; set; }
        public DateTime fechaCompra { get; set; }
        public String medioPago { get; set; }
    }
}
