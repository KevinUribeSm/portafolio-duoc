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

    public class DatosDashboard
    {

        OracleConnection con = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE))); User ID = Portafolio; Password = Portafolio; ");

        public DataTable tareasEmpresa()
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_TAREASEMPRESA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CURSOR_SALIDA", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            con.Close();
            return tabla;

        }

        public DataTable listarEmpresas()
        {

            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTA_EMPRESA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("CURSOR_SALIDA", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow row = dt.NewRow();
            row["RUT_EMPRESA"] = 0;
            row["NOMBRE_EMPRESA"] = "SELECCIONE";
            dt.Rows.InsertAt(row, 0);
            con.Close();
            return dt;

        }


        public DataTable porcentajeProceso()
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_PORC_PROCESO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("LISTAR_PORC_PROCESO", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            con.Close();
            return tabla;

        }

        public DataTable porcentajeTarea(string rut_empresa)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_PORC_TAREA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@P_RUT_EMPRESA", OracleDbType.Varchar2).Value = rut_empresa;
            cmd.Parameters.Add("LISTAR_PORC_TAREA", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            con.Close();
            return tabla;

        }

        public DataTable porcentajeTareaUsuario(string rut)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_PORC_TAREAXUSU", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@P_RUT", OracleDbType.Varchar2).Value = rut;
            cmd.Parameters.Add("LISTAR_PORC_TAREAXUSU", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            con.Close();
            return tabla;
        }

        public DataTable misTareasDashboard(string rut)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_TAREAXDASH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@P_RUT", OracleDbType.Varchar2).Value = rut;
            cmd.Parameters.Add("CUR_LISTAR_TAREAXUSU", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            con.Close();
            return tabla;

        }



    }
}