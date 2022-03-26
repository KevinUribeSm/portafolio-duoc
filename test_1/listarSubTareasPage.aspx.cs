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
    public partial class listarSubTareasPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioLogueado"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            if (!IsPostBack)
            {
                this.listarSubTask();
               
                txtnombreSubTarea.Enabled = false;
                txtDescripcionSubTarea.Enabled = false;
                txtFechaIniSubTarea.Enabled = false;
                txtFechaTerminoSubTarea.Enabled = false;
                btnActualizar.Enabled = false;
                

            }

            
        }

        public void listarSubTask()
        {
            string idTarea = Session["idTask"].ToString();
            NegocioSubTarea nSubTarea = new NegocioSubTarea();
            gdvListarSubTareas.DataSource = nSubTarea.listarSubTareas(idTarea);
            gdvListarSubTareas.DataBind();
        }

        protected void gdvListadoTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Chk_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void gdvListadoTareas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void gdvListadoTareas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
         


        }

        protected void Chk_CheckedChanged1(object sender, EventArgs e)
        {
            int rowind = ((GridViewRow)(sender as System.Web.UI.Control).NamingContainer).RowIndex;
            txtidTarea.Text  = gdvListarSubTareas.Rows[rowind].Cells[1].Text;
            txtnombreSubTarea.Text = gdvListarSubTareas.Rows[rowind].Cells[2].Text;
            txtDescripcionSubTarea.Text = gdvListarSubTareas.Rows[rowind].Cells[3].Text;
            txtFechaIniSubTarea.Text = gdvListarSubTareas.Rows[rowind].Cells[4].Text;
            txtFechaTerminoSubTarea.Text = gdvListarSubTareas.Rows[rowind].Cells[5].Text;
            txtResponsableSubTarea.Text = gdvListarSubTareas.Rows[rowind].Cells[8].Text;

            txtnombreSubTarea.Enabled = true;
            txtDescripcionSubTarea.Enabled = true;
            txtFechaIniSubTarea.Enabled = true;
            txtFechaTerminoSubTarea.Enabled = true;
            btnActualizar.Enabled = true;
        }

        protected void gdvListarSubTareas_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void gdvListarSubTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtnombreSubTarea.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR NOMBRE SUBTAREA", "CONTROL TAREAS");
            }
            else if (txtDescripcionSubTarea.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR DESCRIPCIÓN SUBTAREA", "CONTROL TAREAS");
            }
            else if (txtFechaIniSubTarea.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR FECHA DE INICIO SUBTAREA", "CONTROL TAREAS");
            }
            else if (txtFechaTerminoSubTarea.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR FECHA DE FIN SUBTAREA", "CONTROL TAREAS");
            }
            else if (DateTime.Parse(txtFechaIniSubTarea.Text) < DateTime.Now)
            {
                MessageBox.Show("LA FECHA DE INICIO DE TAREA NO PUEDE SER MENOR A LA FECHA DEL DIA DE HOY", "CONTROL TAREAS");
            }
            else if (DateTime.Parse(txtFechaTerminoSubTarea.Text) < DateTime.Parse(txtFechaIniSubTarea.Text))
            {
                MessageBox.Show("LA FECHA DE TERMINO DE TAREA NO PUDE SER MENOR A LA FECHA INICIO", "CONTROL TAREAS");
            }
            else
            {
                EntidadSubTarea eSubtareas = new EntidadSubTarea();
                string idSubTareas = txtidTarea.Text;
                eSubtareas.NomSubTarea = txtnombreSubTarea.Text;
                eSubtareas.DescripcionSubTarea = txtDescripcionSubTarea.Text;
                eSubtareas.Fecha_inicio = DateTime.Parse(txtFechaIniSubTarea.Text);
                eSubtareas.Fecha_fin = DateTime.Parse(txtFechaTerminoSubTarea.Text);
                eSubtareas.RutAsignado = txtResponsableSubTarea.Text;

                NegocioSubTarea nSubTareas = new NegocioSubTarea();
                nSubTareas.editarSubTareas(eSubtareas, idSubTareas);

                MessageBox.Show("Sub Tarea actualizada Exitosamente", "CONTROL TAREAS");

                txtidTarea.Text = "";
                txtnombreSubTarea.Text = "";
                txtDescripcionSubTarea.Text = "";
                txtFechaIniSubTarea.Text = "";
                txtFechaTerminoSubTarea.Text = "";
                txtResponsableSubTarea.Text = "";

                this.listarSubTask();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnombreSubTarea.Text = "";
            txtDescripcionSubTarea.Text = "";
            txtFechaIniSubTarea.Text = "";
            txtFechaTerminoSubTarea.Text = "";
            Response.Redirect("PantallaListadoTareasCreador.aspx");
        }

        protected void gdvListarSubTareas_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminarSubtask")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string idSubTask = gdvListarSubTareas.Rows[index].Cells[1].Text;
                NegocioSubTarea nSubTarea = new NegocioSubTarea();
                nSubTarea.eliminarSubtareas(idSubTask);
                MessageBox.Show("Sub Tarea Elimina Exitosamente", "CONTROL TAREAS");
                this.listarSubTask();

            }


        }
    }
}