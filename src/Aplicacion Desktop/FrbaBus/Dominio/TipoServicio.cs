using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class TipoServicio
    {
        public String nombre {get; set;}
        public double porcentajeAdicional { get; set; }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
