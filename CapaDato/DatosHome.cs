using CapaDatos;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
   public class DatosHome
    {
        OracleConnection con = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE))); User ID = Portafolio; Password = Portafolio; ");



    
            public DataTable NombreUsuario(string rut)
            {

                con.Open();
                OracleCommand cmd = new OracleCommand("SP_LISTAR_NOMBRE", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@P_RUT", OracleDbType.Varchar2).Value = rut;
                cmd.Parameters.Add("CUR_LISTAR_NOMBRE", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;
                OracleDataAdapter adp = new OracleDataAdapter();
                adp.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adp.Fill(tabla);
                con.Close();
                return tabla;

            }
        }


    
}
