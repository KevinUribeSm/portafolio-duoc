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
    public partial class CrearSubTareasPages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioLogueado"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            txtidTarea.Text = Session["idTask"].ToString();
            txtResponsableSubTarea.Text = Session["responsable"].ToString();
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtnombreSubTarea.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR NOMBRE DE SUBTAREA", "CONTROL TAREAS");
            }
            else if (txtDescripcionSubTarea.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR DESCRIPCIÓN DE SUBTAREA", "CONTROL TAREAS");

            }
            else if (txtFechaIniSubTarea.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR FECHCA DE INICIO DE SUBTAREA", "CONTROL TAREAS");

            }
            else if (txtFechaTerminoSubTarea.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR FECHA DE TERMINO DE SUBTAREA", "CONTROL TAREAS");

            }
            else if (DateTime.Parse(txtFechaIniSubTarea.Text) < DateTime.Now)
            {
                MessageBox.Show("LA FECHA DE INICIO DE SUBTAREA NO PUEDE SER MAYOR A LA FECHA DEL DIA DE HOY", "CONTROL TAREAS");

            }
            else if (DateTime.Parse(txtFechaTerminoSubTarea.Text) < DateTime.Parse(txtFechaIniSubTarea.Text))
            {
                MessageBox.Show("LA FECHA FIN DE SUBTAREA NO PUEDE SER MENOR A LA FECHA DE INICIO", "CONTROL TAREAS");

            }
            else
            {

                NegocioSubTarea nSubTarea = new NegocioSubTarea();
                EntidadSubTarea eSubtarea = new EntidadSubTarea();

                eSubtarea.IdTareaPadre = txtidTarea.Text;
                eSubtarea.NomSubTarea = txtnombreSubTarea.Text;
                eSubtarea.DescripcionSubTarea = txtDescripcionSubTarea.Text;
                eSubtarea.Fecha_inicio = DateTime.Parse(txtFechaIniSubTarea.Text);
                eSubtarea.Fecha_fin = DateTime.Parse(txtFechaTerminoSubTarea.Text);
                eSubtarea.RutAsignado = txtResponsableSubTarea.Text;
                eSubtarea.RutCreadorTarea = Session["usuarioLogueado"].ToString();
                eSubtarea.IdProceso = Session["idProceso"].ToString();

                ResultadoDTO r = nSubTarea.insertTareas(eSubtarea);
                if (r.Ok)
                {
                    MessageBox.Show("REGISTRO EXITOSO SUBTAREA", "CONTROL TAREAS");
                }
                else
                {
                    MessageBox.Show(r.mensaje, "CONTROL TAREAS");
                }
                this.limpiarCampos();
            }
           
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaListadoTareasCreador.aspx");
        }

        public void limpiarCampos()
        {
            txtnombreSubTarea.Text = "";
            txtDescripcionSubTarea.Text = "";
            txtFechaIniSubTarea.Text = "";
            txtFechaTerminoSubTarea.Text = "";
                
        }
    }
}