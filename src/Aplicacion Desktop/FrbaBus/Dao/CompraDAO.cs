using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaBus.Dominio;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;
using FrbaBus.Compra_de_Pasajes;

namespace FrbaBus.Dao
{
    class CompraDAO
    {
        private CompraDAO()
        { }

        private static CompraDAO INSTANCIA;

        //Singleton
        public static CompraDAO getInstance()
        {
            if (INSTANCIA == null)
            {
                INSTANCIA = new CompraDAO();
            }

            return INSTANCIA;
        }

        public void realizarDevolucion(int nroCompra, String motivo, List<Pasaje> pasajes, List<Encomienda> encomiendas)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "begin transaction ";
            sql += "begin try ";
            sql += "exec SENIOR_DEVELOPERS.SP_agregarDevolucion @nroCompra = "+nroCompra+", @motivo = '"+motivo+"' ";

            foreach (Pasaje unPasaje in pasajes)
            {
                sql += "exec SENIOR_DEVELOPERS.SP_agregarPasajeDeDevolucion @nroPasaje = "+unPasaje.ID+", @compraNro = "+nroCompra+" ";
            }

            foreach (Encomienda unaEncomienda in encomiendas)
            {
                sql += "exec SENIOR_DEVELOPERS.SP_agregarEncomiendaDeDevolucion @nroEncomienda = " + unaEncomienda.ID + ", @compraNro = " + nroCompra + " ";
            }
            
            sql += "commit ";
            sql += "end try ";
            sql += "begin catch ";
            sql += "declare @ErrorMessage nvarchar(4000) declare @ErrorSeverity int declare @ErrorState int SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE() RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState) ";
            sql += "end catch";
            db.executeNonQuery(sql);

        }


        public void realizarDevolucionPasaje(int nroDevolucion, int nroPasaje)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            Pasaje pasaje = this.getPasaje(nroPasaje);
            
            if (pasaje == null)
            {
                throw new SystemException("El pasaje no existe.");
            }

            
            sql = "INSERT INTO SENIOR_DEVELOPERS.CancelacionPasaje ";
            sql += "(cancelacion_ID, pasaje_ID, viaje_ID, cliente_DNI, precio, compra_NRO, butaca_NRO) ";
            sql += "VALUES ";
            sql += "(" + nroDevolucion + ", " + nroPasaje + ", " + pasaje.viajeID + ", " + pasaje.clienteDNI + ", " + pasaje.precio.ToString(CultureInfo.InvariantCulture) + ", " + pasaje.compraNRO + ", " + pasaje.butacaNRO + ")";

            db.executeNonQuery(sql);
            
