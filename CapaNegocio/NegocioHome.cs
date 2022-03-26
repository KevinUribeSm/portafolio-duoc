using CapaDato;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioHome
    {
        DatosHome dHome = new DatosHome();

        public DataTable nombreUsuario(string rut)
        {
            return dHome.NombreUsuario(rut);
        }
    }

   
}
