using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CapaDato;
using CapaDatos;
using CapaNegocio;
using Oracle.DataAccess.Client;


namespace test_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usuarioLogueado"] = null;

        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
          
            NegocioLogin cliente = new NegocioLogin();

            ResultadoDTO r = cliente.LogearUsuario(tb_usuario.Text, tb_password.Text) ;
            if(r.Ok)
            {
                MessageBox.Show(tb_usuario.Text + " " + "LOGIN CORRECTO","CONTROL TAREAS");
                Session["usuarioLogueado"] = tb_usuario.Text;
                Response.Redirect("HomePage.aspx");
                
            }
            else
            {
                
                MessageBox.Show(r.mensaje,"MENSAJE");
            }

        }
    }
}