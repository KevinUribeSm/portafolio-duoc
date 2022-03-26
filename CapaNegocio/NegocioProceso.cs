using CapaDato;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NegocioProceso
    {

        public NegocioProceso()
        {

        }

        DatosProcesos dataProceso = new DatosProcesos();



        public ResultadoDTO insProceso(string nom_proceso, string desc_proceso,
        DateTime fecha_ini, DateTime fecha_fin, string rut_creador)
        {
            return dataProceso.validarInsProceso(nom_proceso, desc_proceso, fecha_ini, fecha_fin, rut_creador);
        }

        public DataTable listaProceso(string rut_creador)
        {
            return dataProceso.listarProceso(rut_creador);
        }

        public ResultadoDTO updateProcesos(string nom_proceso, string desc_proceso
             , string id_proceso, DateTime fecha_inicio, DateTime fecha_fin)
        {
            return dataProceso.UpdateProceso(nom_proceso, desc_proceso, id_proceso, fecha_inicio, fecha_fin);
        }

        public ResultadoDTO finalizarProceso(string id_proceso)
        {
            return dataProceso.finalizarProceso(id_proceso);
        }

        public ResultadoDTO activarProceso(string id_proceso)
        {
            return dataProceso.activarProceso(id_proceso);
        }
    }
}

