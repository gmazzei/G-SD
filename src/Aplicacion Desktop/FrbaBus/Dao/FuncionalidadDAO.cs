using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.Dominio;
using System.Data.SqlClient;

namespace FrbaBus.Dao
{
    class FuncionalidadDAO
    {
        private FuncionalidadDAO()
        { }

        private static FuncionalidadDAO INSTANCIA;

        //Singleton
        public static FuncionalidadDAO getInstance()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new FuncionalidadDAO();
            }

            return INSTANCIA;
        }

        public List<Funcionalidad> getFuncionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            BaseDeDatos db = BaseDeDatos.Instance;
            
            String sql = "SELECT ID, nombre ";
            sql += "FROM SENIOR_DEVELOPERS.Funcionalidad";

            SqlDataReader reader = db.executeReader(sql);

            while (reader.Read())
            {
                Funcionalidad funcionalidad = new Funcionalidad();

                funcionalidad.ID = (int)reader["ID"];
                funcionalidad.nombre = (String)reader["nombre"];

                funcionalidades.Add(funcionalidad);
            }

            reader.Close();

            return funcionalidades;
        }

    }
}
