using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class Viaje
    {
        public int ID { get; set; }
        public int recorridoID { get; set; }
        public String microPatente { get; set; }
        public DateTime fechaSalida { get; set; }
        public DateTime fechaLlegadaEstimada { get; set; }
        public DateTime fechaLlegada { get; set; }
        public String estado { get; set; }

        //Agregados
        public int butacasLibres { get; set; }
        public int kgLibres { get; set; }

    }
}
