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
    public class NegocioAcceso
    {
        DatosAccesos dAccesos = new DatosAccesos();
        public DataTable validaAcceso(string rut,string id_privilegio)
        {
            return dAccesos.validaAcceso(rut, id_privilegio);
        }
    }
}
