using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace FrbaBus.Global
{
    class Aplicacion
    {
        private Aplicacion()
        { }

        private static int cantidadIntentosLogin = 0;

        public static DateTime getFecha()
        {

            String strFecha = ConfigurationManager.AppSettings["fechaSistema"].ToString();
            DateTime fecha = DateTime.ParseExact(strFecha, "dd/MM/yyyy HH:mm:ss", null);

            return fecha;
        }
        
        public static void aumentarIntentosFallidos()
        {
            cantidadIntentosLogin++;
        }

        public static int getIntentosFallidos()
        {
            return cantidadIntentosLogin;
        }

        public static void resetearIntentosFallidos()
        {
            cantidadIntentosLogin = 0;
        }
    }
}
