using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.Dominio;
using System.Data.SqlClient;
using FrbaBus.Mensajes;
using System.Security.Cryptography;
using FrbaBus.Dao;

namespace FrbaBus
{
    public class UsuarioDAO
    {
        private static UsuarioDAO INSTANCIA = null;

        private UsuarioDAO() { 
        }

        //Singleton
        public static UsuarioDAO getInstance()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new UsuarioDAO();
            }

            return INSTANCIA;
        }



        public Usuario login(String username, String password)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            Usuario usuario = null;
            string passwordHash = this.toSHA256(password);
            String sql;

            /*
            String sql = "exec SENIOR_DEVELOPERS.SP_preLogin @username = '" + username + "', @password = '" + passwordHash + "'";
            db.executeNonQuery(sql);
            */

            sql = "SELECT username, password, intentosFallidos, habilitado, rol_ID ";
            sql += "FROM SENIOR_DEVELOPERS.Usuario ";
            sql += "WHERE username = '" + username + "' AND password = '" + passwordHash + "' ";
            sql += "AND habilitado = 'Si'";

            SqlDataReader reader = db.executeReader(sql);

            if (reader.Read())
            {
                usuario = new Usuario();
                usuario.username = (String)reader["username"];
                usuario.password = (String)reader["password"];
                usuario.intentosFallidos = (int)reader["intentosFallidos"];
                usuario.habilitado = true;

                Rol rolUsuario = new Rol();
                rolUsuario.ID = (int)reader["rol_ID"];
                usuario.rol = rolUsuario;
            }
            reader.Close();

            return usuario;
        }


        private String toSHA256(String palabra)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(palabra));
            String palabraHash = byteArrayToString(hashedDataBytes);

            return palabraHash;
        }


        private string byteArrayToString(byte[] inputArray)
        {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++)
            {
                output.Append(inputArray[i].ToString("X2"));
            }
            return output.ToString();
        }


    }
}
