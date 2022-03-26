using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test_1
{
    public partial class MiDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioLogueado"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            string usuarioLogin = Session["usuarioLogueado"].ToString();
            NegocioCrearTareas tareas = new NegocioCrearTareas();
            NegocioAcceso nAcceso = new NegocioAcceso();
            string id_privilegio = "3";
            DataTable accesos = nAcceso.validaAcceso(usuarioLogin, id_privilegio);
            if (accesos.Rows.Count == 0)
            {
                Response.Redirect("SinAcceso.aspx");

            }else if(!IsPostBack)
            {

            }




        }

        protected string obtenerData()
        {
            string usuarioLogin = Session["usuarioLogueado"].ToString();
            NegocioDashboard nDashboard = new NegocioDashboard();
            DataTable datable = new DataTable();
            DataTable data = nDashboard.misTareasDashboard(usuarioLogin);
            DataTableReader reader = data.CreateDataReader();

            datable.Load(reader);

            DataTable table = new DataTable();

            string strDatos;

            strDatos = "[['N1', 'N2'],";

            foreach (DataRow dr in data.Rows)
            {
                strDatos = strDatos + "[";
                strDatos = strDatos + "'" + dr[0] + "'" + "," + dr[1];
                strDatos = strDatos + "],";
            }

            strDatos = strDatos + "]";

            return strDatos;
        }

        public string dataPorcentajeTareasUsuario()
        {
            string rut = Session["usuarioLogueado"].ToString();

            NegocioDashboard dashboard = new NegocioDashboard();
            DataTable data = dashboard.porcentajeTareaUsuario(rut);

            DataTable table = new DataTable();

            DataTableReader reader = data.CreateDataReader();

            table.Load(reader);

            string strDatos;

            strDatos = "[['Rut Empresa', 'Nombre','Total Tareas','Tareas Terminados'," +
                "'Tareas Pendientes','% Terminados','% Pendientes','% Termino Atrasado'],";

            foreach (DataRow dr in data.Rows)
            {
                strDatos = strDatos + "[";
                strDatos = strDatos + "'" + dr[0] + "'" + "," + "'" + dr[1] + "'" + "," + "'" + dr[2] + "'" + "," + "'" + dr[3]
                 + "'" + "," + "'" + dr[4] + "'" + "," + "'" + dr[5] + "%'" + "," + "'" + dr[6] + "%'" + "," + "'" + dr[7] + "%'";
                strDatos = strDatos + "],";
            }

            strDatos = strDatos + "]";

            return strDatos;
        }


    }
}