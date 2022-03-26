using CapaDatos;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDato
{
    public class DatosLogin
    {
        OracleConnection con = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE))); User ID = Portafolio; Password = Portafolio; ");

        public ResultadoDTO validaLogin(string user, string pass)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LOG_WEB", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@RUT", OracleDbType.Varchar2).Value = user;
            cmd.Parameters.Add("@CLAVE", OracleDbType.Varchar2).Value = pass;
            cmd.Parameters.Add("x_salida", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {

                r.obj1 = dr;
                

            }
            else
            {
                r.Ok = false;
                r.mensaje = "Usuario o clave incorrecta";
            }
            con.Close();
            return r;



        }

    }
}
