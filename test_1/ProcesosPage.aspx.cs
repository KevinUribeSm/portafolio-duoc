using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CapaDato;
using TextBox = System.Web.UI.WebControls.TextBox;
using System.Data;

namespace test_1
{
    public partial class ProcesosPage : System.Web.UI.Page
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
            string id_privilegio = "2";
            DataTable accesos = nAcceso.validaAcceso(usuarioLogin, id_privilegio);
            if (accesos.Rows.Count == 0)
            {
                Response.Redirect("SinAcceso.aspx");

            }else if (!IsPostBack)
               
                listarData();

        }

        private void listarData()
        {
            string usuarioLogin = Session["usuarioLogueado"].ToString();
            NegocioProceso proceso = new NegocioProceso();

            this.procGrid.DataSource = proceso.listaProceso(usuarioLogin);

            procGrid.DataBind();
        }

        protected void btnCrear_Click1(object sender, EventArgs e)
        {
            if (txtIniProceso.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR FECHA DE INICIO", "CONTROL TAREAS");
            }else if (txtFechaFin.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR FECHA DE TERMINO", "CONTROL TAREAS");
            }else if(DateTime.Parse(txtIniProceso.Text)< DateTime.Now)
            {
                MessageBox.Show("LA FECHA DE INICIO NO PUEDE SER MENOR A LA FECHA DE HOY", "CONTROL TAREAS");
            }

            else if (Convert.ToDateTime(txtFechaFin.Text) <= Convert.ToDateTime(txtIniProceso.Text))
            {
                MessageBox.Show("La fecha fin no puede ser menor a la fecha inicio", "Control Tareas");
            }
            else if (txtProceso.Text.Length == 0 || txtDescProceso.Text.Length == 0)
            {
                MessageBox.Show("No se pueden dejar campos vacíos", "Control Tareas");
            }
            else if (txtProceso.Text.Length >= 50 || txtDescProceso.Text.Length >= 300)
            {
                MessageBox.Show("Un campo excede el largo de los caracteres", "Control Tareas");
            }
            else
            {

                string usuarioLogin = Session["usuarioLogueado"].ToString();

                NegocioProceso proceso = new NegocioProceso();

                ResultadoDTO r = proceso.insProceso(txtProceso.Text, txtDescProceso.Text, Convert.ToDateTime(txtIniProceso.Text), Convert.ToDateTime(txtFechaFin.Text)
                 , usuarioLogin);

                if (r.Ok)
                {
                    MessageBox.Show(txtProceso.Text + " " + "ingresado correctamente", "MENSAJE");

                }
                else
                {

                    MessageBox.Show(r.mensaje, "MENSAJE");
                }

                this.procGrid.DataSource = proceso.listaProceso(usuarioLogin);
                procGrid.DataBind();

            }
        }


        protected void procGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int id = Convert.ToInt32(procGrid.DataKeys[e.RowIndex].Value);
            NegocioProceso proceso = new NegocioProceso();
            proceso.activarProceso(id.ToString());
            listarData();
        }

        protected void procGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            procGrid.EditIndex = e.NewEditIndex;
            listarData();

        }

        protected void procGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            procGrid.EditIndex = -1;
            listarData();
        }

        protected void procGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {


            int id = Convert.ToInt32(procGrid.DataKeys[e.RowIndex].Value);
            TextBox txt_field = (TextBox)procGrid.Rows[e.RowIndex].Cells[2].FindControl("txtProceso");
            TextBox txt_field1 = (TextBox)procGrid.Rows[e.RowIndex].Cells[3].FindControl("TextBox2");
            TextBox txt_field2 = (TextBox)procGrid.Rows[e.RowIndex].Cells[4].FindControl("txtFechaInicio");
            TextBox txt_field3 = (TextBox)procGrid.Rows[e.RowIndex].Cells[5].FindControl("txtFechaFin");
            string nombre = txt_field.Text;
            string descripcion = txt_field1.Text;
            string fecha_inicio = txt_field2.Text;
            string fecha_fin = txt_field3.Text;

            if (nombre == "")
            {
                MessageBox.Show("DEBE COMPLETAR EL NOMBRE", "CONTROL TAREAS");
            }
            else if (descripcion == "")
            {
                MessageBox.Show("DEBE INGRESAR UNA DESCRIPCIÓN", "CONTROL TAREAS");
            }
            else if (fecha_inicio == "")
            {
                MessageBox.Show("DEBE INGRESAR FECHA DE INICIO DE TAREA", "CONTROL TAREAS");

            }
            else if (fecha_fin == "")
            {
                MessageBox.Show("DEBE INGRESAR FECHA FIN DE TAREA", "CONTROL TAREAS");
            }
            else if (DateTime.Parse(fecha_inicio) < DateTime.Now)
            {
                MessageBox.Show("LA FECHA DE INICIO NO PUEDE SER MENOR A LA FECHA DE HOY", "CONTROL TAREAS");
            }
            else if (DateTime.Parse(fecha_fin) < DateTime.Parse(fecha_inicio))
            {
                MessageBox.Show("LA FECHA DE FIN NO PUEDE SER MENOR A LA FECHA DE INICIO", "CONTROL TAREAS");
            }
            else
            {


                NegocioProceso proceso = new NegocioProceso();
                proceso.updateProcesos(nombre, descripcion, id.ToString(), Convert.ToDateTime(fecha_fin), Convert.ToDateTime(fecha_inicio));
                MessageBox.Show("PROCESO ACTUALIZADO", "CONTROL TAREAS");
                procGrid.EditIndex = -1;
                listarData();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtProceso.Text = string.Empty;
            txtDescProceso.Text = string.Empty;
            txtIniProceso.Text = string.Empty;
            txtFechaFin.Text = string.Empty;
            txtFechaTerminoReal.Text = string.Empty;
        }

        protected void procGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click1(object sender, EventArgs e)
        {
            txtProceso.Text = string.Empty;
            txtDescProceso.Text = string.Empty;
            txtIniProceso.Text = string.Empty;
            txtFechaFin.Text = string.Empty;
            txtFechaTerminoReal.Text = string.Empty;

            //Response.Redirect("HomePage.aspx");
        }

        protected void procGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            {
                if (e.CommandName == "finalizarProceso")

                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    int id = Convert.ToInt32(procGrid.DataKeys[index].Value);

                    NegocioProceso proceso = new NegocioProceso();
                    proceso.finalizarProceso(id.ToString());
                    listarData();
                }
                else
                {

                }
            }
        }

        protected void procGrid_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {

        }
    }

}