using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class Usuario
    {
        public String username { get; set; }
        public String password { get; set; }
        public Boolean habilitado { get; set; }
        public int intentosFallidos { get; set; }
        public Rol rol { get; set; }
    }
}
