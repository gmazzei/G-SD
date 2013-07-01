using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class Producto
    {
        public int ID { get; set; }
        public String nombre { get; set; }
        public int puntosNecesarios { get; set; }
        public int stock { get; set; }

        public override string ToString()
        {
            return this.nombre + " ("+ this.puntosNecesarios +" puntos)";
        }
    }
}
