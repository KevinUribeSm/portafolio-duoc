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
    public class DatosCrearTareas
    {
        OracleConnection con = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE))); User ID = Portafolio; Password = Portafolio; ");


        public DataTable listarProcesos(UsuarioLog usuarioLog)
        {

            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_PROCESO_ACTIVO", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@RUT", OracleDbType.Varchar2).Value = usuarioLog.UserLog;
            cmd.Parameters.Add("CURSOR_SALIDA", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow row = dt.NewRow();
            row["ID_PROCESO"] = 0;
            row["NOM_PROCESO"] = "SELECCIONE";
            dt.Rows.InsertAt(row, 0);
            con.Close();
            return dt;
 
        }

        public DataTable listarUsuariosAsignar(UsuarioLog usuarioLog)
        {

            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_USU_ASIG_TARE", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@RUT", OracleDbType.Varchar2).Value = usuarioLog.UserLog;
            cmd.Parameters.Add("CUR_LISTAR_USU_ASIG_TARE", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow row = dt.NewRow();
            row["RUT"] = 0;
            row["NOMBRE_USUARIO"] = "SELECCIONE";
            dt.Rows.InsertAt(row, 0);
            con.Close();
            return dt;

        }

        public DataTable listarUsuariosAsignar2(String usuarioLog, string rutRespnsable, string nomResponsanble)
        {

            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_USU_ASIG_TARE", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@RUT", OracleDbType.Varchar2).Value = usuarioLog;
            cmd.Parameters.Add("CUR_LISTAR_USU_ASIG_TARE", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow row = dt.NewRow();
            row["RUT"] = rutRespnsable;
            row["NOMBRE_USUARIO"] = nomResponsanble;
            dt.Rows.InsertAt(row, 0);
            con.Close();
            return dt;

        }

        public ResultadoDTO insertTareas(EntidadTareas eTareas)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_INSERT_TAREA", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("P_NOMBRE_TAREA", OracleDbType.Varchar2).Value = eTareas.Nombre_tarea;
            cmd.Parameters.Add("P_FECHA_PROCESO", OracleDbType.Date).Value = eTareas.Fecha_proceso;
            cmd.Parameters.Add("P_FECHA_FIN", OracleDbType.Date).Value = eTareas.Fecha_fin;
            cmd.Parameters.Add("P_DESCRIPCION_TAREA", OracleDbType.Varchar2).Value = eTareas.Descripcion_tarea;
            //cmd.Parameters.Add("P_ESTADO_TAREA", OracleDbType.Varchar2).Value = eTareas.Estado_tarea;
            //cmd.Parameters.Add("P_FECHA_TERMINO_REAL", OracleDbType.Varchar2).Value = null;
            //cmd.Parameters.Add("P_PORCENTAJE", OracleDbType.Int16).Value = eTareas.Porcentaje;
            cmd.Parameters.Add("P_ID_PROCESO", OracleDbType.Varchar2).Value = eTareas.Id_proceso;
            cmd.Parameters.Add("P_ID_SUB_TAREA", OracleDbType.Varchar2).Value = null;
            cmd.Parameters.Add("P_RUT_ASIGNADO", OracleDbType.Varchar2).Value = eTareas.Rut_asignado_tarea;
            cmd.Parameters.Add("P_RUT_CREADOR_TARE", OracleDbType.Varchar2).Value = eTareas.Rut_creador_tarea;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                r.obj1 = dr;


            }
            else
            {
                r.Ok = false;
                r.mensaje = "TAREA CREADA EXITOSAMENTE";
            }
            con.Close();
            return r;
        }

        public DataTable listarTareas(UsuarioLog usuarioLog)
        {

            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_TAREAXUSUCREA", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@P_RUT", OracleDbType.Varchar2).Value = usuarioLog.UserLog;
            cmd.Parameters.Add("CUR_LISTAR_TAREAXUSU", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            con.Close();
            return tabla;


        }

        public void updatePorcentajeTarea()
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_UPDATE_PORC", con);
            cmd.Parameters.Add("@P_NUMERO", OracleDbType.Int16).Value = 1;
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataReader dr = cmd.ExecuteReader();
            //OracleDataAdapter adaptador = new OracleDataAdapter();
            //adaptador.SelectCommand = cmd;
            con.Close();
        }

        public DataTable misTareasReportadas(string id_tarea)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_REPORTESXTAREA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@P_ID_TAREA", OracleDbType.Varchar2).Value = id_tarea;
            cmd.Parameters.Add("CUR_LISTAR_TAREAXUSU", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            con.Close();
            return tabla;
        }

        public ResultadoDTO InsertReporte(string observacion, string id_tarea)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_INSERT_REPORTE", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@P_ID_TAREA", OracleDbType.Varchar2).Value = observacion;
            cmd.Parameters.Add("@P_PORCENTAJE", OracleDbType.Varchar2).Value = id_tarea;


            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                r.obj1 = dr;
            }
            else
            {
                r.Ok = false;
                r.mensaje = "Reporte Creado";
            }
            con.Close();
            return r;
        }

        public DataTable misTareas(string rut)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_TAREAXUSU", con);
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


        public ResultadoDTO FinalizarTarea(string id, int porcentaje, DateTime fecha)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_FINALIZAR_TAREA", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@P_ID_TAREA", OracleDbType.Varchar2).Value = id;
            cmd.Parameters.Add("@P_PORCENTAJE", OracleDbType.Int32).Value = porcentaje;
            cmd.Parameters.Add("@P_FECHA_TERMINO_REAL", OracleDbType.Date).Value = fecha;


            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                r.obj1 = dr;
            }
            else
            {
                r.Ok = false;
                r.mensaje = "Tarea finalizada";
            }
            con.Close();
            return r;
        }

        public ResultadoDTO UpdataTareaReport(string id)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_REPORTAR_TAREA", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@P_ID_TAREA", OracleDbType.Varchar2).Value = id;


            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                r.obj1 = dr;
            }
            else
            {
                r.Ok = false;
                r.mensaje = "Tarea Reportada";
            }
            con.Close();
            return r;
        }

        public DataTable listarTareasReportadasCreador(string rutCreador)
        {
           
                con.Open();
                OracleCommand cmd = new OracleCommand("SP_LISTAR_TAREA_DEVU", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@P_RUT_CREADOR_TARE", OracleDbType.Varchar2).Value = rutCreador;
                cmd.Parameters.Add("LISTAR_TAREA_DEVU", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                con.Close();
                return tabla;
            

        }

        public DataTable listarSubTareasReportadasCreador(string rutCreador)
        {

            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_SUBTAREA_DEVU", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@P_RUT_CREADOR_TARE", OracleDbType.Varchar2).Value = rutCreador;
            cmd.Parameters.Add("LISTAR_TAREA_DEVU", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            con.Close();
            return tabla;


        }

        public ResultadoDTO FinalizarTarea(string id)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_FINALIZAR_TAREA", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@P_ID_TAREA", OracleDbType.Varchar2).Value = id;


            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                r.obj1 = dr;
            }
            else
            {
                r.Ok = false;
                r.mensaje = "Tarea finalizada";
            }
            con.Close();
            return r;
        }

        public void editarTareas(EntidadTareas eTareas, string idTarea)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_UPDATE_TAREA", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("P_ID_TAREA", OracleDbType.Varchar2).Value = idTarea;
            cmd.Parameters.Add("P_NOMBRE_TAREA", OracleDbType.Varchar2).Value = eTareas.Nombre_tarea;
            cmd.Parameters.Add("P_DESCRIPCION_TAREA", OracleDbType.Varchar2).Value = eTareas.Descripcion_tarea;
            cmd.Parameters.Add("P_FECHA_PROCESO", OracleDbType.Date).Value = eTareas.Fecha_proceso;
            cmd.Parameters.Add("P_FECHA_FIN", OracleDbType.Date).Value = eTareas.Fecha_fin;
            cmd.Parameters.Add("P_RUT_ASIGNADO", OracleDbType.Varchar2).Value = eTareas.Rut_asignado_tarea;
            OracleDataReader dr = cmd.ExecuteReader();
            con.Close();
        }


        public void FinalizarReporte(string id_tarea)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_CERRAR_REPORTE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@P_ID_TAREA", OracleDbType.Varchar2).Value = id_tarea;
            OracleDataReader dr = cmd.ExecuteReader();
            con.Close();
           
        }


    }




}
