using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class Cliente
    {
        public long dni { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String mail { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String genero { get; set; }
        public String esDiscapacitado { get; set; }
    }
}
