using CapaDato;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{

   public class NegocioLogin
    {

        public NegocioLogin()
        {
            
        }

        DatosLogin dLogin = new DatosLogin();

            public ResultadoDTO LogearUsuario(string usuario, string pass)
            {
              return dLogin.validaLogin(usuario, pass);
            }
  

    }
}
