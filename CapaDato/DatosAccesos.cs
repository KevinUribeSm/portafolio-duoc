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
    public class DatosAccesos
    {

        OracleConnection con = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE))); User ID = Portafolio; Password = Portafolio; ");

        public DataTable validaAcceso(string rut,string id_privilegio)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_PERFIL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@P_ID_TAREA", OracleDbType.Varchar2).Value = rut;
            cmd.Parameters.Add("@P_PRIVILEGIO", OracleDbType.Varchar2).Value = id_privilegio;
            cmd.Parameters.Add("CUR_LISTAR_PERFIL", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            con.Close();
            return tabla;

        }
    }
}
