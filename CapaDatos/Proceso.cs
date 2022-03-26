using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class Proceso
    {

        private string nom_proceso;
        private string desc_proceso;
        private DateTime fecha_ini;
        private DateTime fecha_fin;
        private DateTime fecha_termino_real;
        private string estado_proceso;
        private string rut_creador;

        public string Nom_proceso { get => nom_proceso; set => nom_proceso = value; }
        public string Desc_proceso { get => desc_proceso; set => desc_proceso = value; }
        public DateTime Fecha_ini { get => fecha_ini; set => fecha_ini = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public DateTime Fecha_termino_real { get => fecha_termino_real; set => fecha_termino_real = value; }
        public string Estado_proceso { get => estado_proceso; set => estado_proceso = value; }
        public string Rut_creador { get => rut_creador; set => rut_creador = value; }
    }
}
