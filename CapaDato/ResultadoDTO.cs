using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class ResultadoDTO
    {
        public string id { set; get; }
        public bool Ok { set; get; }
        public string mensaje { set; get; }
        public object obj1 { set; get; }
        public object obj2 { set; get; }
        public object obj3 { set; get; }
    }
}
