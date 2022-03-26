using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EntidadTareas
    {

        private string id_tarea;
        private string nombre_tarea;
        private DateTime fecha_proceso;
        private DateTime fecha_fin;
        private string descripcion_tarea;
        private string estado_tarea;
        private DateTime fecha_termino_real;
        private int porcentaje;
        private string id_proceso;
        private string id_sub_tarea;
        private string rut_creador_tarea;
        private string rut_asignado_tarea;

        public string Id_tarea { get => id_tarea; set => id_tarea = value; }
        public string Nombre_tarea { get => nombre_tarea; set => nombre_tarea = value; }
        public DateTime Fecha_proceso { get => fecha_proceso; set => fecha_proceso = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public string Descripcion_tarea { get => descripcion_tarea; set => descripcion_tarea = value; }
        public string Estado_tarea { get => estado_tarea; set => estado_tarea = value; }
        public DateTime Fecha_termino_real { get => fecha_termino_real; set => fecha_termino_real = value; }
        public int Porcentaje { get => porcentaje; set => porcentaje = value; }
        public string Id_proceso { get => id_proceso; set => id_proceso = value; }
        public string Id_sub_tarea { get => id_sub_tarea; set => id_sub_tarea = value; }
        public string Rut_creador_tarea { get => rut_creador_tarea; set => rut_creador_tarea = value; }
        public string Rut_asignado_tarea { get => rut_asignado_tarea; set => rut_asignado_tarea = value; }
    }
}
