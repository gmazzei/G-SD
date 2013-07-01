using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class Recorrido
    {
        public long codigo {get; set;}
        
        public double precioPasaje {get; set;}
        public double precioKg {get; set;}
        public Boolean habilitado {get; set;}
        
        public Ciudad ciudadOrigen {get; set;}
        public Ciudad ciudadDestino {get; set;}

        public TipoServicio tipoServicio { get; set; }

        public override string ToString()
        {
            return "" + this.codigo;
        }
        
    }
}
