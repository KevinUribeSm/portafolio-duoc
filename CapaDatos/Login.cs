using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Login
    {
        private string rut;
        private int password;

        public string Rut { get => rut; set => rut = value; }
        public int Password { get => password; set => password = value; }
    }
}
