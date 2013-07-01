using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.Dominio;
using System.Data.SqlClient;
using System.Data;

namespace FrbaBus.Dao
{
    class ViajeDAO
    {
        private static ViajeDAO INSTANCIA = null;

        private ViajeDAO() { 
        }

        //Singleton
        public static ViajeDAO getInstance()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new ViajeDAO();
            }

            return INSTANCIA;
        }

        public void guardar(Viaje viaje)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "exec SENIOR_DEVELOPERS.SP_generarViaje ";
            sql += "@recorridoID = " + viaje.recorridoID + ", @microPatente = '" + viaje.microPatente + "', @fechaSalida = '" + viaje.fechaSalida.ToString("yyyy-MM-dd hh:mm:ss") + "', @fechaLlegadaEstimada = '" + viaje.fechaLlegadaEstimada.ToString("yyyy-MM-dd hh:mm:ss") + "'";

            db.executeNonQuery(sql);
        }


        public DataTable buscarViajes(DateTime fechaViaje, Ciudad ciudadOrigen, Ciudad ciudadDestino)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "SELECT V.ID, M.tipoServicio AS 'Tipo de servicio', M.cantidadButacas AS 'Cantidad de butacas totales', M.cantidadButacas - COUNT(P.butaca_NRO) AS 'Butacas libres', ";
            sql += "M.KGDisponibles AS 'Kg Totales', (SELECT M.KGDisponibles - ISNULL(SUM(E.KG),0) FROM SENIOR_DEVELOPERS.Encomienda E LEFT JOIN SENIOR_DEVELOPERS.Viaje Vi ON Vi.ID = E.viaje_ID WHERE E.viaje_ID = V.ID ) AS 'Kg Libres' ";
            sql += "FROM SENIOR_DEVELOPERS.Viaje V ";
            sql += "INNER JOIN SENIOR_DEVELOPERS.Recorrido R ON R.ID = V.recorrido_ID ";
            sql += "INNER JOIN SENIOR_DEVELOPERS.Micro M ON M.patente = V.micro_patente ";
            sql += "LEFT JOIN SENIOR_DEVELOPERS.Pasaje P ON P.viaje_ID = V.ID ";
            sql += "WHERE ";
            sql += "R.ciudadOrigen_ID = "+ciudadOrigen.ID+" ";
            sql += "AND R.ciudadDestino_ID = "+ciudadDestino.ID+" ";
            sql += "AND CAST(V.fechaSalida AS DATE) = CONVERT(DATE, '"+fechaViaje.ToString("yyyy-MM-dd")+"') ";
            sql += "AND V.estado = 'Vigente' ";
            sql += "AND R.habilitado = 'Si' ";
            sql += "GROUP BY V.ID, M.tipoServicio, M.cantidadButacas, M.KGDisponibles";

            
            DataTable tabla = db.obtenerComoTabla(sql);
            return tabla;
        }


        public DataTable getButacasLibres(int viajeID, List<Pasaje> pasajesYaDefinidos)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "select B.NRO, B.piso, B.tipo ";
            sql += "from SENIOR_DEVELOPERS.Butaca B ";
            sql += "inner join SENIOR_DEVELOPERS.Viaje V on V.micro_patente = B.micro_patente ";
            sql += "where ";
            sql += "V.ID = "+ viajeID +" ";
            sql += "and B.NRO not in (select P.butaca_NRO from SENIOR_DEVELOPERS.Pasaje P where P.viaje_ID = "+ viajeID +") ";

            foreach (Pasaje unPasaje in pasajesYaDefinidos)
            {
                sql += "and B.NRO != " + unPasaje.butacaNRO + " ";
            }

            DataTable tabla = db.obtenerComoTabla(sql);

            return tabla;
        }


        /*
        private void validar(Viaje viaje)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            //Valido mismo servicio
            sql = "SELECT tipoServicio FROM SENIOR_DEVELOPERS.Recorrido WHERE ID = " + viaje.recorridoID;
            String servicioRecorrido = (String)db.executeScalar(sql);

            sql = "SELECT tipoServicio FROM SENIOR_DEVELOPERS.Micro WHERE patente = '"+ viaje.microPatente +"'";
            String servicioMicro = (String)db.executeScalar(sql);
                    
            if (servicioRecorrido != servicioMicro)
            {
                throw new SystemException("El tipo de Servicio del micro y del recorrido son diferentes.\nPor favor, elija un micro y un recorrido de modo que estos valores coincidan.");
            }



            //Valido micro sin servicio
            sql = "SELECT bajaVidaUtil, bajaFueraServicio FROM SENIOR_DEVELOPERS.Micro WHERE patente = '"+ viaje.microPatente +"'";
            SqlDataReader reader = db.executeReader(sql);
            reader.Read();
            String bajaVidaUtil = (String)reader["bajaVidaUtil"];
            String bajaFueraServicio = (String)reader["bajaFueraServicio"];
            reader.Close();

            if((bajaVidaUtil.Equals("Si")))
            {
                throw new SystemException("El micro ha terminado su vida util. Por favor, elija otro.");
            }


            if (bajaFueraServicio.Equals("Si"))
            {
                throw new SystemException("El micro se encuentra fuera de servicio. Por favor, elija otro.");
            }
                    
                    

            //Valido viajes simultaneos

            sql  = "SELECT COUNT(*) FROM SENIOR_DEVELOPERS.Viaje WHERE micro_patente = '"+ viaje.microPatente +"' ";
            sql += "AND CONVERT(DATETIME, '" + viaje.fechaSalida.ToString("yyyy-MM-dd hh:mm:ss") + "') BETWEEN fechaSalida AND DATEADD(HOUR, 24, fechaSalida) AND estado = 'Vigente'";
                    
            int viajesSimultaneos = (int)db.executeScalar(sql);
                    
            if(viajesSimultaneos > 0)
            {
                throw new SystemException("Ya hay un viaje de este micro durante el rango de fechas seleccionado.");
            }

                    
        }
*/

    }
}
