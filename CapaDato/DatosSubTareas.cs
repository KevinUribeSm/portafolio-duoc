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
   public class DatosSubTareas
    {

        OracleConnection con = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE))); User ID = Portafolio; Password = Portafolio; ");

        public ResultadoDTO insertSubTareas(EntidadSubTarea eSubTarea)
        {
            ResultadoDTO r = new ResultadoDTO() { Ok = true };
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_INSERT_SUBTAREA", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("NOMBRE_TAREA", OracleDbType.Varchar2).Value = eSubTarea.NomSubTarea;
            cmd.Parameters.Add("FECHA_PROCESO", OracleDbType.Date).Value = eSubTarea.Fecha_inicio;
            cmd.Parameters.Add("FECHA_FIN", OracleDbType.Date).Value = eSubTarea.Fecha_fin;
            cmd.Parameters.Add("DESCRIPCION_TAREA", OracleDbType.Varchar2).Value = eSubTarea.DescripcionSubTarea;
            //cmd.Parameters.Add("P_ESTADO_TAREA", OracleDbType.Varchar2).Value = eTareas.Estado_tarea;
            //cmd.Parameters.Add("P_FECHA_TERMINO_REAL", OracleDbType.Varchar2).Value = null;
            //cmd.Parameters.Add("P_PORCENTAJE", OracleDbType.Int16).Value = eTareas.Porcentaje;
            cmd.Parameters.Add("ID_PROCESO", OracleDbType.Varchar2).Value = eSubTarea.IdProceso;
            cmd.Parameters.Add("ID_TAREA_PADRE", OracleDbType.Varchar2).Value = eSubTarea.IdTareaPadre;
            cmd.Parameters.Add("RUT_ASIGNADO", OracleDbType.Varchar2).Value = eSubTarea.RutAsignado;
            cmd.Parameters.Add("RUT_CREADOR_TARE", OracleDbType.Varchar2).Value = eSubTarea.RutCreadorTarea;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                r.obj1 = dr;


            }
            else
            {
                r.Ok = false;
                r.mensaje = "SUB TAREA CREADA EXITOSAMENTE";
            }
            con.Close();
            return r;
        }

        public DataTable listarSubTareas(string idTarea)
        {

            con.Open();
            OracleCommand cmd = new OracleCommand("SP_LISTAR_SUBTAREA", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@P_ID_TAREA_PADRE", OracleDbType.Varchar2).Value = idTarea;
            cmd.Parameters.Add("CUR_LISTAR_TAREAXUSU", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            con.Close();
            return tabla;


        }

        public void eliminarSubtareas(string idSubtarea)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_DELETE_SUBTAREA", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("P_ID_TAREA", OracleDbType.Varchar2).Value = idSubtarea;
            OracleDataReader dr = cmd.ExecuteReader();
            con.Close();
        }


        public void editarSubTareas(EntidadSubTarea eSubTarea, string idSubTarea)
        {
            con.Open();
            OracleCommand cmd = new OracleCommand("SP_UPDATE_TAREA", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("P_ID_TAREA", OracleDbType.Varchar2).Value = idSubTarea;
            cmd.Parameters.Add("P_NOMBRE_TAREA", OracleDbType.Varchar2).Value = eSubTarea.NomSubTarea;
            cmd.Parameters.Add("P_DESCRIPCION_TAREA", OracleDbType.Varchar2).Value = eSubTarea.DescripcionSubTarea;
            cmd.Parameters.Add("P_FECHA_PROCESO", OracleDbType.Date).Value = eSubTarea.Fecha_inicio;
            cmd.Parameters.Add("P_FECHA_FIN", OracleDbType.Date).Value = eSubTarea.Fecha_fin;
            cmd.Parameters.Add("P_RUT_ASIGNADO", OracleDbType.Varchar2).Value = eSubTarea.RutAsignado;
            OracleDataReader dr = cmd.ExecuteReader();
            con.Close();
        }
    }
}
