using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test_1
{
    public partial class DashboardGeneral : System.Web.UI.Page
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
            string id_privilegio = "5";
            DataTable accesos = nAcceso.validaAcceso(usuarioLogin, id_privilegio);
            if (accesos.Rows.Count == 0)
            {
                Response.Redirect("SinAcceso.aspx");

            }
            else if (!IsPostBack)
            {
                NegocioDashboard dashboard = new NegocioDashboard();

                ddlEmpresa.DataSource = dashboard.listarEmpresas();
                ddlEmpresa.DataTextField = "NOMBRE_EMPRESA";
                ddlEmpresa.DataValueField = "RUT_EMPRESA";
                ddlEmpresa.DataBind();

            }



        }
        protected string obtenerData()
        {
            string usuarioLogin = Session["usuarioLogueado"].ToString();
            NegocioDashboard dashboard = new NegocioDashboard();

            DataTable table = new DataTable();

            DataTable data = dashboard.tareasEmpresa();

            DataTableReader reader = data.CreateDataReader();

            table.Load(reader);

            string strDatos;

            strDatos = "[['N1', 'Total tareas'],";

            foreach (DataRow dr in data.Rows)
            {
                strDatos = strDatos + "[";
                strDatos = strDatos + "'" + dr[0] + "'" + "," + dr[1];
                strDatos = strDatos + "],";
            }

            strDatos = strDatos + "]";

            return strDatos;


        }

        protected void ddlEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblRut.Text = ddlEmpresa.SelectedItem.Value;
        }


        public string dataPorcentajeProceso()
        {

            lblRut.Text = ddlEmpresa.SelectedItem.Value;
            NegocioDashboard dashboard = new NegocioDashboard();
            DataTable data = dashboard.listaPorcentajeProceso();

            DataTable table = new DataTable();

            DataTableReader reader = data.CreateDataReader();

            table.Load(reader);

            string strDatos;

            strDatos = "[['Rut Empresa', 'Nombre','Total Procesos','Procesos Terminados'," +
                "'Procesos Pendientes','% Terminados','% Pendientes','% Termino Atrasado'],";

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

        public string dataPorcentajeTareas(string rut_empresa)
        {
            NegocioDashboard dashboard = new NegocioDashboard();
            DataTable data = dashboard.porcentajeTarea(rut_empresa);

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

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //Response.ContentType = "application/pdf";
            //Response.AddHeader("content-disposition", "attachment;filename=aaaa.pdf");
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);


            //StringWriter swr = new StringWriter();
            //HtmlTextWriter htmlwr = new HtmlTextWriter(swr);


            //divPdf.RenderControl(htmlwr);
            //StringReader srr = new StringReader(swr.ToString());
            //Document pdfdoc = new Document(PageSize.A3, 10f, 10f, 10f, 0f);
            //HTMLWorker htmlparser = new HTMLWorker(pdfdoc);
            //PdfWriter pdfWtiter = PdfWriter.GetInstance(pdfdoc, Response.OutputStream);
            //PdfWriter.GetInstance(pdfdoc, Response.OutputStream);

            //pdfdoc.Open();

            //XMLWorkerHelper.GetInstance().ParseXHtml(
            // pdfWtiter, pdfdoc, srr
            //);

            //htmlparser.Parse(srr);
            //pdfdoc.Close();

            //Response.Write(pdfdoc);
            //Response.End();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}