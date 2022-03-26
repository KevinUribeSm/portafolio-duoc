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
    public partial class PantallaListadoTareasCreador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioLogueado"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            if (!IsPostBack)
            {

                this.listartareas();
                txtnombreTareas.Enabled = false;
                txtDescripcionTarea.Enabled = false;
                txtFechaIniTarea.Enabled = false;
                txtFechaTerminoTarea.Enabled = false;
                ddlResponsable.Enabled = false;
                btnCrear.Enabled = false;

            }

        }


        public void listartareas()
        {
            UsuarioLog usuarioLogin = new UsuarioLog();
            usuarioLogin.UserLog = Session["usuarioLogueado"].ToString();
            NegocioCrearTareas nTareas = new NegocioCrearTareas();
            gdvListadoTareas.DataSource = nTareas.listarTareas(usuarioLogin);
            gdvListadoTareas.DataBind();


            
        }


        protected void onrowediting_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gdvListadoTareas.EditIndex = e.NewEditIndex;
            this.listartareas();

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtidTarea.Text = "";
            txtnombreTareas.Text = "";
            txtDescripcionTarea.Text = "";
            txtFechaIniTarea.Text = "";
            txtFechaTerminoTarea.Text = "";
        }

        protected void gdvListadoTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtidTarea.Text = gdvListadoTareas.DataKeys.ToString();
            txtnombreTareas.Text = gdvListadoTareas.SelectedRow.Cells[2].Text;
        }

        protected void gdvListadoTareas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void gdvListadoTareas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gdvListadoTareas.EditIndex = -1;
            listartareas();
        }

        protected void gdvListadoTareas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

          
            
        }

        protected void Chk_CheckedChanged(object sender, EventArgs e)
        {
           
                int rowind = ((GridViewRow)(sender as System.Web.UI.Control).NamingContainer).RowIndex;


                txtidTarea.Text = gdvListadoTareas.Rows[rowind].Cells[1].Text;
                txtnombreTareas.Text = gdvListadoTareas.Rows[rowind].Cells[2].Text;
                txtDescripcionTarea.Text = gdvListadoTareas.Rows[rowind].Cells[3].Text;
                string fechaIni = gdvListadoTareas.Rows[rowind].Cells[4].Text;
                txtFechaIniTarea.Text = DateTime.Parse(fechaIni).ToShortDateString();
                txtFechaTerminoTarea.Text = gdvListadoTareas.Rows[rowind].Cells[5].Text;
                ddlResponsable.DataTextField = gdvListadoTareas.Rows[rowind].Cells[9].Text;
                ddlResponsable.DataValueField = gdvListadoTareas.Rows[rowind].Cells[8].Text;

                UsuarioLog usuarioLogin = new UsuarioLog();
                usuarioLogin.UserLog = Session["usuarioLogueado"].ToString();

                NegocioCrearTareas nTareas = new NegocioCrearTareas();
                ddlResponsable.DataSource = nTareas.listarUsuariosAsignar2(usuarioLogin.UserLog, ddlResponsable.DataValueField, ddlResponsable.DataTextField);


                ddlResponsable.DataTextField = "NOMBRE_USUARIO";
                ddlResponsable.DataValueField = "RUT";
                ddlResponsable.DataBind();

            txtnombreTareas.Enabled = true;
            txtDescripcionTarea.Enabled = true;
            txtFechaIniTarea.Enabled = true;
            txtFechaTerminoTarea.Enabled = true;
            ddlResponsable.Enabled = true;
            btnCrear.Enabled = true;


            //codigo para actualizar tarea


        }

        protected void btnCrear_Click1(object sender, EventArgs e)
        {
            if (txtnombreTareas.Text == "")
            {
                MessageBox.Show("INGRESA NOMBRE TAREA", "CONTROL TAREAS");
            }
            else if (txtDescripcionTarea.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR DESCRIPCION TAREA", "CONTROL TAREAS");
            }
            else if (txtFechaIniTarea.Text == "")
            {
                MessageBox.Show("INGRESA FECHA INICIO TAREA", "CONTROL TAREAS");
            }
            else if (txtFechaTerminoTarea.Text == "")
            {
                MessageBox.Show("INGRESA FECHA TERMINO TAREA", "CONTROL TAREAS");
            }
            else if (DateTime.Parse(txtFechaIniTarea.Text) < DateTime.Now)
            {
                MessageBox.Show("LA FECHA DE INICIO DE TAREA NO PUEDE SER MENOR A LA FECHA DE HOY", "SISTEMA CONTROL TAREAS");
            }
            else if (DateTime.Parse(txtFechaTerminoTarea.Text) < DateTime.Parse(txtFechaIniTarea.Text))
            {
                MessageBox.Show("LA FECHA DE FIN DE TAREA NO PUEDE SER MENOR A LA FECHA DE INICIO DE TAREA", "CONTROL TAREAS");
            }
            else
            {

                EntidadTareas eTareas = new EntidadTareas();
                string idTareas = txtidTarea.Text;
                eTareas.Nombre_tarea = txtnombreTareas.Text;
                eTareas.Descripcion_tarea = txtDescripcionTarea.Text;
                eTareas.Fecha_proceso = DateTime.Parse(txtFechaIniTarea.Text);
                eTareas.Fecha_fin = DateTime.Parse(txtFechaTerminoTarea.Text);
                eTareas.Rut_asignado_tarea = ddlResponsable.SelectedItem.Value;
                NegocioCrearTareas nTareas = new NegocioCrearTareas();
                nTareas.editarTareas(eTareas, idTareas);

                MessageBox.Show("Tarea actualizada Exitosamente", "CONTROL TAREAS");

                txtidTarea.Text = "";
                txtnombreTareas.Text = "";
                txtDescripcionTarea.Text = "";
                txtFechaIniTarea.Text = "";
                txtFechaTerminoTarea.Text = "";


                this.listartareas();
            }

        }

        protected void gdvListadoTareas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "crearSubTask")

            {
                int index = Convert.ToInt32(e.CommandArgument);


                Session["idTask"] = gdvListadoTareas.Rows[index].Cells[1].Text;
                Session["responsable"] = gdvListadoTareas.Rows[index].Cells[8].Text;
                Session["idProceso"] = gdvListadoTareas.Rows[index].Cells[7].Text;

                Response.Redirect("CrearSubTareasPages.aspx");

            }else if (e.CommandName == "ListarSubtask")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Session["idTask"] = gdvListadoTareas.Rows[index].Cells[1].Text;
                Response.Redirect("listarSubTareasPage.aspx");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("TareasReportadasCreador.aspx");
        }
    }
}