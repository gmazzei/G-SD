using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.Dominio;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace FrbaBus.Dao
{
    class RecorridoDAO
    {
        private static RecorridoDAO INSTANCIA;

        private RecorridoDAO() { 
        }

        //Singleton
        public static RecorridoDAO getInstance()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new RecorridoDAO();
            }

            return INSTANCIA;
        }


        //Utilizado por FormAltaRecorrido
        public void guardarNuevo(Recorrido recorrido)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String habilitado = recorrido.habilitado ? "Si" : "No";
            
            String sql;
            sql = "exec SENIOR_DEVELOPERS.SP_altaRecorrido ";
            sql += "@codigo = " + recorrido.codigo + ", @ciudadOrigenID = " + recorrido.ciudadOrigen.ID + ", @ciudadDestinoID = " + recorrido.ciudadDestino.ID + ", @tipoServicio = '" + recorrido.tipoServicio.nombre + "', @precioBasePasaje = " + recorrido.precioPasaje.ToString(CultureInfo.InvariantCulture) + ", @precioBaseKG = " + recorrido.precioKg.ToString(CultureInfo.InvariantCulture) + ", @habilitado = '" + habilitado + "'";
            
            db.executeNonQuery(sql);
        }


        public DataTable getRecorridos()
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            
            String sql;
            sql =  "SELECT R.ID, C1.nombre AS 'Ciudad de origen', C2.nombre AS 'Ciudad de Destino', tipoServicio AS 'Tipo de Servicio', precioBasePasaje AS 'Precio base de Pasaje', precioBaseKg AS 'Precio base por Kg', habilitado AS Habilitado ";
            sql += "FROM SENIOR_DEVELOPERS.Recorrido R, SENIOR_DEVELOPERS.Ciudad C1, SENIOR_DEVELOPERS.Ciudad C2 ";
            sql += "WHERE R.ciudadOrigen_ID = C1.ID AND R.ciudadDestino_ID = C2.ID";

            DataTable recorridos = db.obtenerComoTabla(sql);

            return recorridos;
        }

        public DataTable getRecorridos(String codigo, String ciudadOrigen, String ciudadDestino, String tipoServicio, String habilitado)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql;
            sql = "SELECT R.ID, C1.nombre AS 'Ciudad de origen', C2.nombre AS 'Ciudad de Destino', tipoServicio AS 'Tipo de Servicio', precioBasePasaje AS 'Precio base de Pasaje', precioBaseKg AS 'Precio base por Kg', habilitado AS Habilitado ";
            sql += "FROM SENIOR_DEVELOPERS.Recorrido R, SENIOR_DEVELOPERS.Ciudad C1, SENIOR_DEVELOPERS.Ciudad C2 ";
            sql += "WHERE R.ciudadOrigen_ID = C1.ID AND R.ciudadDestino_ID = C2.ID ";

            if(!String.IsNullOrEmpty(codigo))
            {
                sql += "AND R.ID = " + codigo + " ";
            }
            if (!String.IsNullOrEmpty(ciudadOrigen))
            {
                sql += "AND C1.nombre = '" + ciudadOrigen + "' ";
            }
            if (!String.IsNullOrEmpty(ciudadDestino))
            {
                sql += "AND C2.nombre = '" + ciudadDestino + "' ";
            }
            if (!String.IsNullOrEmpty(tipoServicio))
            {
                sql += "AND tipoServicio = '" + tipoServicio + "' ";
            }
            if (!String.IsNullOrEmpty(habilitado))
            {
                sql += "AND R.habilitado = '" + habilitado + "' ";
            }

            DataTable recorridos = db.obtenerComoTabla(sql);

            return recorridos;
                
        }


        public void bajaRecorrido(long recorridoID)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "UPDATE SENIOR_DEVELOPERS.Recorrido ";
            sql += "SET habilitado = 'No' ";
            sql += "WHERE ID = "+ recorridoID;

            db.executeNonQuery(sql);
        }

        public Recorrido getRecorrido(long idRecorrido)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql;
            sql = "SELECT R.ID, C1.ID AS ciudadOrigenID, C1.nombre AS ciudadOrigenNombre, C2.ID AS ciudadDestinoID, C2.nombre AS ciudadDestinoNombre, R.tipoServicio, R.precioBasePasaje, R.precioBaseKg, R.habilitado ";
            sql += "FROM SENIOR_DEVELOPERS.Recorrido R, SENIOR_DEVELOPERS.Ciudad C1, SENIOR_DEVELOPERS.Ciudad C2 ";
            sql += "WHERE R.ciudadOrigen_ID = C1.ID AND R.ciudadDestino_ID = C2.ID ";
            sql += "AND R.ID = "+ idRecorrido;

            SqlDataReader reader = db.executeReader(sql);

            reader.Read();

            Recorrido recorrido = new Recorrido();

            recorrido.codigo = idRecorrido;
            recorrido.precioPasaje = Convert.ToDouble(reader["precioBasePasaje"]);
            recorrido.precioKg = Convert.ToDouble(reader["precioBaseKg"]);
            recorrido.habilitado = ((String)reader["habilitado"]).Equals("Si");
            recorrido.tipoServicio = new TipoServicio();
            recorrido.tipoServicio.nombre = (String)reader["tipoServicio"];
            recorrido.ciudadOrigen = new Ciudad();
            recorrido.ciudadOrigen.ID = (int)reader["ciudadOrigenID"];
            recorrido.ciudadOrigen.nombre = (String)reader["ciudadOrigenNombre"];
            recorrido.ciudadDestino = new Ciudad();
            recorrido.ciudadDestino.ID = (int)reader["ciudadDestinoID"];
            recorrido.ciudadDestino.nombre = (String)reader["ciudadDestinoNombre"];

            reader.Close();

            return recorrido;
        }
        //Utilizado por FormModificarRecorrido
        public void modificarRecorrido(Recorrido recorrido, long codigoAnterior)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            String habilitado = recorrido.habilitado ? "Si" : "No";
            
            sql = "exec SENIOR_DEVELOPERS.SP_modificarRecorrido ";
            sql += "@codigo = " + recorrido.codigo + ", @codigoAnterior = " + codigoAnterior + ", @ciudadOrigenID = " + recorrido.ciudadOrigen.ID + ", @ciudadDestinoID = " + recorrido.ciudadDestino.ID + ", @tipoServicio = '" + recorrido.tipoServicio.nombre + "', @precioBasePasaje = " + recorrido.precioPasaje.ToString().Replace(',','.') + ", @precioBaseKg = " + recorrido.precioKg.ToString().Replace(',','.') + ", @habilitado = '" + habilitado + "'";
            
            db.executeNonQuery(sql);
        }

        /*
        private void validarSiExiste(long codigo)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "SELECT COUNT(*) FROM SENIOR_DEVELOPERS.Recorrido WHERE ID = " + codigo;
            int resultado = (int)db.executeScalar(sql);

            if (resultado != 0)
            {
                throw new SystemException("Ya existe un Recorrido con el mismo codigo.\nPor favor, elija otro.");
            }
        }
        */
        /*
        //Utilizado por FormModificarRecorrido
        public void modificarRecorrido(Recorrido recorrido)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String habilitado = recorrido.habilitado ? "Si" : "No";
            String sql;

            sql = "exec SENIOR_DEVELOPERS.SP_modificarRecorrido ";
            sql += "@codigo = " + recorrido.codigo + ", @codigoAnterior = " + recorrido.codigo + ", @ciudadOrigenID = " + recorrido.ciudadOrigen.ID + ", @ciudadDestinoID = " + recorrido.ciudadDestino.ID + ", @tipoServicio = '" + recorrido.tipoServicio.nombre + "', @precioBasePasaje = " + recorrido.precioPasaje.ToString().Replace('.', ',') + ", @precioBaseKg = " + recorrido.precioKg.ToString().Replace('.', ',') + ", @habilitado = '" + habilitado + "'";

            db.executeNonQuery(sql);
        }
        */
        public List<Recorrido> getRecorridosHabilitados()
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql;
            sql = "SELECT R.ID, C1.nombre AS 'ciudadOrigenNombre', C2.nombre AS 'ciudadDestinoNombre', tipoServicio, precioBasePasaje, precioBaseKg, habilitado ";
            sql += "FROM SENIOR_DEVELOPERS.Recorrido R, SENIOR_DEVELOPERS.Ciudad C1, SENIOR_DEVELOPERS.Ciudad C2 ";
            sql += "WHERE R.ciudadOrigen_ID = C1.ID AND R.ciudadDestino_ID = C2.ID AND R.habilitado = 'Si'";

            SqlDataReader reader = db.executeReader(sql);

            List<Recorrido> recorridos = new List<Recorrido>();
            while (reader.Read())
            {
                Recorrido recorrido = new Recorrido();

                recorrido.codigo = Convert.ToInt64(reader["ID"].ToString());
                recorrido.precioPasaje = Convert.ToDouble(reader["precioBasePasaje"]);
                recorrido.precioKg = Convert.ToDouble(reader["precioBaseKg"]);
                recorrido.habilitado = ((String)reader["habilitado"]).Equals("Si");
                recorrido.tipoServicio = new TipoServicio();
                recorrido.tipoServicio.nombre = (String)reader["tipoServicio"];
                recorrido.ciudadOrigen = new Ciudad();
                
                recorrido.ciudadOrigen.nombre = (String)reader["ciudadOrigenNombre"];
                recorrido.ciudadDestino = new Ciudad();
                
                recorrido.ciudadDestino.nombre = (String)reader["ciudadDestinoNombre"];

                recorridos.Add(recorrido);
            }

            
            reader.Close();


            return recorridos;
        }
    }
}
