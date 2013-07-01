using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class Funcionalidad
    {
        public int ID { get; set; }
        public String nombre { get; set; }

        public override string ToString() {
            return this.nombre;
        }
    }
}
