using System;
using CapaDatos;
using CapaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace test_1
{
    public partial class TareasReportadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioLogueado"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }

            txtTarea.Text = Session["idTask"].ToString();
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtReporte.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR DESCRIPCION DE REPORTE", "CONTROL TAREAS");
            }
            else
            {
                NegocioCrearTareas tareas = new NegocioCrearTareas();

                tareas.InsertReporte(txtReporte.Text, txtTarea.Text);
                MessageBox.Show("SE CREA REPORTE", "CONTROL TAREAS");
                Response.Redirect("MisTareas.aspx");
                
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MisTareas.aspx");
        }
    }
}