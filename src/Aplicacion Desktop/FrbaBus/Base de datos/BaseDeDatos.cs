using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using FrbaBus.Mensajes;
using System.Data;
using System.Configuration;

namespace FrbaBus
{
    class BaseDeDatos
    {
        private static BaseDeDatos instance = null;
        private SqlConnection connection;

        public static BaseDeDatos Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BaseDeDatos();
                }

                return instance;
            }
        }

        private BaseDeDatos()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            //connection = new SqlConnection(@"Data Source=localhost\SQLSERVER2008;Initial Catalog=GD1C2013;User ID=gd;Password=gd2013");
            
            connection.Open();
        }

        public DataTable obtenerComoTabla(string sentencia)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sentencia, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void executeNonQuery(string sentencia)
        {
            SqlCommand command = new SqlCommand(sentencia, connection);
            command.ExecuteNonQuery();
        }

        public Object executeScalar(string sentencia)
        {
            SqlCommand command = new SqlCommand(sentencia, connection);
            return command.ExecuteScalar();   
        }

        public SqlDataReader executeReader(string sentencia)
        {   
            SqlCommand command = new SqlCommand(sentencia, connection);
            return command.ExecuteReader();
        }
    }
}
