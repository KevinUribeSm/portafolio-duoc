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
    public class NegocioSubTarea
    {
        DatosSubTareas subTask = new DatosSubTareas();
        public ResultadoDTO insertTareas(EntidadSubTarea subTareas)
        {
            return subTask.insertSubTareas(subTareas);
        }

        public DataTable listarSubTareas(string  idTarea)
        {
            return subTask.listarSubTareas(idTarea);
        }

        public void eliminarSubtareas(string idSubtarea)
        {
            subTask.eliminarSubtareas(idSubtarea);
        }

        public void editarSubTareas(EntidadSubTarea eSubTarea, string idSubTarea)
        {
            subTask.editarSubTareas(eSubTarea,idSubTarea);
        }
    }
}