            sql = "DELETE FROM SENIOR_DEVELOPERS.Pasaje WHERE ID = " + nroPasaje;
            db.executeNonQuery(sql);
        }

        public void realizarDevolucionEncomienda(int nroDevolucion, int nroEncomienda)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            Encomienda encomienda = this.getEncomienda(nroEncomienda);

            if (encomienda == null)
            {
                throw new SystemException("La encomienda no existe.");
            }


            sql = "INSERT INTO SENIOR_DEVELOPERS.CancelacionEncomienda ";
            sql += "(cancelacion_ID, pasaje_ID, viaje_ID, cliente_DNI, precio, compra_NRO, KG) ";
            sql += "VALUES ";
            sql += "(" + nroDevolucion + ", " + nroEncomienda + ", " + encomienda.viajeID + ", " + encomienda.clienteDNI + ", " + encomienda.precio.ToString(CultureInfo.InvariantCulture) + ", " + encomienda.compraNRO + ", " + encomienda.Kg + ")";

            db.executeNonQuery(sql);

            sql = "DELETE FROM SENIOR_DEVELOPERS.Encomienda WHERE ID = " + nroEncomienda;
            db.executeNonQuery(sql);
        }

        private Encomienda getEncomienda(int nroEncomienda)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "SELECT ID, viaje_ID, cliente_DNI, precio, compra_NRO, KG FROM SENIOR_DEVELOPERS.Encomienda WHERE ID = " + nroEncomienda;
            SqlDataReader reader = db.executeReader(sql);

            Encomienda encomienda = new Encomienda();
            reader.Read();

            encomienda.ID = nroEncomienda;
            encomienda.viajeID = (int)reader["viaje_ID"];
            encomienda.clienteDNI = Convert.ToInt64(reader["cliente_DNI"]);
            encomienda.precio = Convert.ToDouble(reader["precio"]);
            encomienda.compraNRO = (int)reader["compra_NRO"];
            encomienda.Kg = Convert.ToInt32(reader["KG"]);

            reader.Close();

            return encomienda;
        }


        private Pasaje getPasaje(int nroPasaje)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "SELECT ID, viaje_ID, cliente_DNI, precio, compra_NRO, butaca_NRO FROM SENIOR_DEVELOPERS.Pasaje WHERE ID = " + nroPasaje;
            SqlDataReader reader = db.executeReader(sql);
            
            Pasaje pasaje = new Pasaje();
            reader.Read();
            
            pasaje.ID = nroPasaje;
            pasaje.viajeID = (int)reader["viaje_ID"];
            pasaje.clienteDNI = Convert.ToInt64(reader["cliente_DNI"]);
            pasaje.precio = Convert.ToDouble(reader["precio"]);
            pasaje.compraNRO = (int)reader["compra_NRO"];
            pasaje.butacaNRO = Convert.ToInt32(reader["butaca_NRO"]);

            reader.Close();
            
            return pasaje;
        }

        public DataTable getDestinosConMasPasajesComprados(int anio, int semestre)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            /*
            sql = "SELECT TOP 5 Destino, COUNT(*) AS 'Cantidad de pasajes comprados' ";
            sql += "FROM SENIOR_DEVELOPERS.V_DestinosPasajes ";
            sql += "WHERE YEAR(Fecha) = " + anio + " ";
            sql += "AND SENIOR_DEVELOPERS.FN_fechaEsDeSemestre(Fecha) = " + semestre + " ";
            sql += "GROUP BY Destino ";
            sql += "ORDER BY 'Cantidad de pasajes comprados' DESC";
            */

            sql = "select Destino, Cantidad from SENIOR_DEVELOPERS.FN_ListadoDestinosConMasPasajesComprados(" + anio + ", " + semestre + ")";

            DataTable tabla = db.obtenerComoTabla(sql);

            return tabla;
            
        }

        public DataTable getDestinosConMicrosMasVacios(int anio, int semestre)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            /*
            sql = "SELECT TOP 5 Destino, Fecha, Micro, [Porcentaje lleno] ";
            sql += "FROM SENIOR_DEVELOPERS.V_MicrosPorcentajeLleno ";
            sql += "WHERE ";
            sql += "YEAR(Fecha) = " + anio + " ";
            sql += "AND SENIOR_DEVELOPERS.FN_fechaEsDeSemestre(Fecha) = " + semestre + " ";
            sql += "ORDER BY [Porcentaje lleno] ASC";
            */

            sql = "select Destino, Fecha, Micro, Porcentaje_Lleno from SENIOR_DEVELOPERS.FN_ListadoDestinosConMicrosMasVacios(" + anio + ", " + semestre + ")";

            DataTable tabla = db.obtenerComoTabla(sql);

            return tabla;
 
        }

        public DataTable getDestinosConMasPasajesCancelados(int anio, int semestre)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;
            /*
            sql = "SELECT TOP 5 Destino, COUNT(*) AS 'Cantidad de pasajes cancelados' ";
            sql += "FROM SENIOR_DEVELOPERS.V_DestinoPasajeCancelado ";
            sql += "WHERE YEAR(Fecha) = " + anio + " ";
            sql += "AND SENIOR_DEVELOPERS.FN_fechaEsDeSemestre(Fecha) = " + semestre + " ";
            sql += "GROUP BY Destino ";
            sql += "ORDER BY 'Cantidad de pasajes cancelados' DESC";
            */
            sql = "select Destino, Cantidad_de_pasajes_cancelados from SENIOR_DEVELOPERS.FN_ListadoDestinosConMasPasajesCancelados(" + anio + ", " + semestre + ")";

            DataTable tabla = db.obtenerComoTabla(sql);

            return tabla;
 
        }

        public double calcularPrecioPasaje(int viajeID)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "SELECT R.precioBasePasaje * S.porcentajeAdicional ";
            sql += "FROM SENIOR_DEVELOPERS.Viaje V ";
            sql += "INNER JOIN SENIOR_DEVELOPERS.Recorrido R ON R.ID = V.recorrido_ID ";
            sql += "INNER JOIN SENIOR_DEVELOPERS.Servicio S ON S.nombre = R.tipoServicio ";
            sql += "WHERE V.ID = " + viajeID;    
               
            double precio = Convert.ToDouble(db.executeScalar(sql));

            return precio;
        }

        public double calcularPrecioEncomienda(int viajeID, int kg)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "SELECT R.precioBaseKG ";
            sql += "FROM SENIOR_DEVELOPERS.Viaje V ";
            sql += "INNER JOIN SENIOR_DEVELOPERS.Recorrido R ON R.ID = V.recorrido_ID ";
            sql += "WHERE V.ID = " + viajeID;

            double precio = kg * Convert.ToDouble(db.executeScalar(sql));

            return precio;
        }

        public void guardarDatosTarjeta(Tarjeta tarjeta)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "insert into SENIOR_DEVELOPERS.TarjetaCredito ";
            sql += "(NRO, cliente_DNI, codigoSeguridad, fechaVencimiento, tipo) ";
            sql += "values ";
            sql += "("+ tarjeta.numero +", "+ tarjeta.clienteDNI +", '"+ tarjeta.codigoSeguridad +"', "+ tarjeta.vencimiento +", '"+ tarjeta.tipo +"')";
        
            db.executeNonQuery(sql);
        }


        public int efectuarCompra(Compra compra, int viajeID, List<Pasaje> pasajes, List<Encomienda> encomiendas)
        {
            String sql;
            BaseDeDatos db = BaseDeDatos.Instance;
            
            sql = "select MAX(NRO)+1 from SENIOR_DEVELOPERS.RegistroCompra";
            int nroCompra = Convert.ToInt32(db.executeScalar(sql));

            sql = "begin try ";
            sql += "begin transaction ";
            sql += "exec SENIOR_DEVELOPERS.SP_insertarCompra @clienteDNI = "+ compra.clienteDNI +", @medioPago = '"+ compra.medioPago +"' ";

            foreach (Pasaje unPasaje in pasajes)
            {
                sql += "EXEC SENIOR_DEVELOPERS.SP_guardarPasaje ";
                sql += "@viajeID = " + viajeID + ", @clienteDNI = " + unPasaje.clienteDNI + ", @compraNro = " + nroCompra + ", @butacaNro = " + unPasaje.butacaNRO + " ";
            }

            foreach (Encomienda unaEncomienda in encomiendas)
            {
                sql += "EXEC SENIOR_DEVELOPERS.SP_guardarEncomienda ";
                sql += "@viajeID = " + viajeID + ", @clienteDNI = " + unaEncomienda.clienteDNI + ", @compraNro = " + nroCompra + ", @kg = " + unaEncomienda.Kg + " ";
            }
            sql += "commit ";
            sql += "end try ";
            sql += "begin catch ";
            sql += "declare @ErrorMessage nvarchar(4000) declare @ErrorSeverity int declare @ErrorState int SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE() RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState) ";
            sql += "end catch";


            db.executeNonQuery(sql);
            
            return nroCompra;

        }

        private void guardarPasajes(List<Pasaje> pasajes, int numeroCompra, int viajeID)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            foreach (Pasaje unPasaje in pasajes)
            {
                sql = "EXEC SENIOR_DEVELOPERS.SP_guardarPasaje ";
                sql += "@viajeID = " + viajeID + ", @clienteDNI = " + unPasaje.clienteDNI + ", @precio = " + unPasaje.precio.ToString(CultureInfo.InvariantCulture) + ", @compraNro = " + numeroCompra + ", @butacaNro = " + unPasaje.butacaNRO;
                
                db.executeNonQuery(sql);
            }
        }


        private void guardarEncomiendas(List<Encomienda> encomiendas, int numeroCompra, int viajeID)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            foreach (Encomienda unaEncomienda in encomiendas)
            {
                sql = "EXEC SENIOR_DEVELOPERS.SP_guardarEncomienda ";
                sql += "@viajeID = " + viajeID + ", @clienteDNI = " + unaEncomienda.clienteDNI + ", @precio = " + unaEncomienda.precio.ToString(CultureInfo.InvariantCulture) + ", @compraNro = " + numeroCompra + ", @kg = " + unaEncomienda.Kg;
                db.executeNonQuery(sql);            
            }
        }

        

        private int guardarCompra(Compra compra)
        {
            BaseDeDatos db = BaseDeDatos.Instance;
            String sql;

            sql = "SELECT MAX(NRO)+1 FROM SENIOR_DEVELOPERS.RegistroCompra";
            int numeroCompra = (int)db.executeScalar(sql);

            sql = "SET IDENTITY_INSERT SENIOR_DEVELOPERS.RegistroCompra ON";
            db.executeNonQuery(sql);

            sql = "insert into SENIOR_DEVELOPERS.RegistroCompra ";
            sql += "(NRO, cliente_DNI, fecha, medioPago) ";
            sql += "values ";
            sql += "(" + numeroCompra + ", " + compra.clienteDNI + ", GETDATE(), '" + compra.medioPago + "')";

            db.executeNonQuery(sql);
            
            return numeroCompra;
        }

        public double calcularPrecio(Compra compra)
        {
            BaseDeDatos db = BaseDeDatos.Instance;

            String sql = "select SENIOR_DEVELOPERS.FN_calcularPrecio("+ compra.numero +")";

            double total = Convert.ToDouble(db.executeScalar(sql));
            return total;
        }
    }
}
