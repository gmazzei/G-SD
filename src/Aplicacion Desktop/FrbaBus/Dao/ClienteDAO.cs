using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FrbaBus.Dominio;
using System.Data.SqlClient;

namespace FrbaBus.Dao
{
    class ClienteDAO
    {
        private ClienteDAO()
        { }

        private static ClienteDAO INSTANCIA;

        //Singleton
        public static ClienteDAO getInstance()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new ClienteDAO();
            }

            return INSTANCIA;
        }

        public int getPuntos(long DNI)
        { 
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            
            sql = "SELECT ISNULL(SUM(puntos), 0) FROM SENIOR_DEVELOPERS.V_PuntosClientesALaFecha WHERE cliente_DNI = " + DNI;
            int puntos = (int)db.executeScalar(sql);
            return puntos;
        }

        public DataTable getPasajesEncomiendasParaPuntos(long DNI)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql;
            sql = "SELECT * FROM SENIOR_DEVELOPERS.V_ClientePasajeEncomienda WHERE fecha > DATEADD(YEAR,-1,GETDATE()) AND cliente_DNI = " + DNI;

            DataTable tabla = db.obtenerComoTabla(sql);

            return tabla;
        }

        public DataTable getCanjesParaPuntos(long DNI)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql;
            sql = "SELECT * FROM SENIOR_DEVELOPERS.Canje WHERE cliente_DNI = " + DNI + " ";
            sql += "AND fecha > DATEADD(YEAR, -1, GETDATE())";

            DataTable tabla = db.obtenerComoTabla(sql);

            return tabla;
        }

        public DataTable getTOP5Clientes()
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            
            sql = "SELECT TOP 5 cliente_DNI, SUM(puntos) AS 'Puntos Acumulados' ";
            sql += "FROM SENIOR_DEVELOPERS.V_PuntosClientesALaFecha ";
            sql += "GROUP BY cliente_DNI ORDER BY 'Puntos Acumulados' DESC";

            DataTable tabla = db.obtenerComoTabla(sql);

            return tabla;
        }

        public DataTable getClientesConMasPuntosHastaLaFecha(int anio, int semestre)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            String whereAnio;

            if (semestre == 2)
            {
                whereAnio = "YEAR(fecha) = " + anio + " ";
            }
            else
            {
                whereAnio = "fecha BETWEEN CONVERT(DATE, '" + (anio - 1) + "/7/1') AND CONVERT(DATE, '" + anio + "/7/1') ";
            }

            sql = "SELECT TOP 5 cliente_DNI, SUM(puntos) AS 'Puntos acumulados' ";
            sql += "FROM SENIOR_DEVELOPERS.V_ClientePuntos ";
            sql += "WHERE ";
            sql += whereAnio;
            sql += "GROUP BY cliente_DNI ";
            sql += "ORDER BY 'Puntos Acumulados' DESC ";

            DataTable tabla = db.obtenerComoTabla(sql);
            return tabla;
        }


        public Cliente getCliente(long dni)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            Cliente cliente = null;

            sql = "SELECT COUNT(*) FROM SENIOR_DEVELOPERS.Cliente WHERE DNI = " + dni;
            int cantidad = (int)db.executeScalar(sql);

            if (cantidad == 1)
            {
                sql = "SELECT DNI, nombre, apellido, direccion, genero, telefono, mail, fechaNacimiento, esDiscapacitado ";
                sql += "FROM SENIOR_DEVELOPERS.Cliente WHERE DNI = " + dni;

                cliente = new Cliente();
                SqlDataReader reader = db.executeReader(sql);
                reader.Read();

                cliente.dni = dni;
                cliente.apellido = (String)reader["apellido"];
                cliente.nombre = (String)reader["nombre"];
                cliente.direccion = (String)reader["direccion"];
                cliente.telefono = reader["telefono"].ToString();
                cliente.fechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento"]);
                cliente.esDiscapacitado = (String)reader["esDiscapacitado"];
                
                if (!reader.IsDBNull(6))
                {
                    cliente.mail = (String)reader["mail"];
                }
                else
                {
                    cliente.mail = "";
                }

                if (!reader.IsDBNull(4))
                {
                    cliente.genero = (String)reader["genero"];
                }
                else 
                {
                    cliente.genero = "";
                }

                reader.Close();
            }

            return cliente;

        }

        

        
        public void actualizarCliente(Cliente cliente, long dniAnteriorCliente)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            if (String.IsNullOrEmpty(cliente.mail))
            {
                cliente.mail = "NULL";
            }
            else 
            {
                cliente.mail = "'" + cliente.mail +"'";
            }
            

            String sql;
            sql = "EXEC SENIOR_DEVELOPERS.SP_insertarOActualizarCliente ";
            sql += "@DNI = "+ dniAnteriorCliente +", @nuevoDNI = "+ cliente.dni +", @nombre = '"+ cliente.nombre +"', @apellido = '"+ cliente.apellido +"', ";
            sql += "@direccion = '"+ cliente.direccion +"', @fechaNacimiento = '"+cliente.fechaNacimiento.ToString("yyyy-MM-dd hh:mm:ss")+"', ";
            sql += "@mail = "+ cliente.mail +", @genero = '"+ cliente.genero +"', @esDiscapacitado = '"+ cliente.esDiscapacitado +"', @telefono = " + cliente.telefono;

            db.executeNonQuery(sql);
        }
    }
}
