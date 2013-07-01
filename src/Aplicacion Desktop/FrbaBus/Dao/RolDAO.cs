using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.Dominio;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace FrbaBus.Dao
{
    class RolDAO
    {
        private static RolDAO INSTANCIA = null;

        private RolDAO() { 
        }

        //Singleton
        public static RolDAO getInstance()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new RolDAO();
            }

            return INSTANCIA;
        }


        public Rol getRolHabilitado(int ID)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            SqlDataReader reader;
            Rol rol = null;
            int cantidadRoles = 0;


            //Rol
            String sql = "SELECT ID, nombre, habilitado ";
            sql += "FROM SENIOR_DEVELOPERS.Rol ";
            sql += "WHERE ID = "+ ID +" ";
            sql += "AND habilitado = 'Si'";

            reader = db.executeReader(sql);
            while (reader.Read())
            {
                rol = new Rol();

                rol.ID = ID;
                rol.nombre = (String)reader["nombre"];
                rol.habilitado = true;
                rol.funcionalidades = new List<Funcionalidad>();

                cantidadRoles++;
            }

            reader.Close();

            //Funcionalidades
            sql = "SELECT F.ID, F.Nombre ";
            sql += "FROM SENIOR_DEVELOPERS.Rol_Funcionalidad RF ";
            sql += "INNER JOIN SENIOR_DEVELOPERS.Funcionalidad F ON F.ID = RF.funcionalidad_ID ";
            sql += "WHERE RF.rol_ID = "+ rol.ID;
            reader = db.executeReader(sql);
            while (reader.Read())
            {
                Funcionalidad funcionalidad = new Funcionalidad();

                funcionalidad.ID = (int)reader["ID"];
                funcionalidad.nombre = (String)reader["nombre"];

                rol.funcionalidades.Add(funcionalidad);
            }

            reader.Close();



            if (cantidadRoles == 1)
            {
                return rol;
            }
            else if (cantidadRoles == 0)
            {
                throw new SystemException("No se encontro ningun rol el ID = " + ID);
            }
            else
            {
                throw new SystemException("Parece que hay una inconsistencia en la cantidad de roles con ID = "+ ID +". Por favor, consulte al encargado de la aplicacion.");
            }
        }



        //Utilizado por FormAltaRol
        public void guardarNuevoRol(Rol rol)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            String habilitado;

            habilitado = rol.habilitado ? "Si" : "No";

            sql = "exec SENIOR_DEVELOPERS.SP_altaRol @nombre = '"+ rol.nombre +"', @habilitado = '"+ habilitado +"'";
            db.executeNonQuery(sql);

            sql = "select ID from SENIOR_DEVELOPERS.Rol where nombre = '"+ rol.nombre+"'";
            rol.ID = (int)db.executeScalar(sql);

            foreach(Funcionalidad unaFuncionalidad in rol.funcionalidades)
            {
                sql = "insert into SENIOR_DEVELOPERS.Rol_Funcionalidad (rol_ID, funcionalidad_ID) ";
                sql += "VALUES (" + rol.ID + ", " + unaFuncionalidad.ID + ")";
                db.executeNonQuery(sql);
            }
            
        }

        //Utilizado por FormListadoRol
        public DataTable getRoles()
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "SELECT ID, nombre AS Nombre, habilitado AS Habilitado FROM SENIOR_DEVELOPERS.Rol";

            DataTable listaRoles = db.obtenerComoTabla(sql);

            return listaRoles;
        }

        public DataTable getRoles(String nombre, String habilitado)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "SELECT ID, nombre, habilitado FROM SENIOR_DEVELOPERS.Rol WHERE 1=1";

            if (!nombre.Equals(""))
            {
                sql += " AND nombre LIKE '%"+ nombre +"%'";
            }
            if (!habilitado.Equals(""))
            {
                sql += " AND habilitado = '"+ habilitado +"'";
            }


            DataTable listaRoles = db.obtenerComoTabla(sql);

            return listaRoles;
        }


        //Utilizado por FormListadoRol para la baja
        public void bajaRol(int rolID)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "UPDATE SENIOR_DEVELOPERS.Rol ";
            sql += "SET habilitado = 'No' ";
            sql += "WHERE ID = " + rolID;
            
            db.executeNonQuery(sql);
        }


        //Utilizado por FormModificarRol
        public Rol getRol(int ID)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            SqlDataReader reader;
            

            //Rol
            String sql = "SELECT ID, nombre, habilitado ";
            sql += "FROM SENIOR_DEVELOPERS.Rol ";
            sql += "WHERE ID = " + ID;
        
            reader = db.executeReader(sql);
            reader.Read();
            
            Rol rol = new Rol();
            rol.ID = ID;
            rol.nombre = (String)reader["nombre"];
            rol.habilitado = Convert.ToString(reader["habilitado"]).Equals("Si");

            reader.Close();


            //Funcionalidades del rol
            rol.funcionalidades = new List<Funcionalidad>();

            sql = "SELECT F.ID, F.Nombre ";
            sql += "FROM SENIOR_DEVELOPERS.Rol_Funcionalidad RF ";
            sql += "INNER JOIN SENIOR_DEVELOPERS.Funcionalidad F ON F.ID = RF.funcionalidad_ID ";
            sql += "WHERE RF.rol_ID = " + rol.ID;
            reader = db.executeReader(sql);

            while (reader.Read())
            {
                Funcionalidad funcionalidad = new Funcionalidad();

                funcionalidad.ID = (int)reader["ID"];
                funcionalidad.nombre = (String)reader["nombre"];

                rol.funcionalidades.Add(funcionalidad);
            }

            reader.Close();

            return rol;
        }


        //Utilizado por FormModificarRol
        public void modificarRol(Rol rol)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String habilitado;

            habilitado = rol.habilitado ? "Si" : "No";

            String sql = "exec SENIOR_DEVELOPERS.SP_modificarRol @rolID = "+ rol.ID +", @nombre = '"+ rol.nombre +"', @habilitado = '"+ habilitado +"'";
            db.executeNonQuery(sql);

            sql = "DELETE FROM SENIOR_DEVELOPERS.rol_funcionalidad ";
            sql += "WHERE rol_ID = " + rol.ID;
            db.executeNonQuery(sql);


            foreach (Funcionalidad unaFuncionalidad in rol.funcionalidades)
            {
                sql = "INSERT INTO SENIOR_DEVELOPERS.Rol_Funcionalidad (rol_ID, funcionalidad_ID) VALUES (" + rol.ID + ", " + unaFuncionalidad.ID + ")";
                db.executeNonQuery(sql);
            }

        }
    }
}
