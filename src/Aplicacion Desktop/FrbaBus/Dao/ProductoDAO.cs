using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.Dominio;
using System.Data.SqlClient;

namespace FrbaBus.Dao
{
    class ProductoDAO
    {
        private static ProductoDAO INSTANCIA;

        private ProductoDAO() { 
        }

        //Singleton
        public static ProductoDAO getInstance()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new ProductoDAO();
            }

            return INSTANCIA;
        }

        public List<Producto> getProductos()
        {
            List<Producto> productos = new List<Producto>();

            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "SELECT ID, nombre, puntosNecesarios, stock ";
            sql += "FROM SENIOR_DEVELOPERS.Producto";

            SqlDataReader reader = db.executeReader(sql);

            while (reader.Read())
            {
                Producto unProducto = new Producto();

                unProducto.ID = (int)reader["ID"];
                unProducto.nombre = (String)reader["nombre"];
                unProducto.puntosNecesarios = (int)reader["puntosNecesarios"];
                unProducto.stock = (int)reader["stock"];

                productos.Add(unProducto);
            }
            reader.Close();

            return productos;
        }

        public void realizarCanje(long dniCliente, int productoID, int cantidad)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql = "exec SENIOR_DEVELOPERS.SP_realizarCanje @dni = "+ dniCliente +", @productoID = "+ productoID +", @cantidad = " +cantidad;   
            db.executeNonQuery(sql);
        }




        /*
        private void validarStock(long dniCliente, int productoID, int cantidad)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "SELECT stock FROM SENIOR_DEVELOPERS.Producto WHERE ID = " + productoID;
            int stock = (int)db.executeScalar(sql);

            if (cantidad > stock)
            {
                throw new SystemException("Lo sentimos, no hay stock suficiente del producto para realizar el canje.");
            }


            sql = "SELECT SUM(puntos) FROM SENIOR_DEVELOPERS.V_PuntosClientesALaFecha WHERE cliente_DNI = " + dniCliente;
            int puntosCliente = (int)db.executeScalar(sql);

            sql = "SELECT puntosNecesarios FROM SENIOR_DEVELOPERS.Producto WHERE ID = " + productoID;
            int puntosNecesarios = ((int)db.executeScalar(sql)) * cantidad;
            

            if (puntosCliente < puntosNecesarios)
            {
                throw new SystemException("Lo sentimos, no tiene puntos suficientes.");
            }
        }

        private void validarCliente(long dniCliente)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "SELECT COUNT(*) FROM SENIOR_DEVELOPERS.Cliente WHERE DNI = "+ dniCliente;
            int resultado = (int) db.executeScalar(sql);

            if (resultado != 1)
            {
                throw new SystemException("Lo sentimos, el dni que ha ingresado no corresponde a ningun cliente conocido.");
            }

        }
        */
    }
}
