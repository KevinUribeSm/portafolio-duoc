using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace test_1
{
    public partial class Tareas1 : System.Web.UI.MasterPage
    {
        public void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioLogueado"] != null)
            {
                string usuarioLogin = Session["usuarioLogueado"].ToString();

                NegocioHome nHome = new NegocioHome();
                DataTable nombreTable = nHome.nombreUsuario(usuarioLogin);
                lblUsuario.Text = "BIENVENIDO/A:" + "  " + nombreTable.Rows[0]["NOMBRE_USUARIO"].ToString() + " " + "(" + usuarioLogin + ")" + " - " + nombreTable.Rows[0]["NOM_CARGO"].ToString(); 


            }
            

        }

     


    }
}