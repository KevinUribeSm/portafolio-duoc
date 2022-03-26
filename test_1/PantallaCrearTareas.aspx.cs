using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace test_1
{
    public partial class PantallaCrearTareas : System.Web.UI.Page
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
                string id_privilegio = "1";
                DataTable accesos = nAcceso.validaAcceso(usuarioLogin, id_privilegio);
                if (accesos.Rows.Count == 0)
                {
                    Response.Redirect("SinAcceso.aspx");

                }
                else if (!IsPostBack)
                {
                    UsuarioLog usuarioLogin2 = new UsuarioLog();
                    usuarioLogin2.UserLog = Session["usuarioLogueado"].ToString();

                    NegocioCrearTareas nTareas = new NegocioCrearTareas();

                    ddlEmpresa.DataSource = nTareas.listarProcesos(usuarioLogin2);
                    ddlEmpresa.DataTextField = "NOM_PROCESO";
                    ddlEmpresa.DataValueField = "ID_PROCESO";
                    ddlEmpresa.DataBind();


                    ddlResponsable.DataSource = nTareas.listarUsuariosAsignar(usuarioLogin2);
                    ddlResponsable.DataTextField = "NOMBRE_USUARIO";
                    ddlResponsable.DataValueField = "RUT";
                    ddlResponsable.DataBind();
                }
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaListadoTareasCreador.aspx");
            string usuarioLogin = Session["usuarioLogueado"].ToString();

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {

            if (txtnombreTareas.Text == "")
            {
                MessageBox.Show("INGRESA EL NOMBRE DE LA TAREA", "CONTROL TAREAS");
            }
            else if (ddlEmpresa.SelectedItem.Text == "SELECCIONE")
            {
                MessageBox.Show("SELECCIONA UN PROCESO", "CONTROL TAREAS");

            }
            else if (ddlResponsable.SelectedItem.Text  == "SELECCIONE")
            {
                MessageBox.Show("SELECCIONA UN RESPONSABLE", "CONTROL TAREAS");

            }
            else if (txtDescripcion.Text == "")
            {
                MessageBox.Show("INGRESA UN DESCRIPCIÓN", "CONTROL TAREAS");

            }
            else if (txtFechaInicial.Text == "")
            {
                MessageBox.Show("INGRESA LA FECHA DE INICIO DE TAREA", "CONTROL TAREAS");

            }
            else if (txtFechaTerminoTarea.Text == "")
            {
                MessageBox.Show("INGRESA LA FECHA DE FIN DE TAREA", "CONTROL TAREAS");

            }else if (DateTime.Parse(txtFechaInicial.Text) < DateTime.Now)
            {
                MessageBox.Show("LA FECHA DE INICIO DE TAREA NO PUEDE SER MENOR A LA FECHA DEL DIA DE HOY", "CONTROL TAREAS");

            }
            else if (DateTime.Parse(txtFechaTerminoTarea.Text) < DateTime.Parse(txtFechaInicial.Text))
            {
                MessageBox.Show("LA FECHA DE FIN NO PUEDE SER ANTERIOR A LA FECHA INICIAL", "CONTROL TAREAS");

            }
            else { 

            string usuarioLogin = Session["usuarioLogueado"].ToString();

                NegocioCrearTareas nTareas = new NegocioCrearTareas();
                EntidadTareas eTareas = new EntidadTareas();

                eTareas.Nombre_tarea = txtnombreTareas.Text;
                eTareas.Fecha_proceso = DateTime.Parse(txtFechaInicial.Text);
                eTareas.Fecha_fin = DateTime.Parse(txtFechaTerminoTarea.Text);
                eTareas.Descripcion_tarea = txtDescripcion.Text;
                eTareas.Id_proceso = ddlEmpresa.SelectedValue;
                eTareas.Rut_asignado_tarea = ddlResponsable.SelectedItem.Value;
                eTareas.Rut_creador_tarea = usuarioLogin;

                ResultadoDTO r = nTareas.insertTareas(eTareas);
                if (r.Ok)
                {
                    MessageBox.Show("REGISTRO EXITOSO", "CONTROL TAREAS");
                }
                else
                {
                    MessageBox.Show(r.mensaje, "CONTROL TAREAS");
                }
                this.limpiarCampos();
            }
            

            }

        

    

        

        protected void ddlEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("TareasReportadasCreador.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.limpiarCampos();
            //Response.Redirect("HomePage.aspx");
        }

        public void limpiarCampos()
        {
            ddlEmpresa.SelectedItem.Value = "0";
            txtnombreTareas.Text = "";
            txtDescripcion.Text = "";
            txtFechaInicial.Text = "";
            txtFechaTerminoTarea.Text = "";
            ddlResponsable.SelectedItem.Value = "0";
        }
    }
}