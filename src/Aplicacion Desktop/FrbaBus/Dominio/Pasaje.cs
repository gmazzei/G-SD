using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class Pasaje
    {
        public int ID { get; set; }
        public int viajeID { get; set; }
        public long clienteDNI { get; set; }
        public double precio { get; set; }
        public int compraNRO { get; set; }
        public int butacaNRO { get; set; }

    }
}
