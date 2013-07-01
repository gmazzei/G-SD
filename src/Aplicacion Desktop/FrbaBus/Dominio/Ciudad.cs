using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class Ciudad
    {
        public int ID { get; set; }
        public String nombre { get; set; }

        public override String ToString()
        {
            return this.nombre;
        }
    }
}
