using CapaDato;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class NegocioCrearTareas
    {

        DatosCrearTareas datosTareas = new DatosCrearTareas();
        public  DataTable listarProcesos(UsuarioLog usuarioLog)
        {
            return datosTareas.listarProcesos(usuarioLog);
        }

        public DataTable listarUsuariosAsignar(UsuarioLog usuarioLog)
        {
            return datosTareas.listarUsuariosAsignar(usuarioLog);
        }

        public DataTable listarUsuariosAsignar2(String usuarioLog, string rutRespnsable, string nomResponsanble)
        {
            return datosTareas.listarUsuariosAsignar2(usuarioLog,rutRespnsable,nomResponsanble);
        }

        public ResultadoDTO insertTareas(EntidadTareas tareas)
        {
           return datosTareas.insertTareas(tareas);
        }

        public DataTable listarTareas(UsuarioLog usuarioLog)
        {
            return datosTareas.listarTareas(usuarioLog);
        }

        public DataTable misTareas(string rut)
        {
            return datosTareas.misTareas(rut);
        }

        public ResultadoDTO UpdataTareaReport(string id)
        {
            return datosTareas.UpdataTareaReport(id);
        }

        public ResultadoDTO FinalizarTarea(string id, int porcentaje, DateTime fecha)
        {
            return datosTareas.FinalizarTarea(id, porcentaje, fecha);
        }


        public ResultadoDTO InsertReporte(string observacion, string id_tarea)
        {
            return datosTareas.InsertReporte(observacion, id_tarea);
        }


        public DataTable misTareasReportadas(string id_tarea)
        {
            return datosTareas.misTareasReportadas(id_tarea);
        }

        public DataTable listarTareasReportadasCreador(string rutCreador)
        {
            return datosTareas.listarTareasReportadasCreador(rutCreador);
        }

        public DataTable listarSubTareasReportadasCreador(string rutCreador)
        {
            return datosTareas.listarSubTareasReportadasCreador(rutCreador);
        }

        public ResultadoDTO FinalizarTarea(string id)
        {
            return datosTareas.FinalizarTarea(id);
        }

        public void actualizaPorcentajeTareas()
        {
            datosTareas.updatePorcentajeTarea();
        }

        public void editarTareas(EntidadTareas eTareas, string idTarea)
        {
            datosTareas.editarTareas(eTareas, idTarea);
        }

        public void FinalizarReporte(string id_tarea)
        {
            datosTareas.FinalizarReporte(id_tarea);
        }
    }


}