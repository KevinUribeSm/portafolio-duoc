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
    public class NegocioDashboard
    {

        DatosDashboard dashboard = new DatosDashboard();

        public DataTable tareasEmpresa()
        {
            return dashboard.tareasEmpresa();
        }

        public DataTable listarEmpresas()
        {
            return dashboard.listarEmpresas();
        }

        public DataTable listaPorcentajeProceso()
        {
            return dashboard.porcentajeProceso();
        }

        public DataTable porcentajeTarea(string rut_empresa)
        {
            return dashboard.porcentajeTarea(rut_empresa);
        }

        public DataTable porcentajeTareaUsuario(string rut)
        {
            return dashboard.porcentajeTareaUsuario(rut);
        }

        public DataTable misTareasDashboard(string rut)
        {
            return dashboard.misTareasDashboard(rut);
        }

    }
}

