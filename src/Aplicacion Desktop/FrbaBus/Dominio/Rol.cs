using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaBus.Dominio
{
    public class Rol
    {
        public int ID { get; set; }
        public String nombre { get; set; }
        public Boolean habilitado { get; set; }

        public List<Funcionalidad> funcionalidades;
    }
}
