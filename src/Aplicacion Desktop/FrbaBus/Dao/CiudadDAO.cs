using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.Dominio;
using System.Data.SqlClient;
using FrbaBus.Mensajes;
using System.Data;

namespace FrbaBus.Dao
{
    class CiudadDAO
    {
        private CiudadDAO()
        { }

        private static CiudadDAO INSTANCIA;

        //Singleton
        public static CiudadDAO getInstance()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new CiudadDAO();
            }

            return INSTANCIA;
        }

        public List<Ciudad> getCiudades()
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "SELECT ID, nombre ";
            sql += "FROM SENIOR_DEVELOPERS.Ciudad";
            
            SqlDataReader reader = db.executeReader(sql);

            List<Ciudad> listaCiudad = new List<Ciudad>();
            while (reader.Read())
            {
                Ciudad ciudad = new Ciudad();

                ciudad.ID = (int)reader["ID"];
                ciudad.nombre = (String)reader["nombre"];

                listaCiudad.Add(ciudad);
            }
            reader.Close();

            return listaCiudad;
        }


        //Utilizado en FormBusquedaCiudades
        public DataTable buscarCiudades(String nombre)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "select ID, nombre AS Nombre from SENIOR_DEVELOPERS.Ciudad where 1=1";

            if (!String.IsNullOrEmpty(nombre))
            {
                sql += " AND nombre LIKE '%" + nombre + "%'";
            }

            DataTable tabla = db.obtenerComoTabla(sql);

            return tabla;
        }

        public DataTable getTodasLasCiudadesComoTabla()
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "select ID, nombre AS Nombre from SENIOR_DEVELOPERS.Ciudad";
            DataTable tabla = db.obtenerComoTabla(sql);

            return tabla;
        }

        public Ciudad getCiudad(String nombre)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            Ciudad ciudad = new Ciudad();

            String sql = "select ID from SENIOR_DEVELOPERS.Ciudad where nombre = '" + nombre + "'";
            ciudad.ID = (int)db.executeScalar(sql);
            ciudad.nombre = nombre;

            return ciudad;
            
        }

    }
}
