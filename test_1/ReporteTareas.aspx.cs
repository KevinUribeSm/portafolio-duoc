using System;
using CapaDato;
using CapaDatos;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace test_1
{
    public partial class MisTareasReportadas : System.Web.UI.Page
    {

        DatosCrearTareas datosTareas = new DatosCrearTareas();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioLogueado"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            if (!IsPostBack)
                listarTareas();
        }


        private void listarTareas()
        {
            string usuarioLogin = Session["usuarioLogueado"].ToString();
            NegocioCrearTareas tareas = new NegocioCrearTareas();

            string idTarea = Session["idTask"].ToString();

            this.dtlReporte.DataSource = tareas.misTareasReportadas(idTarea);
            dtlReporte.DataBind();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TareasReportadasCreador.aspx");
        }
    }
}