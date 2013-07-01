using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.Dominio;
using System.Data.SqlClient;

namespace FrbaBus.Dao
{
    class ServicioDAO
    {
        private static ServicioDAO INSTANCIA;

        private ServicioDAO() { 
        }

        //Singleton
        public static ServicioDAO getInstance()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new ServicioDAO();
            }

            return INSTANCIA;
        }

        public List<TipoServicio> getServicios()
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "SELECT nombre, porcentajeAdicional ";
            sql += "FROM SENIOR_DEVELOPERS.Servicio";

            SqlDataReader reader = db.executeReader(sql);

            List<TipoServicio> listaServicio = new List<TipoServicio>();
            while (reader.Read())
            {
                TipoServicio tipoServicio = new TipoServicio();

                tipoServicio.nombre = (String)reader["nombre"];
                tipoServicio.porcentajeAdicional = Convert.ToDouble(reader["porcentajeAdicional"]);

                listaServicio.Add(tipoServicio);
            }

            reader.Close();

            return listaServicio;
        }


    }
}
