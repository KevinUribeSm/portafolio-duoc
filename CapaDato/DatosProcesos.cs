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
    public class DatosProcesos
    {
        OracleConnection con = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE))); User ID = Portafolio; Password = Portafolio; ");

        public ResultadoDTO validarInsProceso(string nom_proceso, string desc_proceso,
            DateTime fecha_ini, DateTime fecha_fin, string rut_creador)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_INSERT_PROCESO", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@NOMBRE", OracleDbType.Varchar2).Value = nom_proceso;
            cmd.Parameters.Add("@DES_PROCESO", OracleDbType.Varchar2).Value = desc_proceso;
            cmd.Parameters.Add("@FECHA_INICIO", OracleDbType.Date).Value = fecha_ini;
            cmd.Parameters.Add("@FECHA_FIN", OracleDbType.Date).Value = fecha_fin;
            cmd.Parameters.Add("@FECHA_TERMINO_REAL", OracleDbType.Date).Value = null;
            //  cmd.Parameters.Add("@ESTADO_PROCESO", OracleDbType.Varchar2).Value = estado_proceso;
            cmd.Parameters.Add("@RUT_CREADOR", OracleDbType.Varchar2).Value = rut_creador;

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                r.obj1 = dr;
            }
            else
            {
                r.Ok = false;
                r.mensaje = "Se agrego el proceso";
            }
            con.Close();
            return r;

        }



        public DataTable listarProceso(string rut_creador)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_PROCESO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@RUT_CREADOR", OracleDbType.Varchar2).Value = rut_creador;
            cmd.Parameters.Add("CURSOR_SALIDA", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            con.Close();
            return tabla;

        }


        public ResultadoDTO UpdateProceso(string nom_proceso, string desc_proceso,
                 string id_proceso, DateTime fecha_inicio, DateTime fecha_fin)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_UPDATE_PROCESO", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NOMBRE", OracleDbType.Varchar2).Value = nom_proceso;
            cmd.Parameters.Add("@DES_PROCESO", OracleDbType.Varchar2).Value = desc_proceso;
            cmd.Parameters.Add("@ID_PROCESO", OracleDbType.Varchar2).Value = id_proceso;
            cmd.Parameters.Add("@P_FECHA_INICIO", OracleDbType.Date).Value = fecha_inicio;
            cmd.Parameters.Add("@P_FECHA_FIN", OracleDbType.Date).Value = fecha_fin;


            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                r.obj1 = dr;
            }
            else
            {
                r.Ok = false;
                r.mensaje = "Se actualizó el proceso";
            }
            con.Close();
            return r;
        }


        public ResultadoDTO deleteProceso(string id_proceso)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_UPDATE_PROCESO_ESTADO", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ID_PROCESO", OracleDbType.Varchar2).Value = id_proceso;

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                r.obj1 = dr;
            }
            else
            {
                r.Ok = false;
                r.mensaje = "Se actualizó el proceso";
            }
            con.Close();
            return r;
        }

        public ResultadoDTO finalizarProceso(string id_proceso)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_FINALIZAR_PROCESO", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@P_ID_PROCESO", OracleDbType.Varchar2).Value = id_proceso;

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                r.obj1 = dr;
            }
            else
            {
                r.Ok = false;
                r.mensaje = "Se finalizó el proceso";
            }
            con.Close();
            return r;
        }

        public ResultadoDTO activarProceso(string id_proceso)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_ACTIVAR_PROCESO", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@P_ID_PROCESO", OracleDbType.Varchar2).Value = id_proceso;

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                r.obj1 = dr;
            }
            else
            {
                r.Ok = false;
                r.mensaje = "Se activo el proceso";
            }
            con.Close();
            return r;
        }

    }

}
