using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class EntidadSubTarea
    {
        private String nomSubTarea;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private string descripcionSubTarea;
        private string estadoSubTarea;
        private DateTime fecha_terminoReal;
        private int porcentaje;
        private string idTareaPadre;
        private string rutAsignado;
        private string rutCreadorTarea;
        private string idProceso;

        public string NomSubTarea { get => nomSubTarea; set => nomSubTarea = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public string DescripcionSubTarea { get => descripcionSubTarea; set => descripcionSubTarea = value; }
        public string EstadoSubTarea { get => estadoSubTarea; set => estadoSubTarea = value; }
        public DateTime Fecha_terminoReal { get => fecha_terminoReal; set => fecha_terminoReal = value; }
        public int Porcentaje { get => porcentaje; set => porcentaje = value; }
        public string IdTareaPadre { get => idTareaPadre; set => idTareaPadre = value; }
        public string RutAsignado { get => rutAsignado; set => rutAsignado = value; }
        public string RutCreadorTarea { get => rutCreadorTarea; set => rutCreadorTarea = value; }
        public string IdProceso { get => idProceso; set => idProceso = value; }
    }
}
