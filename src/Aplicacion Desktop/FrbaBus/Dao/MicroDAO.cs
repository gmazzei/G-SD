using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.Dominio;
using System.Data.SqlClient;
using System.Data;
using FrbaBus.Global;

namespace FrbaBus.Dao
{
    class MicroDAO
    {
        private static MicroDAO INSTANCIA;

        private MicroDAO() { 
        }

        //Singleton
        public static MicroDAO getInstance()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new MicroDAO();
            }

            return INSTANCIA;
        }

        public Micro getMicro(String patente)
        {
            Micro micro = new Micro();
            String sql;
            BaseDeDatos db = BaseDeDatos.Instance;
            
            sql = "SELECT patente, nro, marca, modelo, tipoServicio, bajaFueraServicio, bajaVidaUtil, cantidadButacas, KGDisponibles, fechaAlta, fechaFueraServicio, fechaReinicioServicio, fechaBajaDefinitiva ";
            sql += "FROM SENIOR_DEVELOPERS.Micro ";
            sql += "WHERE patente = '"+patente+"'";
            
            SqlDataReader reader = db.executeReader(sql);
            reader.Read();

            micro.patente = patente;
            micro.numero = Convert.ToInt32(reader["nro"]);
            micro.modelo = (String)reader["modelo"];
            micro.marca = (String)reader["marca"];
            micro.tipoServicio = new TipoServicio();
            micro.tipoServicio.nombre = (String)reader["tipoServicio"];
            micro.bajaFueraServicio = ((String)reader["bajaFueraServicio"]).Equals("Si");
            micro.bajaVidaUtil = ((String)reader["bajaVidaUtil"]).Equals("Si");
            micro.kgDisponibles = Convert.ToInt32(reader["KGDisponibles"]);
            micro.cantidadButacas = Convert.ToInt32(reader["cantidadButacas"]);
            micro.fechaAlta = (DateTime)reader["fechaAlta"];
            
            if (!reader.IsDBNull(10))
            {
                micro.fechaFueraServicio = (DateTime)reader["fechaFueraServicio"];
            }
            if (!reader.IsDBNull(11))
            {
                micro.fechaReinicioServicio = (DateTime)reader["fechaReinicioServicio"];
            }
            if (!reader.IsDBNull(12))
            {
                micro.fechaBajaDefinitiva = (DateTime)reader["fechaBajaDefinitiva"];
            }

            reader.Close();

            return micro;
        }

        public void registrarLlegada(String patente, DateTime date, Ciudad ciudadOrigen, Ciudad ciudadDestino)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "exec SENIOR_DEVELOPERS.SP_registrarLlegada @microPatente = '"+patente+"', @fecha = '"+date.ToString("yyyy-MM-dd hh:mm:ss")+"', @ciudadOrigenID = "+ciudadOrigen.ID+", @ciudadDestinoID = " + ciudadDestino.ID;

            db.executeNonQuery(sql);
        }


        public List<String> getPatentesHabilitadas()
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            List<String> listaPatentes = new List<String>();

            String sql = "SELECT patente FROM SENIOR_DEVELOPERS.Micro ";
            sql += "WHERE bajaVidaUtil = 'No' AND bajaFueraServicio = 'No'";
            
            SqlDataReader reader = db.executeReader(sql);
            while (reader.Read())
            {
                listaPatentes.Add((String)reader["patente"]);
            }
            reader.Close();

            return listaPatentes;
        }

        public DataTable getMicrosConMasDiasFueraDeServicio(int anio, int semestre)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            /*
            sql = "SELECT TOP 5 Micro, SUM([Cantidad de dias fuera de servicio]) AS 'Total de dias fuera de servicio' ";
            sql += "FROM SENIOR_DEVELOPERS.V_MicrosDiasFueraDeServicio ";
            sql += "WHERE ";
            sql += "YEAR(fecha) = "+ anio +" ";
            sql += "AND SENIOR_DEVELOPERS.FN_fechaEsDeSemestre(fecha) = " + semestre + " ";
            sql += "GROUP BY Micro ";
            sql += "ORDER BY 'Total de dias fuera de servicio' ASC";
            */

            sql = "SELECT Micro, Dias from SENIOR_DEVELOPERS.FN_ListadoMicrosFueraServicio(" + anio + ", " + semestre + ")";
            
            DataTable tabla = db.obtenerComoTabla(sql);

            return tabla;
        }


        public void guardarNuevoMicro(Micro micro, List<Butaca> butacas)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            
            String sql;
            
            sql = "exec SENIOR_DEVELOPERS.SP_altaMicro ";
            sql += "@patente = '" + micro.patente + "', @nro = " + micro.numero + ", @marca = '" + micro.marca + "', @modelo = '" + micro.modelo + "', ";
            sql += "@tipoServicio = '" + micro.tipoServicio.nombre + "', @cantidadButacas = " + micro.cantidadButacas + ", @kgDisponibles = " + micro.kgDisponibles + ", @fechaAlta = '" + micro.fechaAlta.ToString("yyyy-MM-dd HH:mm:ss") + "'";
             
            db.executeNonQuery(sql);

            this.insertarButacas(butacas, micro);
        }

        private void insertarButacas(List<Butaca> butacas, Micro micro)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            
            foreach (Butaca unaButaca in butacas)
            {
                sql = "insert into SENIOR_DEVELOPERS.Butaca ";
                sql += "(NRO, micro_patente, piso, tipo) ";
                sql += "values ";
                sql += "(" + unaButaca.nro + ", '" + micro.patente + "', " + unaButaca.piso + ", '" + unaButaca.tipo + "')";

                db.executeNonQuery(sql);
            }
            
        }
        

        public DataTable getMicro(String patente, String nro, String tipoServicio, String bajaFueraServicio, String bajaVidaUtil)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql;
            
            sql = "SELECT patente AS Patente, nro AS Nro, marca AS Marca, modelo AS Modelo, tipoServicio AS 'Tipo de Servicio', bajaFueraServicio AS 'Baja por fuera de servicio', bajaVidaUtil AS 'Baja por vida util', cantidadButacas AS 'Cantidad de butacas', KGDisponibles AS 'KG disponibles', fechaAlta AS 'Fecha de alta', fechaFueraServicio AS 'Fecha fuera de servicio', fechaReinicioServicio AS 'Fecha de reinicio de servicio', fechaBajaDefinitiva AS 'Fecha de baja definitiva' ";
            sql += "FROM SENIOR_DEVELOPERS.Micro ";
            sql += "WHERE 1 = 1 ";

            if (!String.IsNullOrEmpty(patente))
            {
                sql += "AND patente = '" + patente + "' ";
            }
            if (!String.IsNullOrEmpty(nro))
            {
                sql += "AND nro = " + nro + " ";
            }
            if (!String.IsNullOrEmpty(tipoServicio))
            {
                sql += "AND tipoServicio = '" + tipoServicio+ "' ";
            }
            if (!String.IsNullOrEmpty(bajaFueraServicio))
            {
                sql += "AND bajaFueraServicio = '" + bajaFueraServicio + "' ";
            }
            if (!String.IsNullOrEmpty(bajaVidaUtil))
            {
                sql += "AND bajaVidaUtil = '" + bajaVidaUtil + "' ";
            }

            DataTable micros = db.obtenerComoTabla(sql);

            return micros;
        }

        public DataTable getMicros()
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "SELECT patente AS Patente, nro AS Nro, marca AS Marca, modelo AS Modelo, ";
            sql += "bajaFueraServicio AS 'Baja (Fuera de servicio)', bajaVidaUtil AS 'Baja (Vida util)', ";
            sql += "cantidadButacas AS 'Cantidad de butacas', KGDisponibles AS 'KG Disponibles', ";
            sql += "fechaAlta AS 'Fecha de Alta', fechaFueraServicio AS 'Fecha - Fuera de servicio', fechaReinicioServicio AS 'Fecha - Reinicio del servicio', ";
            sql += "fechaBajaDefinitiva AS 'Fecha - Fin de vida util' ";
            sql += "FROM SENIOR_DEVELOPERS.Micro";

            DataTable tabla = db.obtenerComoTabla(sql);
            return tabla;
        }

        public void bajaVidaUtil(String patente, DateTime fecha)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            
            sql = "UPDATE SENIOR_DEVELOPERS.Micro ";
            sql += "SET  ";
            sql += "bajaVidaUtil = 'Si', ";
            sql += "fechaBajaDefinitiva = CONVERT(DATE, '" + fecha.ToString("yyyy-MM-dd") +"') ";
            sql += "WHERE patente = '" + patente + "'";

            db.executeNonQuery(sql);
        }


        public void bajaFueraServicio(String patente, DateTime fechaFuera, DateTime fechaReinicio)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            /*
            sql = "UPDATE SENIOR_DEVELOPERS.Micro ";
            sql += "SET ";
            sql += "bajaFueraServicio = 'Si', ";
            sql += "fechaFueraServicio = CONVERT(DATE, '" + fechaFuera.ToString("yyyy-MM-dd") + "'), ";
            sql += "fechaReinicioServicio = CONVERT(DATE, '" + fechaReinicio.ToString("yyyy-MM-dd") + "') ";
            sql += "WHERE patente = '"+patente+"'";
            */

            sql = "exec SENIOR_DEVELOPERS.SP_darBajaFueraServicio @patente = '" + patente + "', @fechaInicio = '" + fechaFuera.ToString("yyyy-MM-dd") + "', @fechaReinicio = '" + fechaReinicio.ToString("yyyy-MM-dd") + "'";

            db.executeNonQuery(sql);
        }

        public String hayMicroDeReemplazo(String patente, DateTime fechaVidaUtil)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            
            sql = "SELECT SENIOR_DEVELOPERS.FN_reemplazoDe('"+patente+"', CONVERT(DATE, '" + fechaVidaUtil.ToString("yyyy-MM-dd") + "'))";

            String otraPatente = (String)db.executeScalar(sql);

            return otraPatente;
        }

        public String hayMicroDeReemplazo(String patente, DateTime fechaFuera, DateTime fechaReinicio)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "SELECT SENIOR_DEVELOPERS.FN_reemplazoDe2('" + patente + "' , '" + fechaFuera.ToString("yyyy-MM-dd") + "', '" + fechaReinicio.ToString("yyyy-MM-dd") + "')";
            
            String otraPatente = (String)db.executeScalar(sql);
            
            return otraPatente;
        }

        



        public void reemplazarMicro(String patente, String patenteReemplazo, DateTime fechaBajaVidaUtil)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "UPDATE SENIOR_DEVELOPERS.Viaje SET micro_patente = '" + patenteReemplazo + "' ";
            sql += "WHERE micro_patente = '" + patente + "' ";
            sql += "AND fechaLlegadaEstimada > CONVERT(DATE, '"+fechaBajaVidaUtil.ToString("yyyy-MM-dd")+"')";
            db.executeNonQuery(sql);            
        }

        public void reemplazarMicro(String patente, String patenteReemplazo, DateTime fechaFuera, DateTime fechaReinicio)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "UPDATE SENIOR_DEVELOPERS.Viaje SET micro_patente = '" + patenteReemplazo + "' ";
            sql += "WHERE micro_patente = '" + patente + "' ";
            sql += "AND fechaLlegadaEstimada < CONVERT(DATE, '"+fechaReinicio.ToString("yyyy-MM-dd")+"') ";
            sql += "AND fechaSalida > CONVERT(DATE, '"+fechaFuera.ToString("yyyy-MM-dd")+"')";
            db.executeNonQuery(sql);
        }



        public void copiarMicro(String patente, String otraPatente)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            DateTime fechaAlta = Aplicacion.getFecha();

            String sql = "EXEC SENIOR_DEVELOPERS.SP_copiarMicro '" + patente + "', '" + otraPatente + "', '"+ fechaAlta.ToString("yyyy-MM-dd") +"'";
            db.executeNonQuery(sql);

        }

        public void cancelarMicro(String patente, DateTime fechaVidaUtil)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "UPDATE SENIOR_DEVELOPERS.Viaje SET estado = 'Cancelado' WHERE micro_patente = '"+patente+"' AND fechaLlegadaEstimada >= CONVERT(DATE, '"+fechaVidaUtil.ToString("yyyy-MM-dd")+"')";

            db.executeNonQuery(sql);
            this.bajaVidaUtil(patente, fechaVidaUtil);
        }

        public void cancelarMicro(String patente, DateTime fechaFuera, DateTime fechaReinicio)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "UPDATE SENIOR_DEVELOPERS.Viaje SET estado = 'Cancelado' WHERE micro_patente = '" + patente + "' ";
            sql += "AND fechaLlegadaEstimada < CONVERT(DATE, '" + fechaReinicio.ToString("yyyy-MM-dd") + "') ";
            sql += "OR fechaSalida > CONVERT(DATE, '" + fechaFuera.ToString("yyyy-MM-dd") + "')";

            db.executeNonQuery(sql);
            this.bajaFueraServicio(patente, fechaFuera, fechaReinicio);
        }




        public void modificarMicro(Micro micro, String patenteAnterior)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            String bajaVidaUtil = micro.bajaVidaUtil ? "Si" : "No";
            String bajaFueraServicio = micro.bajaFueraServicio ? "Si" : "No";

            sql = "exec SENIOR_DEVELOPERS.SP_modificarMicro ";
            sql += "@patente = '" + micro.patente + "', @patenteAnt = '" + patenteAnterior + "', @nro = " + micro.numero + ", @tipoServicio = '" + micro.tipoServicio.nombre + "', @marca = '" + micro.marca + "', @modelo = '" + micro.modelo + "', @bajaFueraServicio = '" + bajaFueraServicio + "', @bajaVidaUtil = '" + bajaVidaUtil + "'";

            db.executeNonQuery(sql);

        }


        //Utilizado por Baja Micro
        public Boolean existeMicro(String patente)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            Boolean existe;

            sql = "select COUNT(*) from SENIOR_DEVELOPERS.Micro where patente = " + patente;
            int cantidad = (int)db.executeScalar(sql);

            existe = (cantidad == 1);

            return existe;
        }

    }
}
