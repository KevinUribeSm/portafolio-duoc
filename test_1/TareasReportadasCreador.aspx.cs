using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace test_1
{
    public partial class TareasReportadasCreador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioLogueado"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            if (!IsPostBack)
            {
                UsuarioLog usuarioLogin = new UsuarioLog();
                usuarioLogin.UserLog = Session["usuarioLogueado"].ToString();
                NegocioCrearTareas nTareas = new NegocioCrearTareas();
                gvdTareasReportadasCreador.DataSource = nTareas.listarTareasReportadasCreador(usuarioLogin.UserLog);
                gvdTareasReportadasCreador.DataBind();

                gdvSubTareasReportadas.DataSource = nTareas.listarSubTareasReportadasCreador(usuarioLogin.UserLog);
                gdvSubTareasReportadas.DataBind();
            }

        }

        protected void gvdTareasReportadasCreador_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "verReporte")
            {
                int index = Convert.ToInt32(e.CommandArgument);


                Session["idTask"] = gvdTareasReportadasCreador.Rows[index].Cells[0].Text;
                Response.Redirect("ReporteTareas.aspx");
            } else if (e.CommandName == "IrTareas")
            {
                Response.Redirect("PantallaListadoTareasCreador.aspx");
            }
            else if(e.CommandName == "cerrarReporte")
            {
                NegocioCrearTareas nTareas = new NegocioCrearTareas();
                int index = Convert.ToInt32(e.CommandArgument);
                nTareas.FinalizarReporte(gvdTareasReportadasCreador.Rows[index].Cells[0].Text);
                MessageBox.Show("AL FINALIZAR ESTE REPORTE, LA TAREA ES ACTIVADA NUEVAMENTE PARA LA PERSONA ASIGNADA", "CONTROL TAREAS");

                UsuarioLog usuarioLogin = new UsuarioLog();
                usuarioLogin.UserLog = Session["usuarioLogueado"].ToString();
                gvdTareasReportadasCreador.DataSource = nTareas.listarTareasReportadasCreador(usuarioLogin.UserLog);
                gvdTareasReportadasCreador.DataBind();
            }
            
        }

        protected void gdvSubTareasReportadas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "verReporte")
            {
                int index = Convert.ToInt32(e.CommandArgument);


                Session["idTask"] = gdvSubTareasReportadas.Rows[index].Cells[0].Text;
                Response.Redirect("ReporteTareas.aspx");
            }
            else if (e.CommandName == "IrTareas")
            {
                Response.Redirect("PantallaListadoTareasCreador.aspx");
            }
            else if (e.CommandName == "cerrarReporte")
            {
                NegocioCrearTareas nTareas = new NegocioCrearTareas();
                int index = Convert.ToInt32(e.CommandArgument);
                nTareas.FinalizarReporte(gdvSubTareasReportadas.Rows[index].Cells[0].Text);
                MessageBox.Show("AL FINALIZAR ESTE REPORTE, LA TAREA ES ACTIVADA NUEVAMENTE PARA LA PERSONA ASIGNADA", "CONTROL TAREAS");

                UsuarioLog usuarioLogin = new UsuarioLog();
                usuarioLogin.UserLog = Session["usuarioLogueado"].ToString();
                gdvSubTareasReportadas.DataSource = nTareas.listarSubTareasReportadasCreador(usuarioLogin.UserLog);
                gdvSubTareasReportadas.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("PantallaListadoTareasCreador.aspx");
        }
    }
}