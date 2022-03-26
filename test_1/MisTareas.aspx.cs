using System;
using CapaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace test_1
{
    public partial class MistTareas : System.Web.UI.Page
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
            string id_privilegio = "4";
            DataTable accesos =  nAcceso.validaAcceso(usuarioLogin,id_privilegio);
            if (accesos.Rows.Count == 0)
            {
                Response.Redirect("SinAcceso.aspx");

            }
            else if(!IsPostBack)
            {
                NegocioCrearTareas nTareas = new NegocioCrearTareas();
                nTareas.actualizaPorcentajeTareas();
                listarTareas();
            }

        }

        private void listarTareas()
        {
            string usuarioLogin = Session["usuarioLogueado"].ToString();
            NegocioCrearTareas tareas = new NegocioCrearTareas();



            this.TareasGrid.DataSource = tareas.misTareas(usuarioLogin);
            TareasGrid.DataBind();
        }

        protected void TareasGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TareasGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Session["idTask"] = TareasGrid.Rows[e.RowIndex].Cells[0].Text;
            Response.Redirect("TareasReportadas.aspx");
        }

        protected void TareasGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            TareasGrid.EditIndex = e.NewEditIndex;
            listarTareas();

        }

        protected void TareasGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(TareasGrid.DataKeys[e.RowIndex].Value);
            TextBox txt_field = (TextBox)TareasGrid.Rows[e.RowIndex].Cells[6].FindControl("txtTerminoReal");
            TextBox txt_field1 = (TextBox)TareasGrid.Rows[e.RowIndex].Cells[7].FindControl("txtPorcentaje");




            string fecha = txt_field.Text;
            string porcentaje = txt_field1.Text;


            NegocioCrearTareas tareas = new NegocioCrearTareas();

            tareas.FinalizarTarea(id.ToString(), Convert.ToInt32(porcentaje), Convert.ToDateTime(fecha));

            listarTareas();
        }

        protected void TareasGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            TareasGrid.EditIndex = -1;
            listarTareas();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MisTareasReportadas.aspx");
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //    //required to avoid the runtime error "
            //    //Control 'GridView1' of type 'GridView' must be placed inside a form tag with runat=server."
        }
        protected void TareasGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            {
                if (e.CommandName == "finalizarProceso")

                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    int id = Convert.ToInt32(TareasGrid.DataKeys[index].Value);

                    NegocioCrearTareas tareas = new NegocioCrearTareas();
                    tareas.FinalizarTarea(id.ToString());
                    listarTareas();
                }
                else if (e.CommandName == "verSubTask")
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    int id = Convert.ToInt32(TareasGrid.DataKeys[index].Value);
                    this.listarSubTask(id.ToString());
                }
              
            }
        }

        protected void subTareasGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            {
                if (e.CommandName == "finalizarProceso")

                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    int id = Convert.ToInt32(gdvSubTareas.DataKeys[index].Value);

                    NegocioCrearTareas tareas = new NegocioCrearTareas();
                    tareas.FinalizarTarea(id.ToString());
                    listarSubTask(id.ToString());
                }

            }

        }

        public void listarSubTask(string id)
        {
            NegocioSubTarea nSubTarea = new NegocioSubTarea();
            gdvSubTareas.DataSource = nSubTarea.listarSubTareas(id);
            gdvSubTareas.DataBind();
        }

        protected void subTareasGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Session["idTask"] = gdvSubTareas.Rows[e.RowIndex].Cells[0].Text;
            Response.Redirect("TareasReportadas.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=aaaa.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);


            StringWriter swr = new StringWriter();
            HtmlTextWriter htmlwr = new HtmlTextWriter(swr);
            TareasGrid.AllowPaging = false;
            listarTareas();

            TareasGrid.RenderControl(htmlwr);
            StringReader srr = new StringReader(swr.ToString());
            Document pdfdoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
            //HTMLWorker htmlparser = new HTMLWorker(pdfdoc);
            PdfWriter pdfWtiter = PdfWriter.GetInstance(pdfdoc, Response.OutputStream);
            //PdfWriter.GetInstance(pdfdoc, Response.OutputStream);

            pdfdoc.Open();

            XMLWorkerHelper.GetInstance().ParseXHtml(
              pdfWtiter, pdfdoc, srr
            );

            //htmlparser.Parse(srr);
            pdfdoc.Close();

            Response.Write(pdfdoc);
            Response.End();
        }
    }
}